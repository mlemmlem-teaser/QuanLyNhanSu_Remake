using QuanLyNhanSu.BUS;
using System;
using System.Data;
using System.Windows.Forms;

namespace QuanLyNhanSu.GUI
{
    public partial class FormBaoCaoQTCT : FormCoSo
    {
        public FormBaoCaoQTCT()
        {
            InitializeComponent();

            this.Load += FormBaoCaoQTCT_Load;
            buttonLoc.Click += buttonLoc_Click;
            buttonTaiLai.Click += buttonTaiLai_Click;
            buttonDong.Click += buttonDong_Click;
            buttonXuatExcel.Click += buttonXuatExcel_Click;
        }

        private void FormBaoCaoQTCT_Load(object? sender, EventArgs e)
        {
            CauHinhLuoiBaoCao(dataGridViewQTCT);
            NapDuLieuComboBox();

            // Tự động xem báo cáo (tất cả nhân viên/phòng ban) ngay khi mở form.
            XemBaoCao(false);
        }

        private void NapDuLieuComboBox()
        {
            try
            {
                NapCombo(comboBoxNhanVien, NhanVienBUS.GetAll(), "MaNV",
                    r => Chuoi(r["HoTen"]), "Tất cả nhân viên");
                NapComboDanhMuc(comboBoxPhongBan, "PhongBan", "MaPhong", "TenPhong", "Tất cả phòng ban");
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
                DataTable dt = BaoCaoBUS.BaoCaoQTCT(LayMa(comboBoxNhanVien), LayMa(comboBoxPhongBan));

                dataGridViewQTCT.DataSource = dt;

                if (hienThongBao && dt.Rows.Count == 0)
                    ThongTin("Không tìm thấy quá trình công tác!");
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
            DatDauTien(comboBoxPhongBan);
            XemBaoCao(false);
        }

        private void buttonXuatExcel_Click(object? sender, EventArgs e)
        {
            ExcelHelper.XuatExcel(
                dataGridViewQTCT,
                "BaoCaoQuaTrinhCongTac"
            );
        }

        private void buttonDong_Click(object? sender, EventArgs e)
        {
            this.Close();
        }
    }
}
