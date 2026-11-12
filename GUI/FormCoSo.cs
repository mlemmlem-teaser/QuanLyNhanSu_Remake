
using System;
using System.Data;
using System.Windows.Forms;
using QuanLyNhanSu.BUS;

namespace QuanLyNhanSu.GUI
{
    /// <summary>
    /// Lớp cha của các form chức năng. Gom các hàm trước đây bị viết lặp ở nhiều form:
    /// hộp thoại thông báo/lỗi, nạp ComboBox, đọc/ghi giá trị ô nhập, định dạng lưới.
    /// Lớp này không có giao diện riêng và không xử lý dữ liệu nghiệp vụ.
    /// </summary>
    public class FormCoSo : Form
    {
        // ===== Thông báo =====

        /// <summary>Cảnh báo (dùng cho lỗi người dùng nhập thiếu/sai).</summary>
        protected static void Canh(string noiDung)
        {
            MessageBox.Show(noiDung, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        /// <summary>Thông tin thường (ví dụ "không có dữ liệu").</summary>
        protected static void ThongTin(string noiDung)
        {
            MessageBox.Show(noiDung, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        /// <summary>
        /// Hiện lỗi: lỗi nghiệp vụ (NghiepVuException) hiện dạng cảnh báo,
        /// lỗi khác (CSDL, hệ thống...) hiện dạng lỗi kèm tiêu đề thongBaoLoi.
        /// </summary>
        protected static void HienLoi(Exception ex, string thongBaoLoi = "Thao tác không thành công.")
        {
            if (ex is NghiepVuException)
            {
                Canh(ex.Message);
                return;
            }

            MessageBox.Show(thongBaoLoi + "\n" + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        // ===== Giá trị và ComboBox =====

        /// <summary>Đổi giá trị bất kỳ sang chuỗi; null/DBNull thành chuỗi rỗng.</summary>
        protected static string Chuoi(object? giaTri)
        {
            if (giaTri == null || giaTri == DBNull.Value) return "";
            return Convert.ToString(giaTri) ?? "";
        }

        /// <summary>Nạp ComboBox: dòng đầu là lựa chọn "trống" (mã rỗng), các dòng sau lấy từ bảng nguồn.</summary>
        protected static void NapCombo(ComboBox combo, DataTable nguon, string cotMa,
            Func<DataRow, string> layTen, string chuTrong)
        {
            DataTable ds = new DataTable();
            ds.Columns.Add("Ma", typeof(string));
            ds.Columns.Add("Ten", typeof(string));
            ds.Rows.Add("", chuTrong);
            foreach (DataRow r in nguon.Rows)
                ds.Rows.Add(Chuoi(r[cotMa]), layTen(r));

            combo.DropDownStyle = ComboBoxStyle.DropDownList;
            combo.DisplayMember = "Ten";
            combo.ValueMember = "Ma";
            combo.DataSource = ds;
            if (ds.Rows.Count > 0) combo.SelectedIndex = 0;
        }

        /// <summary>Nạp ComboBox từ một danh mục (qua DanhMucBUS) với dòng đầu là lựa chọn trống.</summary>
        protected static void NapComboDanhMuc(ComboBox combo, string loaiDanhMuc, string cotMa, string cotTen,
            string chuTrong = "")
        {
            NapCombo(combo, DanhMucBUS.GetAll(loaiDanhMuc), cotMa, r => Chuoi(r[cotTen]), chuTrong);
        }

        /// <summary>Mã đang chọn trong ComboBox; null nếu chọn dòng trống.</summary>
        protected static string? LayMa(ComboBox combo)
        {
            string ma = Chuoi(combo.SelectedValue);
            return string.IsNullOrWhiteSpace(ma) ? null : ma;
        }

        /// <summary>Chọn mục có mã tương ứng; không có (hoặc null) thì về dòng trống.</summary>
        protected static void DatCombo(ComboBox combo, object? ma)
        {
            combo.SelectedValue = Chuoi(ma);
            if (combo.SelectedIndex < 0 && combo.Items.Count > 0) combo.SelectedIndex = 0;
        }

        /// <summary>Chọn dòng đầu tiên nếu ComboBox có dữ liệu (tránh lỗi khi chưa nạp được từ CSDL).</summary>
        protected static void DatDauTien(ComboBox combo)
        {
            if (combo.Items.Count > 0) combo.SelectedIndex = 0;
        }

        /// <summary>Ngày rỗng: ô có checkbox -> bỏ tick; ô thường -> về hôm nay.</summary>
        protected static void DatNgay(DateTimePicker picker, object? giaTri)
        {
            if (giaTri == null || giaTri == DBNull.Value)
            {
                if (picker.ShowCheckBox) picker.Checked = false;
                else picker.Value = DateTime.Today;
                return;
            }
            picker.Value = Convert.ToDateTime(giaTri);
            if (picker.ShowCheckBox) picker.Checked = true;
        }

        // ===== Lưới dữ liệu =====

        /// <summary>Đặt tiêu đề, ẩn/hiện và định dạng cho một cột của lưới (bỏ qua nếu không có cột đó).</summary>
        protected static void DatCot(DataGridView luoi, string ten, string tieuDe, bool hien = true, string? dinhDang = null)
        {
            if (!luoi.Columns.Contains(ten)) return;
            DataGridViewColumn cot = luoi.Columns[ten]!;
            cot.HeaderText = tieuDe;
            cot.Visible = hien;
            if (dinhDang != null) cot.DefaultCellStyle.Format = dinhDang;
        }

        /// <summary>Cấu hình lưới báo cáo: chỉ đọc, chọn cả dòng, cột tự giãn, và xóa dữ liệu cũ.</summary>
        protected static void CauHinhLuoiBaoCao(DataGridView luoi)
        {
            luoi.AutoGenerateColumns = true;
            luoi.ReadOnly = true;
            luoi.AllowUserToAddRows = false;
            luoi.AllowUserToDeleteRows = false;
            luoi.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            luoi.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            luoi.MultiSelect = false;
            luoi.RowHeadersVisible = false;
            luoi.DataSource = null;
            luoi.Columns.Clear();
        }

        /// <summary>Cột cuối của lưới giãn hết phần còn lại (gọi trong sự kiện DataBindingComplete).</summary>
        protected static void GianCotCuoi(DataGridView luoi)
        {
            if (luoi.Columns.Count == 0) return;

            DataGridViewColumn cotCuoi = luoi.Columns[luoi.Columns.Count - 1];
            cotCuoi.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            cotCuoi.MinimumWidth = 150;
        }
    }
}
