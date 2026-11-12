using QuanLyNhanSu.BUS;
using System.Data;

namespace QuanLyNhanSu.GUI
{
    /// <summary>
    /// Tìm kiếm nhân viên theo mã, họ tên, phòng ban, chức vụ, học vấn, ngoại ngữ.
    /// Các tiêu chí để trống sẽ được bỏ qua; có thể kết hợp nhiều tiêu chí.
    /// Dữ liệu lấy từ NhanVienBUS.
    /// </summary>
    public partial class FormTimKiemNV : FormCoSo
    {
        public FormTimKiemNV()
        {
            InitializeComponent();

            // Chỉ hiển thị các cột đã khai báo trong Designer, không tự sinh thêm cột từ DataTable.
            // (Đặt ở đây vì Designer không lưu thuộc tính này.)
            dataGridViewKetQua.AutoGenerateColumns = false;
            TaoCotKetQua();

            // Cột tự giãn theo nội dung + tiêu đề (không bị cắt chữ); nếu rộng hơn form thì kéo thanh cuộn ngang.
            dataGridViewKetQua.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewKetQua.ScrollBars = ScrollBars.Both;
            dataGridViewKetQua.DataBindingComplete += dataGridViewKetQua_DataBindingComplete;
        }

        /// <summary>
        /// Cột cuối giãn lấp phần còn trống để thanh tiêu đề luôn kéo hết chiều ngang lưới
        /// (các cột còn lại vẫn theo nội dung; nếu tổng quá rộng thì có thanh cuộn ngang).
        /// </summary>
        private void dataGridViewKetQua_DataBindingComplete(object? sender, DataGridViewBindingCompleteEventArgs e)
        {
            GianCotCuoi(dataGridViewKetQua);
        }

        /// <summary>
        /// Khai báo các cột của lưới kết quả (Designer chưa có cột nào nên trước đây lưới trống).
        /// DataPropertyName phải trùng tên cột trả về từ NhanVienBUS (HoSoNV + các bảng danh mục).
        /// </summary>
        private void TaoCotKetQua()
        {
            if (dataGridViewKetQua.Columns.Count > 0) return;

            void Them(string tieuDe, string tenCot, float trongSo = 100, string? dinhDang = null)
            {
                var cot = new DataGridViewTextBoxColumn
                {
                    Name = "col" + tenCot,
                    HeaderText = tieuDe,
                    DataPropertyName = tenCot,
                    FillWeight = trongSo,
                    ReadOnly = true
                };
                if (dinhDang != null) cot.DefaultCellStyle.Format = dinhDang;
                dataGridViewKetQua.Columns.Add(cot);
            }

            Them("Mã NV", "MaNV", 60);
            Them("Họ tên", "HoTen", 130);
            Them("Giới tính", "TenGT", 60);
            Them("Ngày sinh", "NgaySinh", 80, "dd/MM/yyyy");
            Them("Phòng ban", "TenPhong", 110);
            Them("Chức vụ", "TenCV", 100);
            Them("Học vấn", "TenHV", 90);
            Them("Chuyên môn", "TenCM", 110);
            Them("Ngoại ngữ", "NgoaiNgu", 110);
            Them("Điện thoại", "DienThoai", 90);
            Them("Địa chỉ", "DiaChi", 140);
        }

        // ===== Khởi tạo =====

        private void FormTimKiemNV_Load(object? sender, EventArgs e)
        {
            if (DesignMode) return;

            try
            {
                NapComboDanhMuc(comboBoxPhongBan, "PhongBan", "MaPhong", "TenPhong");
                NapComboDanhMuc(comboBoxChucVu, "ChucVu", "MaCV", "TenCV");
                NapComboDanhMuc(comboBoxHocVan, "HocVan", "MaHV", "TenHV");
                NapComboDanhMuc(comboBoxNgoaiNgu, "NgoaiNgu", "MaNN", "TenNN");

                TimKiem();
            }
            catch (Exception ex)
            {
                HienLoi(ex, "Có lỗi khi truy vấn dữ liệu:");
            }
        }

        // ===== Tìm kiếm =====

        private void TimKiem()
        {
            DataTable ketQua = NhanVienBUS.TimKiem(
                textBoxHoTen.Text,
                comboBoxPhongBan.SelectedValue?.ToString(),
                comboBoxChucVu.SelectedValue?.ToString(),
                comboBoxHocVan.SelectedValue?.ToString(),
                comboBoxNgoaiNgu.SelectedValue?.ToString(),
                textBoxMaNV.Text);

            dataGridViewKetQua.DataSource = ketQua;
            labelTongSo.Text = $"Tổng số: {ketQua.Rows.Count} kết quả";
        }

        // ===== Sự kiện =====

        private void buttonTimKiem_Click(object? sender, EventArgs e)
        {
            try
            {
                TimKiem();
            }
            catch (Exception ex)
            {
                HienLoi(ex, "Có lỗi khi truy vấn dữ liệu:");
            }
        }

        private void buttonLamMoi_Click(object? sender, EventArgs e)
        {
            textBoxMaNV.Clear();
            textBoxHoTen.Clear();
            comboBoxPhongBan.SelectedIndex = 0;
            comboBoxChucVu.SelectedIndex = 0;
            comboBoxHocVan.SelectedIndex = 0;
            comboBoxNgoaiNgu.SelectedIndex = 0;

            try
            {
                TimKiem();
            }
            catch (Exception ex)
            {
                HienLoi(ex, "Có lỗi khi truy vấn dữ liệu:");
            }

            textBoxMaNV.Focus();
        }

        /// <summary>Nhấn Enter trong ô nhập để tìm kiếm.</summary>
        private void textBoxTimKiem_KeyDown(object? sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Enter) return;

            e.SuppressKeyPress = true;
            buttonTimKiem.PerformClick();
        }
    }
}