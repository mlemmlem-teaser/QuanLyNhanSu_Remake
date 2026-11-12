using QuanLyNhanSu.BUS;
using QuanLyNhanSu.DTO;
using System;
using System.Data;
using System.Windows.Forms;

namespace QuanLyNhanSu.GUI
{
    /// <summary>
    /// Quản lý quá trình đào tạo (thêm / sửa / xóa). Dữ liệu qua QTDTBUS và DanhMucBUS.
    /// Chọn một dòng trong danh sách để sửa/xóa; bấm "Làm mới" để nhập quá trình mới.
    /// </summary>
    public partial class FormQTDT : FormCoSo
    {
        // true khi code đang nạp dữ liệu: bỏ qua sự kiện chọn dòng / đổi bộ lọc để tránh nạp lặp.
        private bool dangNap;

        public FormQTDT()
        {
            InitializeComponent();
        }

        private void FormQTDT_Load(object? sender, EventArgs e)
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

                DataTable truong = DanhMucBUS.GetAll("TruongDT");
                Func<DataRow, string> tenTruong = r => Chuoi(r["TenTruong"]);
                NapCombo(comboBoxLocTruong, truong, "MaTruong", tenTruong, "Tất cả trường");
                NapCombo(comboBoxTruong, truong, "MaTruong", tenTruong, "-- Chọn trường --");

                NapCombo(comboBoxHinhThuc, DanhMucBUS.GetAll("HinhThuc"), "MaHT",
                    r => Chuoi(r["TenHT"]), "-- Chọn hình thức --");
                NapCombo(comboBoxNganh, DanhMucBUS.GetAll("NganhDT"), "MaNganh",
                    r => Chuoi(r["TenNganh"]), "-- Chọn ngành --");
                NapCombo(comboBoxXepLoai, DanhMucBUS.GetAll("XepLoai"), "MaXL",
                    r => Chuoi(r["TenXL"]), "-- Chưa xếp loại --");
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
                DataTable bang = QTDTBUS.TimKiem(LayMa(comboBoxLocNhanVien), LayMa(comboBoxLocTruong), null);
                dataGridViewQTDT.DataSource = bang;
                DinhDangLuoi();
                dataGridViewQTDT.ClearSelection();
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
            DataGridView g = dataGridViewQTDT;
            DatCot(g, "MaQTDT", "Mã QTĐT");
            DatCot(g, "MaNV", "Mã NV");
            DatCot(g, "HoTen", "Họ tên");
            DatCot(g, "TuNgay", "Từ ngày", true, "dd/MM/yyyy");
            DatCot(g, "DenNgay", "Đến ngày", true, "dd/MM/yyyy");
            DatCot(g, "TenTruong", "Trường đào tạo");
            DatCot(g, "TenHT", "Hình thức");
            DatCot(g, "TenNganh", "Ngành");
            DatCot(g, "TenXL", "Xếp loại");
            DatCot(g, "MaTruong", "MaTruong", false);
            DatCot(g, "MaHT", "MaHT", false);
            DatCot(g, "MaNganh", "MaNganh", false);
            DatCot(g, "MaXL", "MaXL", false);
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
                DatDauTien(comboBoxTruong);
                DatDauTien(comboBoxHinhThuc);
                DatDauTien(comboBoxNganh);
                DatDauTien(comboBoxXepLoai);
                dateTimePickerTuNgay.Value = DateTime.Today;
                dateTimePickerDenNgay.Checked = false;
                dataGridViewQTDT.ClearSelection();
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
                return QTDTBUS.TaoMaMoi();
            }
            catch
            {
                return "";
            }
        }

        // Đọc dữ liệu từ các ô nhập vào DTO. Việc kiểm tra hợp lệ do tầng BUS thực hiện khi Thêm/Sửa.
        private QuaTrinhDaoTaoDTO LayDuLieu()
        {
            return new QuaTrinhDaoTaoDTO
            {
                MaQTDT = textBoxMa.Text.Trim(),
                MaNV = LayMa(comboBoxNhanVien) ?? "",
                TuNgay = dateTimePickerTuNgay.Value.Date,
                DenNgay = dateTimePickerDenNgay.Checked ? dateTimePickerDenNgay.Value.Date : (DateTime?)null,
                MaTruong = LayMa(comboBoxTruong),
                MaHT = LayMa(comboBoxHinhThuc),
                MaNganh = LayMa(comboBoxNganh),
                MaXL = LayMa(comboBoxXepLoai)    // xếp loại có thể để trống (chưa kết thúc)
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
        private void dataGridViewQTDT_SelectionChanged(object? sender, EventArgs e)
        {
            if (dangNap || dataGridViewQTDT.SelectedRows.Count == 0) return;
            DataRowView? dong = dataGridViewQTDT.SelectedRows[0].DataBoundItem as DataRowView;
            if (dong == null) return;

            dangNap = true;
            try
            {
                textBoxMa.Text = Chuoi(dong["MaQTDT"]);
                textBoxMa.ReadOnly = true;
                DatCombo(comboBoxNhanVien, dong["MaNV"]);
                DatCombo(comboBoxTruong, dong["MaTruong"]);
                DatCombo(comboBoxHinhThuc, dong["MaHT"]);
                DatCombo(comboBoxNganh, dong["MaNganh"]);
                DatCombo(comboBoxXepLoai, dong["MaXL"]);
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

            QuaTrinhDaoTaoDTO q = LayDuLieu();

            try
            {
                QTDTBUS.Insert(q);
                NapLuoi();
                NhapMoi();
                MessageBox.Show("Đã thêm quá trình đào tạo.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                HienLoi(ex);
            }
        }

        private void buttonEdit_Click(object? sender, EventArgs e)
        {
            if (!textBoxMa.ReadOnly || dataGridViewQTDT.SelectedRows.Count == 0)
            {
                Canh("Hãy chọn quá trình cần sửa trong danh sách.");
                return;
            }

            QuaTrinhDaoTaoDTO q = LayDuLieu();

            try
            {
                QTDTBUS.Update(q);
                NapLuoi();
                NhapMoi();
                MessageBox.Show("Đã cập nhật quá trình đào tạo.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                HienLoi(ex);
            }
        }

        private void buttonDelete_Click(object? sender, EventArgs e)
        {
            DataRowView? dong = dataGridViewQTDT.SelectedRows.Count == 0
                ? null
                : dataGridViewQTDT.SelectedRows[0].DataBoundItem as DataRowView;
            if (dong == null)
            {
                Canh("Hãy chọn quá trình cần xóa trong danh sách.");
                return;
            }

            string ma = Chuoi(dong["MaQTDT"]);
            if (MessageBox.Show("Bạn có chắc muốn xóa quá trình đào tạo " + ma + "?", "Xác nhận",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes) return;

            try
            {
                QTDTBUS.Delete(ma);
                NapLuoi();
                NhapMoi();
                MessageBox.Show("Đã xóa quá trình đào tạo.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            DatDauTien(comboBoxLocTruong);
            dangNap = false;
            NapLuoi();
            NhapMoi();
        }
    }
}
