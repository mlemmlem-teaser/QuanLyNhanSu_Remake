using QuanLyNhanSu.BUS;
using System;
using System.Data;
using System.Windows.Forms;

namespace QuanLyNhanSu.GUI
{
    public partial class FormBaoCaoQTDT_ChuaKetThuc : Form
    {
        public FormBaoCaoQTDT_ChuaKetThuc()
        {
            InitializeComponent();

            this.Load += FormBaoCaoQTDT_ChuaKetThuc_Load;
            buttonLoc.Click += buttonLoc_Click;
            buttonTaiLai.Click += buttonTaiLai_Click;
            buttonDong.Click += buttonDong_Click;
        }

        private void FormBaoCaoQTDT_ChuaKetThuc_Load(
            object sender, EventArgs e)
        {
            dataGridViewQTDTChuaKetThuc.AutoGenerateColumns = true;
            dataGridViewQTDTChuaKetThuc.ReadOnly = true;
            dataGridViewQTDTChuaKetThuc.AllowUserToAddRows = false;
            dataGridViewQTDTChuaKetThuc.AllowUserToDeleteRows = false;

            dataGridViewQTDTChuaKetThuc.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.Fill;

            dataGridViewQTDTChuaKetThuc.SelectionMode =
                DataGridViewSelectionMode.FullRowSelect;

            dataGridViewQTDTChuaKetThuc.MultiSelect = false;
            dataGridViewQTDTChuaKetThuc.RowHeadersVisible = false;

            dataGridViewQTDTChuaKetThuc.DataSource = null;
            dataGridViewQTDTChuaKetThuc.Columns.Clear();
        }

        private void buttonLoc_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable dt =
                    BaoCaoBUS.BaoCaoQTDTChuaKetThuc();

                dataGridViewQTDTChuaKetThuc.DataSource = dt;

                // Đổi tên hiển thị các cột
                if (dataGridViewQTDTChuaKetThuc.Columns.Count > 0)
                {
                    dataGridViewQTDTChuaKetThuc.Columns["MaQTDT"]
                        .HeaderText = "Mã QTĐT";

                    dataGridViewQTDTChuaKetThuc.Columns["MaNV"]
                        .HeaderText = "Mã nhân viên";

                    dataGridViewQTDTChuaKetThuc.Columns["HoTen"]
                        .HeaderText = "Họ tên";

                    dataGridViewQTDTChuaKetThuc.Columns["TuNgay"]
                        .HeaderText = "Từ ngày";

                    dataGridViewQTDTChuaKetThuc.Columns["DenNgay"]
                        .HeaderText = "Đến ngày";

                    dataGridViewQTDTChuaKetThuc.Columns["MaTruong"]
                        .HeaderText = "Mã trường";

                    dataGridViewQTDTChuaKetThuc.Columns["TenTruong"]
                        .HeaderText = "Trường đào tạo";

                    dataGridViewQTDTChuaKetThuc.Columns["MaHT"]
                        .HeaderText = "Mã hình thức";

                    dataGridViewQTDTChuaKetThuc.Columns["TenHT"]
                        .HeaderText = "Hình thức đào tạo";

                    dataGridViewQTDTChuaKetThuc.Columns["MaNganh"]
                        .HeaderText = "Mã ngành";

                    dataGridViewQTDTChuaKetThuc.Columns["TenNganh"]
                        .HeaderText = "Ngành đào tạo";

                    dataGridViewQTDTChuaKetThuc.Columns["MaXL"]
                        .HeaderText = "Mã xếp loại";

                    dataGridViewQTDTChuaKetThuc.Columns["TenXL"]
                        .HeaderText = "Xếp loại";
                }

                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show(
                        "Không có quá trình đào tạo nào chưa kết thúc!",
                        "Thông báo",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                    );
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Lỗi báo cáo: " + ex.Message,
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        private void buttonTaiLai_Click(object sender, EventArgs e)
        {
            dataGridViewQTDTChuaKetThuc.DataSource = null;
            dataGridViewQTDTChuaKetThuc.Columns.Clear();
        }

        private void buttonDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
