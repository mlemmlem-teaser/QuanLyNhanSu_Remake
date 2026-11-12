using QuanLyNhanSu.BUS;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace QuanLyNhanSu.GUI
{
    public partial class FormDanhMuc : FormCoSo
    {
        private DataTable bangHienTai;
        private readonly string[] loaiDanhMuc = {
            "GioiTinh", "ChucVu", "DanToc", "TonGiao", "NoiSinh", "NgoaiNgu",
            "PhongBan", "HocVan", "ChuyenMon", "TruongDT", "HinhThuc", "NganhDT", "XepLoai"
        };

        public FormDanhMuc()
        {
            InitializeComponent();
            comboBoxLoaiDanhMuc.SelectedIndexChanged += comboBoxLoaiDanhMuc_SelectedIndexChanged;
            textBoxTuKhoa.TextChanged += (s, e) => { if (bangHienTai != null) LocDanhMuc(); };
        }

        private void FormDanhMuc_Load(object sender, EventArgs e)
        {
            comboBoxLoaiDanhMuc.Items.Clear();
            comboBoxLoaiDanhMuc.Items.AddRange(loaiDanhMuc);
            comboBoxLoaiDanhMuc.SelectedItem = "PhongBan";
            dataGridViewDanhMuc.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewDanhMuc.MultiSelect = false;
            dataGridViewDanhMuc.ReadOnly = true;
            dataGridViewDanhMuc.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            NapDanhMuc();
        }

        private void comboBoxLoaiDanhMuc_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (IsHandleCreated && comboBoxLoaiDanhMuc.SelectedItem != null) NapDanhMuc();
        }

        private void NapDanhMuc()
        {
            if (comboBoxLoaiDanhMuc.SelectedItem == null) return;
            try
            {
                bangHienTai = DanhMucBUS.GetAll(comboBoxLoaiDanhMuc.SelectedItem.ToString());
                dataGridViewDanhMuc.DataSource = bangHienTai;
                LocDanhMuc();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không tải được danh mục.\n" + ex.Message, "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LocDanhMuc()
        {
            if (bangHienTai == null) return;
            string tuKhoa = textBoxTuKhoa.Text.Trim().Replace("'", "''");
            if (string.IsNullOrEmpty(tuKhoa)) bangHienTai.DefaultView.RowFilter = "";
            else
            {
                string filter = "";
                foreach (DataColumn col in bangHienTai.Columns)
                {
                    if (col.DataType == typeof(string))
                        filter += (filter.Length == 0 ? "" : " OR ") + "[" + col.ColumnName + "] LIKE '%" + tuKhoa + "%'";
                }
                bangHienTai.DefaultView.RowFilter = filter;
            }
        }

        private void buttonSearch_Click(object sender, EventArgs e) { LocDanhMuc(); }
        private void buttonRefresh_Click(object sender, EventArgs e) { textBoxTuKhoa.Clear(); NapDanhMuc(); }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (comboBoxLoaiDanhMuc.SelectedItem == null) return;
            string loai = comboBoxLoaiDanhMuc.SelectedItem.ToString();
            try
            {
                DataTable table = DanhMucBUS.GetAll(loai);
                Dictionary<string, object> values;
                if (!HienHopThoaiDanhMuc("Thêm " + loai, table, null, out values)) return;
                DanhMucBUS.Insert(loai, values);
                NapDanhMuc();
                MessageBox.Show("Đã thêm danh mục.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex) { HienLoi(ex); }
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (dataGridViewDanhMuc.CurrentRow == null || comboBoxLoaiDanhMuc.SelectedItem == null) return;
            string loai = comboBoxLoaiDanhMuc.SelectedItem.ToString();
            try
            {
                DataTable table = DanhMucBUS.GetAll(loai);
                DataRowView row = dataGridViewDanhMuc.CurrentRow.DataBoundItem as DataRowView;
                if (row == null) return;
                string khoa = Convert.ToString(row[table.Columns[0].ColumnName]);
                Dictionary<string, object> values;
                if (!HienHopThoaiDanhMuc("Sửa " + loai, table, row.Row, out values)) return;
                DanhMucBUS.Update(loai, khoa, values);
                NapDanhMuc();
                MessageBox.Show("Đã cập nhật danh mục.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex) { HienLoi(ex); }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (dataGridViewDanhMuc.CurrentRow == null || comboBoxLoaiDanhMuc.SelectedItem == null) return;
            DataRowView row = dataGridViewDanhMuc.CurrentRow.DataBoundItem as DataRowView;
            if (row == null) return;
            string loai = comboBoxLoaiDanhMuc.SelectedItem.ToString();
            string khoa = Convert.ToString(row[0]);
            if (MessageBox.Show("Xóa dòng có mã " + khoa + "?", "Xác nhận",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes) return;
            try
            {
                DanhMucBUS.Delete(loai, khoa);
                NapDanhMuc();
            }
            catch (Exception ex) { HienLoi(ex); }
        }

        private bool HienHopThoaiDanhMuc(string title, DataTable table, DataRow row, out Dictionary<string, object> values)
        {
            values = new Dictionary<string, object>();
            using (Form f = new Form())
            using (TableLayoutPanel layout = new TableLayoutPanel())
            using (Panel buttons = new Panel())
            {
                f.Text = title; f.StartPosition = FormStartPosition.CenterParent;
                f.FormBorderStyle = FormBorderStyle.FixedDialog; f.MinimizeBox = false; f.MaximizeBox = false;
                f.Width = 430; f.Height = Math.Min(650, 150 + table.Columns.Count * 42);
                layout.Dock = DockStyle.Fill; layout.AutoScroll = true; layout.ColumnCount = 2;
                layout.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 130));
                layout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100));
                layout.Padding = new Padding(10);
                Dictionary<string, TextBox> inputs = new Dictionary<string, TextBox>();
                for (int i = 0; i < table.Columns.Count; i++)
                {
                    string name = table.Columns[i].ColumnName;
                    layout.RowStyles.Add(new RowStyle(SizeType.Absolute, 36));
                    Label label = new Label(); label.Text = name; label.Dock = DockStyle.Fill;
                    label.TextAlign = ContentAlignment.MiddleLeft;
                    TextBox box = new TextBox(); box.Dock = DockStyle.Fill;
                    if (row != null) box.Text = row[name] == DBNull.Value ? "" : Convert.ToString(row[name]);
                    if (i == 0 && row != null) box.ReadOnly = true;
                    layout.Controls.Add(label, 0, i); layout.Controls.Add(box, 1, i);
                    inputs[name] = box;
                }
                Button save = new Button(); save.Text = "Lưu"; save.DialogResult = DialogResult.OK; save.Width = 90;
                Button cancel = new Button(); cancel.Text = "Hủy"; cancel.DialogResult = DialogResult.Cancel; cancel.Width = 90;
                buttons.Dock = DockStyle.Bottom; buttons.Height = 45;
                save.Left = 180; save.Top = 8; cancel.Left = 280; cancel.Top = 8;
                buttons.Controls.Add(save); buttons.Controls.Add(cancel);
                f.Controls.Add(layout); f.Controls.Add(buttons); f.AcceptButton = save; f.CancelButton = cancel;
                if (f.ShowDialog(this) != DialogResult.OK) return false;
                foreach (DataColumn col in table.Columns)
                    if (!(row != null && col.Ordinal == 0))
                        values[col.ColumnName] = inputs[col.ColumnName].Text.Trim();
                return true;
            }
        }

        private void buttonBack_Click(object sender, EventArgs e) { Close(); }
    }
}
