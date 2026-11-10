using QuanLyNhanSu.BUS;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace QuanLyNhanSu.GUI
{
    /// <summary>
    /// Chọn một nhân viên để xem toàn bộ quá trình đào tạo và công tác của người đó (2 tab).
    /// Chọn dòng rồi bấm "Xem chi tiết" (hoặc nhấp đúp) để mở chi tiết một quá trình.
    /// Dữ liệu qua QuaTrinhNhanVienBUS; form chỉ để xem, không sửa dữ liệu.
    /// </summary>
    public partial class FormQuaTrinhNV : Form
    {
        // true khi code đang nạp dữ liệu: bỏ qua sự kiện đổi nhân viên để tránh nạp lặp.
        private bool dangNap;
        private DataTable? bangNhanVien;

        public FormQuaTrinhNV()
        {
            InitializeComponent();
        }

        private void FormQuaTrinhNV_Load(object? sender, EventArgs e)
        {
            dangNap = true;
            try
            {
                bangNhanVien = NhanVienBUS.GetAll();
                NapCombo(comboBoxNhanVien, bangNhanVien, "MaNV",
                    r => Chuoi(r["MaNV"]) + " - " + Chuoi(r["HoTen"]), "-- Chọn nhân viên --");
            }
            catch (Exception ex)
            {
                HienLoi(ex);
            }
            finally
            {
                dangNap = false;
            }
            NapQuaTrinh();
        }

        // ===== Nạp dữ liệu =====

        private void NapQuaTrinh()
        {
            string? maNV = LayMa(comboBoxNhanVien);
            if (maNV == null)
            {
                dataGridViewQTDT.DataSource = null;
                dataGridViewQTCT.DataSource = null;
                tabPageQTDT.Text = "Quá trình đào tạo";
                tabPageQTCT.Text = "Quá trình công tác";
                labelTomTat.Text = "Hãy chọn một nhân viên để xem quá trình đào tạo và công tác.";
                return;
            }

            try
            {
                DataTable qtdt = QuaTrinhNhanVienBUS.GetQTDT(maNV);
                DataTable qtct = QuaTrinhNhanVienBUS.GetQTCT(maNV);

                dataGridViewQTDT.DataSource = qtdt;
                DinhDangQTDT();
                dataGridViewQTCT.DataSource = qtct;
                DinhDangQTCT();

                tabPageQTDT.Text = "Quá trình đào tạo (" + qtdt.Rows.Count + ")";
                tabPageQTCT.Text = "Quá trình công tác (" + qtct.Rows.Count + ")";
                labelTomTat.Text = MoTaNhanVien(maNV);
            }
            catch (Exception ex)
            {
                HienLoi(ex);
            }
        }

        // Dòng tóm tắt: họ tên, phòng ban, chức vụ hiện tại của nhân viên đang chọn.
        private string MoTaNhanVien(string maNV)
        {
            if (bangNhanVien == null) return maNV;
            DataRow[] ds = bangNhanVien.Select("MaNV = '" + maNV.Replace("'", "''") + "'");
            if (ds.Length == 0) return maNV;

            DataRow r = ds[0];
            return Chuoi(r["HoTen"]) + "   |   Phòng ban: " + HienHoacTrong(r["TenPhong"])
                + "   |   Chức vụ: " + HienHoacTrong(r["TenCV"]);
        }

        private static string HienHoacTrong(object? giaTri)
        {
            string s = Chuoi(giaTri);
            return s.Length == 0 ? "(chưa có)" : s;
        }

        private void DinhDangQTDT()
        {
            DataGridView g = dataGridViewQTDT;
            DatCot(g, "MaQTDT", "Mã QTĐT");
            DatCot(g, "TuNgay", "Từ ngày", true, "dd/MM/yyyy");
            DatCot(g, "DenNgay", "Đến ngày", true, "dd/MM/yyyy");
            DatCot(g, "TenTruong", "Trường đào tạo");
            DatCot(g, "TenHT", "Hình thức");
            DatCot(g, "TenNganh", "Ngành");
            DatCot(g, "TenXL", "Xếp loại");
            foreach (string cot in new[] { "MaNV", "HoTen", "MaTruong", "MaHT", "MaNganh", "MaXL" })
                DatCot(g, cot, cot, false);
        }

        private void DinhDangQTCT()
        {
            DataGridView g = dataGridViewQTCT;
            DatCot(g, "MaQTCT", "Mã QTCT");
            DatCot(g, "TuNgay", "Từ ngày", true, "dd/MM/yyyy");
            DatCot(g, "DenNgay", "Đến ngày", true, "dd/MM/yyyy");
            DatCot(g, "TenPhong", "Phòng ban");
            DatCot(g, "TenCV", "Chức vụ");
            foreach (string cot in new[] { "MaNV", "HoTen", "MaPhong", "MaCV" })
                DatCot(g, cot, cot, false);
        }

        // ===== Chi tiết một quá trình =====

        private void MoChiTiet(DataGridView luoi, string tieuDe, (string Nhan, string Cot, string KhiRong)[] truong)
        {
            DataRowView? dong = luoi.SelectedRows.Count == 0
                ? null
                : luoi.SelectedRows[0].DataBoundItem as DataRowView;
            if (dong == null)
            {
                Canh("Hãy chọn một quá trình trong danh sách để xem chi tiết.");
                return;
            }

            using (ChiTietQuaTrinhDialog hopThoai = new ChiTietQuaTrinhDialog(tieuDe, dong.Row, truong))
            {
                hopThoai.ShowDialog(this);
            }
        }

        private void MoChiTietQTDT()
        {
            MoChiTiet(dataGridViewQTDT, "Chi tiết quá trình đào tạo", new[]
            {
                ("Mã quá trình", "MaQTDT", "(chưa có)"),
                ("Nhân viên", "HoTen", "(chưa có)"),
                ("Mã nhân viên", "MaNV", "(chưa có)"),
                ("Từ ngày", "TuNgay", "(chưa có)"),
                ("Đến ngày", "DenNgay", "(chưa kết thúc)"),
                ("Trường đào tạo", "TenTruong", "(chưa có)"),
                ("Hình thức", "TenHT", "(chưa có)"),
                ("Ngành", "TenNganh", "(chưa có)"),
                ("Xếp loại", "TenXL", "(chưa xếp loại)")
            });
        }

        private void MoChiTietQTCT()
        {
            MoChiTiet(dataGridViewQTCT, "Chi tiết quá trình công tác", new[]
            {
                ("Mã quá trình", "MaQTCT", "(chưa có)"),
                ("Nhân viên", "HoTen", "(chưa có)"),
                ("Mã nhân viên", "MaNV", "(chưa có)"),
                ("Từ ngày", "TuNgay", "(chưa có)"),
                ("Đến ngày", "DenNgay", "(đang công tác)"),
                ("Phòng ban", "TenPhong", "(chưa có)"),
                ("Chức vụ", "TenCV", "(chưa có)")
            });
        }

        // ===== Sự kiện =====

        private void comboBoxNhanVien_SelectedIndexChanged(object? sender, EventArgs e)
        {
            if (dangNap) return;
            NapQuaTrinh();
        }

        private void buttonRefresh_Click(object? sender, EventArgs e)
        {
            NapQuaTrinh();
        }

        private void buttonChiTietQTDT_Click(object? sender, EventArgs e)
        {
            MoChiTietQTDT();
        }

        private void buttonChiTietQTCT_Click(object? sender, EventArgs e)
        {
            MoChiTietQTCT();
        }

        private void dataGridViewQTDT_CellDoubleClick(object? sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) MoChiTietQTDT();
        }

        private void dataGridViewQTCT_CellDoubleClick(object? sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) MoChiTietQTCT();
        }

        // ===== Hàm dùng chung trong form =====

        private static string Chuoi(object? giaTri)
        {
            if (giaTri == null || giaTri == DBNull.Value) return "";
            return Convert.ToString(giaTri) ?? "";
        }

        // Nạp ComboBox: dòng đầu là lựa chọn "trống" (mã rỗng), các dòng sau lấy từ bảng nguồn.
        private static void NapCombo(ComboBox combo, DataTable nguon, string cotMa,
            Func<DataRow, string> layTen, string chuTrong)
        {
            DataTable ds = new DataTable();
            ds.Columns.Add("Ma", typeof(string));
            ds.Columns.Add("Ten", typeof(string));
            ds.Rows.Add("", chuTrong);
            foreach (DataRow r in nguon.Rows)
                ds.Rows.Add(Chuoi(r[cotMa]), layTen(r));

            combo.DropDownStyle = ComboBoxStyle.DropDownList;
            combo.DisplayMember = "Ten";
            combo.ValueMember = "Ma";
            combo.DataSource = ds;
            if (ds.Rows.Count > 0) combo.SelectedIndex = 0;
        }

        // Mã đang chọn trong ComboBox; null nếu chọn dòng trống.
        private static string? LayMa(ComboBox combo)
        {
            string ma = Chuoi(combo.SelectedValue);
            return string.IsNullOrWhiteSpace(ma) ? null : ma;
        }

        // Chọn mục có mã tương ứng; không có (hoặc null) thì về dòng trống.
        private static void DatCombo(ComboBox combo, object? ma)
        {
            combo.SelectedValue = Chuoi(ma);
            if (combo.SelectedIndex < 0 && combo.Items.Count > 0) combo.SelectedIndex = 0;
        }

        // Chọn dòng đầu tiên nếu ComboBox có dữ liệu (tránh lỗi khi chưa nạp được từ CSDL).
        private static void DatDauTien(ComboBox combo)
        {
            if (combo.Items.Count > 0) combo.SelectedIndex = 0;
        }

        // Ngày rỗng: ô có checkbox -> bỏ tick; ô thường -> về hôm nay.
        private static void DatNgay(DateTimePicker picker, object? giaTri)
        {
            if (giaTri == null || giaTri == DBNull.Value)
            {
                if (picker.ShowCheckBox) picker.Checked = false;
                else picker.Value = DateTime.Today;
                return;
            }
            picker.Value = Convert.ToDateTime(giaTri);
            if (picker.ShowCheckBox) picker.Checked = true;
        }

        private static void DatCot(DataGridView luoi, string ten, string tieuDe, bool hien = true, string? dinhDang = null)
        {
            if (!luoi.Columns.Contains(ten)) return;
            DataGridViewColumn cot = luoi.Columns[ten]!;
            cot.HeaderText = tieuDe;
            cot.Visible = hien;
            if (dinhDang != null) cot.DefaultCellStyle.Format = dinhDang;
        }

        private static void Canh(string noiDung)
        {
            MessageBox.Show(noiDung, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private static void HienLoi(Exception ex)
        {
            if (ex is NghiepVuException)
            {
                Canh(ex.Message);
                return;
            }

            MessageBox.Show("Thao tác không thành công.\n" + ex.Message, "Lỗi",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    /// <summary>
    /// Hộp thoại chỉ đọc: hiện từng trường của một quá trình (nhãn bên trái, giá trị bên phải).
    /// </summary>
    internal class ChiTietQuaTrinhDialog : Form
    {
        public ChiTietQuaTrinhDialog(string tieuDe, DataRow dong, (string Nhan, string Cot, string KhiRong)[] truong)
        {
            Text = tieuDe;
            StartPosition = FormStartPosition.CenterParent;
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            ShowInTaskbar = false;
            Font = new Font("Segoe UI", 9.5F);
            BackColor = Color.White;

            Font chuDam = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            int y = 20;
            foreach ((string Nhan, string Cot, string KhiRong) t in truong)
            {
                Label nhan = new Label();
                nhan.Text = t.Nhan + ":";
                nhan.Font = chuDam;
                nhan.Location = new Point(20, y);
                nhan.Size = new Size(130, 24);
                nhan.TextAlign = ContentAlignment.MiddleLeft;

                Label giaTri = new Label();
                giaTri.Text = DinhDang(dong[t.Cot], t.KhiRong);
                giaTri.Location = new Point(155, y);
                giaTri.Size = new Size(310, 24);
                giaTri.TextAlign = ContentAlignment.MiddleLeft;
                giaTri.AutoEllipsis = true;

                Controls.Add(nhan);
                Controls.Add(giaTri);
                y += 32;
            }

            Button dong1 = new Button();
            dong1.Text = "Đóng";
            dong1.DialogResult = DialogResult.Cancel;
            dong1.Size = new Size(90, 32);
            dong1.Location = new Point(485 - 20 - 90, y + 8);
            Controls.Add(dong1);
            CancelButton = dong1;

            ClientSize = new Size(485, y + 8 + 32 + 20);
        }

        private static string DinhDang(object? giaTri, string khiRong)
        {
            if (giaTri == null || giaTri == DBNull.Value) return khiRong;
            if (giaTri is DateTime ngay) return ngay.ToString("dd/MM/yyyy");
            string s = Convert.ToString(giaTri) ?? "";
            return s.Length == 0 ? khiRong : s;
        }
    }
}
