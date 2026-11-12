using QuanLyNhanSu.BUS;
using System;
using System.Data;
using System.Windows.Forms;

namespace QuanLyNhanSu.GUI
{
    public partial class FormBaoCaoQTDT : FormCoSo
    {
        public FormBaoCaoQTDT()
        {
            InitializeComponent();

            this.Load += FormBaoCaoQTDT_Load;
            buttonLoc.Click += buttonLoc_Click;
            buttonTaiLai.Click += buttonTaiLai_Click;
            buttonDong.Click += buttonDong_Click;
            buttonXuatExcel.Click += buttonXuatExcel_Click;
        }

        private void FormBaoCaoQTDT_Load(object? sender, EventArgs e)
        {
            CauHinhLuoiBaoCao(dataGridViewQTDT);
            NapDuLieuComboBox();

            // Tự động xem báo cáo (tất cả nhân viên/trường/ngành) ngay khi mở form.
            XemBaoCao(false);
        }

        private void NapDuLieuComboBox()
        {
            try
            {
                NapCombo(comboBoxNhanVien, NhanVienBUS.GetAll(), "MaNV",
                    r => Chuoi(r["HoTen"]), "Tất cả nhân viên");
                NapComboDanhMuc(comboBoxTruongDT, "TruongDT", "MaTruong", "TenTruong", "Tất cả trường đào tạo");
                NapComboDanhMuc(comboBoxNganhDT, "NganhDT", "MaNganh", "TenNganh", "Tất cả ngành đào tạo");
            }
            catch (Exception ex)
            {
                HienLoi(ex, "Lỗi nạp dữ liệu:");
            }
        }

        // Chạy báo cáo theo điều kiện đang chọn; hienThongBao = true thì báo khi không có dữ liệu.
        private void XemBaoCao(bool hienThongBao)
        {
            try
            {
                DataTable dt = BaoCaoBUS.BaoCaoQTDT(
                    LayMa(comboBoxNhanVien), LayMa(comboBoxTruongDT), LayMa(comboBoxNganhDT));

                dataGridViewQTDT.DataSource = dt;

                if (hienThongBao && dt.Rows.Count == 0)
                    ThongTin("Không tìm thấy quá trình đào tạo!");
            }
            catch (Exception ex)
            {
                HienLoi(ex, "Lỗi báo cáo:");
            }
        }

        private void buttonLoc_Click(object? sender, EventArgs e)
        {
            XemBaoCao(true);
        }

        // Đặt lại điều kiện về "Tất cả" và xem lại toàn bộ báo cáo.
        private void buttonTaiLai_Click(object? sender, EventArgs e)
        {
            DatDauTien(comboBoxNhanVien);
            DatDauTien(comboBoxTruongDT);
            DatDauTien(comboBoxNganhDT);
            XemBaoCao(false);
        }

        private void buttonXuatExcel_Click(object? sender, EventArgs e)
        {
            ExcelHelper.XuatExcel(
                dataGridViewQTDT,
                "BaoCaoQuaTrinhDaoTao"
            );
        }

        private void buttonDong_Click(object? sender, EventArgs e)
        {
            this.Close();
        }
    }
}
