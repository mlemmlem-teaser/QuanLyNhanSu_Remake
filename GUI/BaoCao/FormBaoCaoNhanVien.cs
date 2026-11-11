using QuanLyNhanSu.BUS;
using System;
using System.Data;
using System.Windows.Forms;

namespace QuanLyNhanSu.GUI
{
    public partial class FormBaoCaoNhanVien : Form
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

        private void FormBaoCaoNhanVien_Load(object sender, EventArgs e)
        {
            NapDuLieuComboBox();

            dataGridViewNhanVien.AutoGenerateColumns = true;
            dataGridViewNhanVien.ReadOnly = true;
            dataGridViewNhanVien.AllowUserToAddRows = false;
            dataGridViewNhanVien.SelectionMode =
                DataGridViewSelectionMode.FullRowSelect;
            dataGridViewNhanVien.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void NapDuLieuComboBox()
        {
            try
            {
                DataTable dtNgoaiNgu =
                    DanhMucBUS.GetAll("NgoaiNgu");

                comboBoxNgoaiNgu.DataSource = dtNgoaiNgu;
                comboBoxNgoaiNgu.DisplayMember = "TenNN";
                comboBoxNgoaiNgu.ValueMember = "MaNN";
                comboBoxNgoaiNgu.SelectedIndex = -1;

                DataTable dtChuyenMon =
                    DanhMucBUS.GetAll("ChuyenMon");

                comboBoxChuyenMon.DataSource = dtChuyenMon;
                comboBoxChuyenMon.DisplayMember = "TenCM";
                comboBoxChuyenMon.ValueMember = "MaCM";
                comboBoxChuyenMon.SelectedIndex = -1;
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
                if (comboBoxNgoaiNgu.SelectedIndex == -1)
                {
                    MessageBox.Show("Vui lòng chọn ngoại ngữ!");
                    comboBoxNgoaiNgu.Focus();
                    return;
                }

                if (comboBoxChuyenMon.SelectedIndex == -1)
                {
                    MessageBox.Show("Vui lòng chọn chuyên môn!");
                    comboBoxChuyenMon.Focus();
                    return;
                }

                string maNN =
                    comboBoxNgoaiNgu.SelectedValue.ToString();

                string maCM =
                    comboBoxChuyenMon.SelectedValue.ToString();

                DataTable dt =
                    BaoCaoBUS.BaoCaoNhanVienTheoNgoaiNguChuyenMon(
                        maNN, maCM
                    );

                dataGridViewNhanVien.DataSource = dt;

                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show(
                        "Không tìm thấy nhân viên phù hợp!",
                        "Thông báo"
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
            comboBoxNgoaiNgu.SelectedIndex = -1;
            comboBoxChuyenMon.SelectedIndex = -1;

            dataGridViewNhanVien.DataSource = null;
        }
        private void buttonXuatExcel_Click(object sender, EventArgs e)
        {
            ExcelHelper.XuatExcel(
                dataGridViewNhanVien,
                "BaoCaoNhanVien"
            );
        }

        private void buttonDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
