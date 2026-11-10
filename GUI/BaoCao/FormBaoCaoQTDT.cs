using QuanLyNhanSu.BUS;
using System;
using System.Data;
using System.Windows.Forms;

namespace QuanLyNhanSu.GUI
{
    public partial class FormBaoCaoQTDT : Form
    {
        public FormBaoCaoQTDT()
        {
            InitializeComponent();

            this.Load += FormBaoCaoQTDT_Load;
            buttonLoc.Click += buttonLoc_Click;
            buttonTaiLai.Click += buttonTaiLai_Click;
            buttonDong.Click += buttonDong_Click;
        }

        private void FormBaoCaoQTDT_Load(object sender, EventArgs e)
        {
            NapDuLieuComboBox();

            dataGridViewQTDT.AutoGenerateColumns = true;
            dataGridViewQTDT.ReadOnly = true;
            dataGridViewQTDT.AllowUserToAddRows = false;
            dataGridViewQTDT.AllowUserToDeleteRows = false;
            dataGridViewQTDT.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewQTDT.SelectionMode =
                DataGridViewSelectionMode.FullRowSelect;
            dataGridViewQTDT.MultiSelect = false;
            dataGridViewQTDT.RowHeadersVisible = false;

            dataGridViewQTDT.DataSource = null;
            dataGridViewQTDT.Columns.Clear();
        }

        private void NapDuLieuComboBox()
        {
            try
            {
                DataTable dtNhanVien = NhanVienBUS.GetAll();

                DataRow rowNV = dtNhanVien.NewRow();
                rowNV["MaNV"] = "ALL";
                rowNV["HoTen"] = "Tất cả nhân viên";
                dtNhanVien.Rows.InsertAt(rowNV, 0);

                comboBoxNhanVien.DataSource = dtNhanVien;
                comboBoxNhanVien.DisplayMember = "HoTen";
                comboBoxNhanVien.ValueMember = "MaNV";
                comboBoxNhanVien.SelectedIndex = 0;

                DataTable dtTruong =
                    DanhMucBUS.GetAll("TruongDT");

                DataRow rowTruong = dtTruong.NewRow();
                rowTruong["MaTruong"] = "ALL";
                rowTruong["TenTruong"] = "Tất cả trường đào tạo";
                dtTruong.Rows.InsertAt(rowTruong, 0);

                comboBoxTruongDT.DataSource = dtTruong;
                comboBoxTruongDT.DisplayMember = "TenTruong";
                comboBoxTruongDT.ValueMember = "MaTruong";
                comboBoxTruongDT.SelectedIndex = 0;

                DataTable dtNganh =
                    DanhMucBUS.GetAll("NganhDT");

                DataRow rowNganh = dtNganh.NewRow();
                rowNganh["MaNganh"] = "ALL";
                rowNganh["TenNganh"] = "Tất cả ngành đào tạo";
                dtNganh.Rows.InsertAt(rowNganh, 0);

                comboBoxNganhDT.DataSource = dtNganh;
                comboBoxNganhDT.DisplayMember = "TenNganh";
                comboBoxNganhDT.ValueMember = "MaNganh";
                comboBoxNganhDT.SelectedIndex = 0;
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

        private string LayMaChon(ComboBox cbo)
        {
            if (cbo.SelectedValue == null)
                return null;

            string ma = cbo.SelectedValue.ToString();

            if (ma == "ALL")
                return null;

            return ma;
        }

        private void LocBaoCao(bool hienThongBao = false)
        {
            string maNV = LayMaChon(comboBoxNhanVien);
            string maTruong = LayMaChon(comboBoxTruongDT);
            string maNganh = LayMaChon(comboBoxNganhDT);

            DataTable dt = BaoCaoBUS.BaoCaoQTDT(
                maNV, maTruong, maNganh
            );

            dataGridViewQTDT.DataSource = dt;

            if (hienThongBao && dt.Rows.Count == 0)
            {
                MessageBox.Show(
                    "Không tìm thấy quá trình đào tạo!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
            }
        }

        private void buttonLoc_Click(object sender, EventArgs e)
        {
            try
            {
                LocBaoCao(true);
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
            comboBoxTruongDT.SelectedIndex = 0;
            comboBoxNganhDT.SelectedIndex = 0;

            dataGridViewQTDT.DataSource = null;
            dataGridViewQTDT.Columns.Clear();
        }

        private void buttonDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
