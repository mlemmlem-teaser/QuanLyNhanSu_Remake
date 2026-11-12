using QuanLyNhanSu.BUS;
using System;
using System.Data;
using System.Windows.Forms;

namespace QuanLyNhanSu.GUI
{
    public partial class FormBaoCaoQTDT_ChuaKetThuc : FormCoSo
    {
        public FormBaoCaoQTDT_ChuaKetThuc()
        {
            InitializeComponent();

            this.Load += FormBaoCaoQTDT_ChuaKetThuc_Load;
            buttonLoc.Click += buttonLoc_Click;
            buttonTaiLai.Click += buttonTaiLai_Click;
            buttonDong.Click += buttonDong_Click;
            buttonXuatExcel.Click += buttonXuatExcel_Click;
        }

        private void FormBaoCaoQTDT_ChuaKetThuc_Load(object? sender, EventArgs e)
        {
            CauHinhLuoiBaoCao(dataGridViewQTDTChuaKetThuc);

            // Tự động xem báo cáo ngay khi mở form (như bấm "Xem báo cáo").
            XemBaoCao(false);
        }

        // Nạp báo cáo vào lưới; hienThongBao = true thì báo khi không có dữ liệu.
        private void XemBaoCao(bool hienThongBao)
        {
            try
            {
                DataTable dt = BaoCaoBUS.BaoCaoQTDTChuaKetThuc();

                dataGridViewQTDTChuaKetThuc.DataSource = dt;
                DatTieuDeCot();

                if (hienThongBao && dt.Rows.Count == 0)
                    ThongTin("Không có quá trình đào tạo nào chưa kết thúc!");
            }
            catch (Exception ex)
            {
                HienLoi(ex, "Lỗi báo cáo:");
            }
        }

        // Đổi tên hiển thị các cột
        private void DatTieuDeCot()
        {
            DataGridView g = dataGridViewQTDTChuaKetThuc;
            DatCot(g, "MaQTDT", "Mã QTĐT");
            DatCot(g, "MaNV", "Mã nhân viên");
            DatCot(g, "HoTen", "Họ tên");
            DatCot(g, "TuNgay", "Từ ngày");
            DatCot(g, "DenNgay", "Đến ngày");
            DatCot(g, "MaTruong", "Mã trường");
            DatCot(g, "TenTruong", "Trường đào tạo");
            DatCot(g, "MaHT", "Mã hình thức");
            DatCot(g, "TenHT", "Hình thức đào tạo");
            DatCot(g, "MaNganh", "Mã ngành");
            DatCot(g, "TenNganh", "Ngành đào tạo");
            DatCot(g, "MaXL", "Mã xếp loại");
            DatCot(g, "TenXL", "Xếp loại");
        }

        private void buttonLoc_Click(object? sender, EventArgs e)
        {
            XemBaoCao(true);
        }

        // Nạp lại báo cáo từ cơ sở dữ liệu.
        private void buttonTaiLai_Click(object? sender, EventArgs e)
        {
            XemBaoCao(false);
        }

        private void buttonXuatExcel_Click(object? sender, EventArgs e)
        {
            ExcelHelper.XuatExcel(
                dataGridViewQTDTChuaKetThuc,
                "BaoCaoDaoTaoChuaKetThuc"
            );
        }

        private void buttonDong_Click(object? sender, EventArgs e)
        {
            this.Close();
        }
    }
}
