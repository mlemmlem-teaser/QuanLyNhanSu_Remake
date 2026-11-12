using QuanLyNhanSu.BUS;
using System;
using System.Data;
using System.Windows.Forms;

namespace QuanLyNhanSu.GUI
{
    public partial class FormBaoCaoNhanVien : FormCoSo
    {
        public FormBaoCaoNhanVien()
        {
            InitializeComponent();

            this.Load += FormBaoCaoNhanVien_Load;
            buttonLoc.Click += buttonLoc_Click;
            buttonTaiLai.Click += buttonTaiLai_Click;
            buttonDong.Click += buttonDong_Click;
            buttonXuatExcel.Click += buttonXuatExcel_Click;
        }

        // Báo cáo này bắt buộc chọn cả ngoại ngữ và chuyên môn nên KHÔNG tự chạy khi mở form.
        private void FormBaoCaoNhanVien_Load(object? sender, EventArgs e)
        {
            CauHinhLuoiBaoCao(dataGridViewNhanVien);
            NapDuLieuComboBox();
        }

        private void NapDuLieuComboBox()
        {
            try
            {
                NapComboDanhMuc(comboBoxNgoaiNgu, "NgoaiNgu", "MaNN", "TenNN", "-- Chọn ngoại ngữ --");
                NapComboDanhMuc(comboBoxChuyenMon, "ChuyenMon", "MaCM", "TenCM", "-- Chọn chuyên môn --");
            }
            catch (Exception ex)
            {
                HienLoi(ex, "Lỗi nạp dữ liệu:");
            }
        }

        private void buttonLoc_Click(object? sender, EventArgs e)
        {
            try
            {
                string? maNN = LayMa(comboBoxNgoaiNgu);
                if (maNN == null)
                {
                    Canh("Vui lòng chọn ngoại ngữ!");
                    comboBoxNgoaiNgu.Focus();
                    return;
                }

                string? maCM = LayMa(comboBoxChuyenMon);
                if (maCM == null)
                {
                    Canh("Vui lòng chọn chuyên môn!");
                    comboBoxChuyenMon.Focus();
                    return;
                }

                DataTable dt = BaoCaoBUS.BaoCaoNhanVienTheoNgoaiNguChuyenMon(maNN, maCM);

                dataGridViewNhanVien.DataSource = dt;

                if (dt.Rows.Count == 0)
                    ThongTin("Không tìm thấy nhân viên phù hợp!");
            }
            catch (Exception ex)
            {
                HienLoi(ex, "Lỗi báo cáo:");
            }
        }

        private void buttonTaiLai_Click(object? sender, EventArgs e)
        {
            DatDauTien(comboBoxNgoaiNgu);
            DatDauTien(comboBoxChuyenMon);

            dataGridViewNhanVien.DataSource = null;
        }

        private void buttonXuatExcel_Click(object? sender, EventArgs e)
        {
            ExcelHelper.XuatExcel(
                dataGridViewNhanVien,
                "BaoCaoNhanVien"
            );
        }

        private void buttonDong_Click(object? sender, EventArgs e)
        {
            this.Close();
        }
    }
}
