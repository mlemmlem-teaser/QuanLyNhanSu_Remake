using QuanLyNhanSu.BUS;
using System;
using System.Data;
using System.Windows.Forms;

namespace QuanLyNhanSu.GUI
{
    public partial class FormBaoCaoQTCT : Form
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

        private void FormBaoCaoQTCT_Load(object sender, EventArgs e)
        {
            NapDuLieuComboBox();

            dataGridViewQTCT.AutoGenerateColumns = true;
            dataGridViewQTCT.ReadOnly = true;
            dataGridViewQTCT.AllowUserToAddRows = false;
            dataGridViewQTCT.AllowUserToDeleteRows = false;
            dataGridViewQTCT.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewQTCT.SelectionMode =
                DataGridViewSelectionMode.FullRowSelect;
            dataGridViewQTCT.MultiSelect = false;
            dataGridViewQTCT.RowHeadersVisible = false;
        }

        private void NapDuLieuComboBox()
        {
            try
            {
                DataTable dtNhanVien = NhanVienBUS.GetAll();

                DataRow dongTatCaNV = dtNhanVien.NewRow();
                dongTatCaNV["MaNV"] = "ALL";
                dongTatCaNV["HoTen"] = "Tất cả nhân viên";

                dtNhanVien.Rows.InsertAt(dongTatCaNV, 0);

                comboBoxNhanVien.DataSource = dtNhanVien;
                comboBoxNhanVien.DisplayMember = "HoTen";
                comboBoxNhanVien.ValueMember = "MaNV";
                comboBoxNhanVien.SelectedIndex = 0;

                DataTable dtPhongBan =
                    DanhMucBUS.GetAll("PhongBan");

                DataRow dongTatCaPB = dtPhongBan.NewRow();
                dongTatCaPB["MaPhong"] = "ALL";
                dongTatCaPB["TenPhong"] = "Tất cả phòng ban";

                dtPhongBan.Rows.InsertAt(dongTatCaPB, 0);

                comboBoxPhongBan.DataSource = dtPhongBan;
                comboBoxPhongBan.DisplayMember = "TenPhong";
                comboBoxPhongBan.ValueMember = "MaPhong";
                comboBoxPhongBan.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Lỗi nạp dữ liệu: " + ex.Message,
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        private void buttonLoc_Click(object sender, EventArgs e)
        {
            try
            {
                string maNV = comboBoxNhanVien.SelectedValue?.ToString();
                string maPhong = comboBoxPhongBan.SelectedValue?.ToString();

                if (maNV == "ALL")
                    maNV = null;

                if (maPhong == "ALL")
                    maPhong = null;

                DataTable dt = BaoCaoBUS.BaoCaoQTCT(
                    maNV, maPhong
                );

                dataGridViewQTCT.DataSource = dt;

                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show(
                        "Không tìm thấy quá trình công tác!",
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
            comboBoxNhanVien.SelectedIndex = 0;
            comboBoxPhongBan.SelectedIndex = 0;

            dataGridViewQTCT.DataSource = null;
        }

        private void buttonXuatExcel_Click(object sender, EventArgs e)
        {
            ExcelHelper.XuatExcel(
                dataGridViewQTCT,
                "BaoCaoQuaTrinhCongTac"
            );
        }

        private void buttonDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
