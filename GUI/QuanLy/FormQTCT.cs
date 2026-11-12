using QuanLyNhanSu.BUS;
using QuanLyNhanSu.DTO;
using System;
using System.Data;
using System.Windows.Forms;

namespace QuanLyNhanSu.GUI
{
    /// <summary>
    /// Quản lý quá trình công tác (thêm / sửa / xóa). Dữ liệu qua QTCTBUS và DanhMucBUS.
    /// Chọn một dòng trong danh sách để sửa/xóa; bấm "Làm mới" để nhập quá trình mới.
    /// </summary>
    public partial class FormQTCT : FormCoSo
    {
        // true khi code đang nạp dữ liệu: bỏ qua sự kiện chọn dòng / đổi bộ lọc để tránh nạp lặp.
        private bool dangNap;

        public FormQTCT()
        {
            InitializeComponent();
        }

        private void FormQTCT_Load(object? sender, EventArgs e)
        {
            NapDanhSachChon();
            NapLuoi();
            NhapMoi();
        }

        // ===== Nạp dữ liệu =====

        private void NapDanhSachChon()
        {
            dangNap = true;
            try
            {
                DataTable nhanVien = NhanVienBUS.GetAll();
                Func<DataRow, string> tenNV = r => Chuoi(r["MaNV"]) + " - " + Chuoi(r["HoTen"]);
                NapCombo(comboBoxLocNhanVien, nhanVien, "MaNV", tenNV, "Tất cả nhân viên");
                NapCombo(comboBoxNhanVien, nhanVien, "MaNV", tenNV, "-- Chọn nhân viên --");

                DataTable phongBan = DanhMucBUS.GetAll("PhongBan");
                Func<DataRow, string> tenPhong = r => Chuoi(r["TenPhong"]);
                NapCombo(comboBoxLocPhongBan, phongBan, "MaPhong", tenPhong, "Tất cả phòng ban");
                NapCombo(comboBoxPhongBan, phongBan, "MaPhong", tenPhong, "-- Chọn phòng ban --");

                NapCombo(comboBoxChucVu, DanhMucBUS.GetAll("ChucVu"), "MaCV",
                    r => Chuoi(r["TenCV"]), "-- Chọn chức vụ --");
            }
            catch (Exception ex)
            {
                HienLoi(ex);
            }
            finally
            {
                dangNap = false;
            }
        }

        private void NapLuoi()
        {
            dangNap = true;
            try
            {
                DataTable bang = QTCTBUS.TimKiem(LayMa(comboBoxLocNhanVien), LayMa(comboBoxLocPhongBan));
                dataGridViewQTCT.DataSource = bang;
                DinhDangLuoi();
                dataGridViewQTCT.ClearSelection();
            }
            catch (Exception ex)
            {
                HienLoi(ex);
            }
            finally
            {
                dangNap = false;
            }
        }

        private void DinhDangLuoi()
        {
            DataGridView g = dataGridViewQTCT;
            DatCot(g, "MaQTCT", "Mã QTCT");
            DatCot(g, "MaNV", "Mã NV");
            DatCot(g, "HoTen", "Họ tên");
            DatCot(g, "TuNgay", "Từ ngày", true, "dd/MM/yyyy");
            DatCot(g, "DenNgay", "Đến ngày", true, "dd/MM/yyyy");
            DatCot(g, "TenPhong", "Phòng ban");
            DatCot(g, "TenCV", "Chức vụ");
            DatCot(g, "MaPhong", "MaPhong", false);
            DatCot(g, "MaCV", "MaCV", false);
        }

        // ===== Nhập liệu =====

        // Xóa trống ô nhập, gợi ý mã mới, cho phép nhập mã (chế độ thêm mới).
        private void NhapMoi()
        {
            dangNap = true;
            try
            {
                textBoxMa.Text = TaoMaMoi();
                textBoxMa.ReadOnly = false;
                DatDauTien(comboBoxNhanVien);
                DatDauTien(comboBoxPhongBan);
                DatDauTien(comboBoxChucVu);
                dateTimePickerTuNgay.Value = DateTime.Today;
                dateTimePickerDenNgay.Checked = false;
                dataGridViewQTCT.ClearSelection();
            }
            finally
            {
                dangNap = false;
            }
        }

        // Mã gợi ý do tầng BUS sinh (mã số lớn nhất hiện có + 1); người dùng vẫn có thể tự sửa.
        private static string TaoMaMoi()
        {
            try
            {
                return QTCTBUS.TaoMaMoi();
            }
            catch
            {
                return "";
            }
        }

        // Đọc dữ liệu từ các ô nhập vào DTO. Việc kiểm tra hợp lệ do tầng BUS thực hiện khi Thêm/Sửa.
        private QuaTrinhCongTacDTO LayDuLieu()
        {
            return new QuaTrinhCongTacDTO
            {
                MaQTCT = textBoxMa.Text.Trim(),
                MaNV = LayMa(comboBoxNhanVien) ?? "",
                TuNgay = dateTimePickerTuNgay.Value.Date,
                DenNgay = dateTimePickerDenNgay.Checked ? dateTimePickerDenNgay.Value.Date : (DateTime?)null,   // bỏ tick = đang công tác
                MaPhong = LayMa(comboBoxPhongBan),
                MaCV = LayMa(comboBoxChucVu)
            };
        }

        // ===== Sự kiện =====

        private void comboBoxLoc_SelectedIndexChanged(object? sender, EventArgs e)
        {
            if (dangNap) return;
            NapLuoi();
            NhapMoi();
        }

        // Chọn một dòng -> hiện lên các ô nhập để sửa (mã bị khóa vì là khóa chính).
        private void dataGridViewQTCT_SelectionChanged(object? sender, EventArgs e)
        {
            if (dangNap || dataGridViewQTCT.SelectedRows.Count == 0) return;
            DataRowView? dong = dataGridViewQTCT.SelectedRows[0].DataBoundItem as DataRowView;
            if (dong == null) return;

            dangNap = true;
            try
            {
                textBoxMa.Text = Chuoi(dong["MaQTCT"]);
                textBoxMa.ReadOnly = true;
                DatCombo(comboBoxNhanVien, dong["MaNV"]);
                DatCombo(comboBoxPhongBan, dong["MaPhong"]);
                DatCombo(comboBoxChucVu, dong["MaCV"]);
                DatNgay(dateTimePickerTuNgay, dong["TuNgay"]);
                DatNgay(dateTimePickerDenNgay, dong["DenNgay"]);
            }
            finally
            {
                dangNap = false;
            }
        }

        private void buttonAdd_Click(object? sender, EventArgs e)
        {
            if (textBoxMa.ReadOnly)
            {
                Canh("Đang chọn một quá trình có sẵn. Hãy bấm \"Làm mới\" để nhập quá trình mới.");
                return;
            }

            QuaTrinhCongTacDTO q = LayDuLieu();

            try
            {
                QTCTBUS.Insert(q);
                NapLuoi();
                NhapMoi();
                MessageBox.Show("Đã thêm quá trình công tác.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                HienLoi(ex);
            }
        }

        private void buttonEdit_Click(object? sender, EventArgs e)
        {
            if (!textBoxMa.ReadOnly || dataGridViewQTCT.SelectedRows.Count == 0)
            {
                Canh("Hãy chọn quá trình cần sửa trong danh sách.");
                return;
            }

            QuaTrinhCongTacDTO q = LayDuLieu();

            try
            {
                QTCTBUS.Update(q);
                NapLuoi();
                NhapMoi();
                MessageBox.Show("Đã cập nhật quá trình công tác.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                HienLoi(ex);
            }
        }

        private void buttonDelete_Click(object? sender, EventArgs e)
        {
            DataRowView? dong = dataGridViewQTCT.SelectedRows.Count == 0
                ? null
                : dataGridViewQTCT.SelectedRows[0].DataBoundItem as DataRowView;
            if (dong == null)
            {
                Canh("Hãy chọn quá trình cần xóa trong danh sách.");
                return;
            }

            string ma = Chuoi(dong["MaQTCT"]);
            if (MessageBox.Show("Bạn có chắc muốn xóa quá trình công tác " + ma + "?", "Xác nhận",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes) return;

            try
            {
                QTCTBUS.Delete(ma);
                NapLuoi();
                NhapMoi();
                MessageBox.Show("Đã xóa quá trình công tác.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                HienLoi(ex);
            }
        }

        // Đặt lại bộ lọc, nạp lại danh sách và chuyển sang chế độ nhập mới.
        private void buttonRefresh_Click(object? sender, EventArgs e)
        {
            dangNap = true;
            DatDauTien(comboBoxLocNhanVien);
            DatDauTien(comboBoxLocPhongBan);
            dangNap = false;
            NapLuoi();
            NhapMoi();
        }
    }
}
