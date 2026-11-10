namespace QuanLyNhanSu.GUI
{
    /// <summary>
    /// Form chính: chỉ điều phối giao diện (menu, tiêu đề, mở/đóng form chức năng).
    /// Không chứa bất kỳ xử lý dữ liệu nào.
    /// </summary>
    public partial class FormMain : Form
    {
        private static readonly Color MauNut = Color.FromArgb(30, 41, 59);
        private static readonly Color MauNutDangChon = Color.FromArgb(37, 99, 235);

        private Form? _formHienTai;
        private Button? _nutDangChon;

        public FormMain()
        {
            InitializeComponent();
            HienThiTongQuan();
        }

        // ===== Điều phối chung =====

        /// <summary>Quay về trang tổng quan.</summary>
        private void HienThiTongQuan()
        {
            DongFormHienTai();
            panelNoiDung.Visible = false;
            panelTongQuan.Visible = true;
            CapNhatGiaoDien(buttonTongQuan, "Tổng quan");
        }

        /// <summary>Mở form chức năng T vào panelNoiDung (nếu đang mở rồi thì giữ nguyên).</summary>
        private void MoForm<T>(Button nutMenu, string tieuDe) where T : Form, new()
        {
            if (_formHienTai is T)
            {
                CapNhatGiaoDien(nutMenu, tieuDe);
                return;
            }

            DongFormHienTai();

            T form = new T()
            {
                TopLevel = false,
                FormBorderStyle = FormBorderStyle.None,
                Dock = DockStyle.Fill
            };

            panelNoiDung.Controls.Add(form);
            _formHienTai = form;

            // Form con tự đóng (nút "Quay lại"/"Đóng") thì quay về trang tổng quan, không để vùng nội dung trống.
            form.FormClosed += (s, e) =>
            {
                if (_formHienTai == form) HienThiTongQuan();
            };

            panelTongQuan.Visible = false;
            panelNoiDung.Visible = true;
            CapNhatGiaoDien(nutMenu, tieuDe);
            form.Show();
        }

        private void DongFormHienTai()
        {
            if (_formHienTai == null) return;

            panelNoiDung.Controls.Remove(_formHienTai);
            _formHienTai.Dispose();
            _formHienTai = null;
        }

        /// <summary>Đổi tiêu đề và tô sáng nút menu đang chọn.</summary>
        private void CapNhatGiaoDien(Button nutMenu, string tieuDe)
        {
            labelTieuDe.Text = tieuDe;

            if (_nutDangChon != null)
                _nutDangChon.BackColor = MauNut;

            nutMenu.BackColor = MauNutDangChon;
            _nutDangChon = nutMenu;
        }

        // ===== Tổng quan =====

        private void buttonTongQuan_Click(object? sender, EventArgs e)
        {
            HienThiTongQuan();
        }

        // ===== Quản lý =====

        private void buttonDanhMuc_Click(object? sender, EventArgs e)
        {
            MoForm<FormDanhMuc>(buttonDanhMuc, "Quản lý danh mục");
        }

        private void buttonNhanVien_Click(object? sender, EventArgs e)
        {
            MoForm<FormNhanVien>(buttonNhanVien, "Quản lý hồ sơ nhân viên");
        }

        private void buttonQTDT_Click(object? sender, EventArgs e)
        {
            MoForm<FormQTDT>(buttonQTDT, "Quá trình đào tạo");
        }

        private void buttonQTCT_Click(object? sender, EventArgs e)
        {
            MoForm<FormQTCT>(buttonQTCT, "Quá trình công tác");
        }

        private void buttonQuaTrinhNV_Click(object? sender, EventArgs e)
        {
            MoForm<FormQuaTrinhNV>(buttonQuaTrinhNV, "Quá trình của nhân viên");
        }

        // ===== Tra cứu =====

        private void buttonTimKiemNV_Click(object? sender, EventArgs e)
        {
            MoForm<FormTimKiemNV>(buttonTimKiemNV, "Tìm kiếm nhân viên");
        }

        private void buttonTimKiemQTDT_Click(object? sender, EventArgs e)
        {
            MoForm<FormTimKiemQTDT>(buttonTimKiemQTDT, "Tìm kiếm quá trình đào tạo");
        }

        // ===== Báo cáo =====

        private void buttonBaoCaoNhanVien_Click(object? sender, EventArgs e)
        {
            MoForm<FormBaoCaoNhanVien>(buttonBaoCaoNhanVien, "Báo cáo nhân viên");
        }

        private void buttonBaoCaoQTCT_Click(object? sender, EventArgs e)
        {
            MoForm<FormBaoCaoQTCT>(buttonBaoCaoQTCT, "Báo cáo quá trình công tác");
        }

        private void buttonBaoCaoQTDT_Click(object? sender, EventArgs e)
        {
            MoForm<FormBaoCaoQTDT>(buttonBaoCaoQTDT, "Báo cáo quá trình đào tạo");
        }

        private void buttonBaoCaoQTDTChuaKetThuc_Click(object? sender, EventArgs e)
        {
            MoForm<FormBaoCaoQTDT_ChuaKetThuc>(buttonBaoCaoQTDTChuaKetThuc, "Báo cáo đào tạo chưa kết thúc");
        }
    }
}
