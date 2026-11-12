using QuanLyNhanSu.BUS;
using System.Data;

namespace QuanLyNhanSu.GUI
{
    /// <summary>
    /// Tìm kiếm quá trình đào tạo theo nhân viên, trường đào tạo, hình thức và khoảng ngày.
    /// Dữ liệu lấy từ QTDTBUS.
    /// </summary>
    public partial class FormTimKiemQTDT : FormCoSo
    {
        public FormTimKiemQTDT()
        {
            InitializeComponent();

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

        // ===== Khởi tạo =====

        private void FormTimKiemQTDT_Load(object? sender, EventArgs e)
        {
            if (DesignMode) return;

            try
            {
                NapComboBoxNhanVien();
                NapComboDanhMuc(comboBoxTruongDaoTao, "TruongDT", "MaTruong", "TenTruong");
                NapComboDanhMuc(comboBoxHinhThuc, "HinhThuc", "MaHT", "TenHT");

                TimKiem();
            }
            catch (Exception ex)
            {
                HienLoi(ex, "Có lỗi khi truy vấn dữ liệu:");
            }
        }

        /// <summary>Nạp danh sách nhân viên, hiển thị dạng "Mã - Họ tên"; dòng đầu để trống (= không lọc).</summary>
        private void NapComboBoxNhanVien()
        {
            DataTable bang = NhanVienBUS.GetAll();
            bang.Columns.Add("HienThi", typeof(string),
                "IIF(MaNV = '', '', MaNV + ' - ' + ISNULL(HoTen, ''))");

            DataRow dongTrong = bang.NewRow();
            dongTrong["MaNV"] = "";
            bang.Rows.InsertAt(dongTrong, 0);

            comboBoxNhanVien.DisplayMember = "HienThi";
            comboBoxNhanVien.ValueMember = "MaNV";
            comboBoxNhanVien.DataSource = bang;
            comboBoxNhanVien.SelectedIndex = 0;
        }

        // ===== Tìm kiếm =====

        private void TimKiem()
        {
            DateTime? tuNgay = dateTimePickerTuNgay.Checked ? dateTimePickerTuNgay.Value.Date : null;
            DateTime? denNgay = dateTimePickerDenNgay.Checked ? dateTimePickerDenNgay.Value.Date : null;

            DataTable ketQua = QTDTBUS.TimKiem(
                comboBoxNhanVien.SelectedValue?.ToString(),
                comboBoxTruongDaoTao.SelectedValue?.ToString(),
                comboBoxHinhThuc.SelectedValue?.ToString(),
                tuNgay,
                denNgay);

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
            comboBoxNhanVien.SelectedIndex = 0;
            comboBoxTruongDaoTao.SelectedIndex = 0;
            comboBoxHinhThuc.SelectedIndex = 0;
            dateTimePickerTuNgay.Checked = false;
            dateTimePickerDenNgay.Checked = false;

            try
            {
                TimKiem();
            }
            catch (Exception ex)
            {
                HienLoi(ex, "Có lỗi khi truy vấn dữ liệu:");
            }
        }
    }
}