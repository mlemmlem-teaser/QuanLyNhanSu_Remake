using QuanLyNhanSu.BUS;
using QuanLyNhanSu.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace QuanLyNhanSu.GUI
{
    public partial class FormNhanVien : FormCoSo
    {
        public FormNhanVien() { InitializeComponent(); comboBoxPhongBan.SelectedIndexChanged += comboBoxPhongBan_SelectedIndexChanged; }

        private void FormNhanVien_Load(object sender, EventArgs e)
        {
            dataGridViewNhanVien.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewNhanVien.MultiSelect = false;
            dataGridViewNhanVien.ReadOnly = true;
            dataGridViewNhanVien.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            comboBoxPhongBan.DropDownStyle = ComboBoxStyle.DropDownList;
            NapPhongBan();
            NapNhanVien();
        }

        private void NapPhongBan()
        {
            try
            {
                DataTable t = DanhMucBUS.GetAll("PhongBan");
                DataRow r = t.NewRow(); r["MaPhong"] = ""; r["TenPhong"] = "Tất cả phòng ban"; t.Rows.InsertAt(r, 0);
                comboBoxPhongBan.DataSource = t;
                comboBoxPhongBan.DisplayMember = "TenPhong";
                comboBoxPhongBan.ValueMember = "MaPhong";
            }
            catch (Exception ex) { MessageBox.Show("Không tải được phòng ban.\n" + ex.Message); }
        }

        private void NapNhanVien()
        {
            try
            {
                string maPhong = comboBoxPhongBan.SelectedValue == null ? null : Convert.ToString(comboBoxPhongBan.SelectedValue);
                if (string.IsNullOrWhiteSpace(maPhong)) maPhong = null;
                DataTable t = NhanVienBUS.TimKiem(textBoxTuKhoa.Text.Trim(), maPhong);
                dataGridViewNhanVien.DataSource = t;
            }
            catch (Exception ex) { MessageBox.Show("Không tải được danh sách nhân viên.\n" + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void buttonSearch_Click(object sender, EventArgs e) { NapNhanVien(); }
        private void buttonRefresh_Click(object sender, EventArgs e) { textBoxTuKhoa.Clear(); if (comboBoxPhongBan.Items.Count > 0) comboBoxPhongBan.SelectedIndex = 0; NapNhanVien(); }
        private void comboBoxPhongBan_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (IsHandleCreated && comboBoxPhongBan.SelectedValue != null && comboBoxPhongBan.SelectedValue is string) NapNhanVien();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            using (NhanVienEditor editor = new NhanVienEditor())
            {
                if (editor.ShowDialog(this) != DialogResult.OK) return;
                try { NhanVienBUS.Insert(editor.DuLieu); NapNhanVien(); MessageBox.Show("Đã thêm nhân viên."); }
                catch (Exception ex) { HienLoi(ex); }
            }
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            DataRowView row = dataGridViewNhanVien.CurrentRow == null ? null : dataGridViewNhanVien.CurrentRow.DataBoundItem as DataRowView;
            if (row == null) { MessageBox.Show("Hãy chọn nhân viên cần sửa."); return; }
            string maNV = Convert.ToString(row["MaNV"]);
            try
            {
                DataTable dt = NhanVienBUS.GetByMaNV(maNV);
                if (dt.Rows.Count == 0) return;
                using (NhanVienEditor editor = new NhanVienEditor(dt.Rows[0]))
                {
                    if (editor.ShowDialog(this) != DialogResult.OK) return;
                    NhanVienBUS.Update(editor.DuLieu);
                    NapNhanVien();
                    MessageBox.Show("Đã cập nhật nhân viên.");
                }
            }
            catch (Exception ex) { HienLoi(ex); }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            DataRowView row = dataGridViewNhanVien.CurrentRow == null ? null : dataGridViewNhanVien.CurrentRow.DataBoundItem as DataRowView;
            if (row == null) { MessageBox.Show("Hãy chọn nhân viên cần xóa."); return; }
            string maNV = Convert.ToString(row["MaNV"]);
            if (MessageBox.Show("Bạn có chắc muốn xóa nhân viên " + maNV + "?", "Xác nhận",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes) return;
            try { NhanVienBUS.Delete(maNV); NapNhanVien(); MessageBox.Show("Đã xóa nhân viên."); }
            catch (Exception ex) { HienLoi(ex); }
        }

        private void buttonBack_Click(object sender, EventArgs e) { Close(); }
    }

    internal class NhanVienEditor : Form
    {
        private readonly Dictionary<string, Control> controls = new Dictionary<string, Control>();
        private readonly Dictionary<string, string> comboKeys = new Dictionary<string, string>();
        private readonly DateTimePicker datePicker;
        private readonly bool isEdit;
        public NhanVienDTO DuLieu { get; private set; }

        public NhanVienEditor(DataRow row = null)
        {
            isEdit = row != null;
            Text = isEdit ? "Sửa hồ sơ nhân viên" : "Thêm hồ sơ nhân viên";
            StartPosition = FormStartPosition.CenterParent;
            FormBorderStyle = FormBorderStyle.FixedDialog; MaximizeBox = false; MinimizeBox = false;
            Width = 760; Height = 680;

            TableLayoutPanel layout = new TableLayoutPanel();
            layout.Dock = DockStyle.Fill; layout.AutoScroll = true; layout.ColumnCount = 4;
            layout.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 105));
            layout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50));
            layout.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 105));
            layout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50));
            layout.Padding = new Padding(10);
            Controls.Add(layout);

            AddText(layout, row, "MaNV", "Mã nhân viên", 0, 0);
            AddText(layout, row, "HoTen", "Họ tên", 0, 1);
            AddCombo(layout, row, "MaGT", "Giới tính", "GioiTinh", "MaGT", "TenGT", 1, 0);
            AddCombo(layout, row, "MaCV", "Chức vụ", "ChucVu", "MaCV", "TenCV", 1, 1);
            AddCombo(layout, row, "MaDT", "Dân tộc", "DanToc", "MaDT", "TenDT", 2, 0);
            AddCombo(layout, row, "MaTG", "Tôn giáo", "TonGiao", "MaTG", "TenTG", 2, 1);

            Label lbDate = new Label(); lbDate.Text = "Ngày sinh"; lbDate.TextAlign = ContentAlignment.MiddleLeft; lbDate.Dock = DockStyle.Fill;
            datePicker = new DateTimePicker(); datePicker.Dock = DockStyle.Fill; datePicker.Format = DateTimePickerFormat.Custom; datePicker.CustomFormat = "dd/MM/yyyy"; datePicker.ShowCheckBox = true;
            if (row != null && row["NgaySinh"] != DBNull.Value) { datePicker.Value = Convert.ToDateTime(row["NgaySinh"]); datePicker.Checked = true; } else datePicker.Checked = false;
            layout.Controls.Add(lbDate, 0, 3); layout.Controls.Add(datePicker, 1, 3);
            AddText(layout, row, "QueQuan", "Quê quán", 2, 3);
            AddCombo(layout, row, "MaNS", "Nơi sinh", "NoiSinh", "MaNS", "TenNS", 4, 0);
            AddText(layout, row, "DiaChi", "Địa chỉ", 2, 4);
            AddText(layout, row, "DienThoai", "Điện thoại", 0, 5);
            AddText(layout, row, "SoCMND", "Số CMND", 2, 5);
            AddCombo(layout, row, "MaPhong", "Phòng ban", "PhongBan", "MaPhong", "TenPhong", 0, 6);
            AddCombo(layout, row, "MaHV", "Học vấn", "HocVan", "MaHV", "TenHV", 2, 6);
            AddCombo(layout, row, "MaCM", "Chuyên môn", "ChuyenMon", "MaCM", "TenCM", 0, 7);
            AddText(layout, row, "VoChong", "Vợ/chồng", 2, 7);
            AddText(layout, row, "Con", "Con", 0, 8);
            AddLanguageChecks(layout, row, 9);

            FlowLayoutPanel actions = new FlowLayoutPanel(); actions.Dock = DockStyle.Bottom; actions.Height = 45; actions.FlowDirection = FlowDirection.RightToLeft;
            Button save = new Button(); save.Text = "Lưu"; save.Width = 90; save.DialogResult = DialogResult.None; save.Click += Save_Click;
            Button cancel = new Button(); cancel.Text = "Hủy"; cancel.Width = 90; cancel.DialogResult = DialogResult.Cancel;
            actions.Controls.Add(save); actions.Controls.Add(cancel); Controls.Add(actions);
            AcceptButton = save; CancelButton = cancel;
            if (isEdit) { Control c; if (controls.TryGetValue("MaNV", out c)) c.Enabled = false; }
        }

        private void AddText(TableLayoutPanel layout, DataRow row, string key, string caption, int col, int r)
        {
            Label label = new Label(); label.Text = caption; label.Dock = DockStyle.Fill; label.TextAlign = ContentAlignment.MiddleLeft;
            TextBox box = new TextBox(); box.Dock = DockStyle.Fill;
            if (row != null && row.Table.Columns.Contains(key) && row[key] != DBNull.Value) box.Text = Convert.ToString(row[key]);
            layout.RowStyles.Add(new RowStyle(SizeType.Absolute, 34));
            layout.Controls.Add(label, col, r); layout.Controls.Add(box, col + 1, r); controls[key] = box;
        }

        private void AddCombo(TableLayoutPanel layout, DataRow row, string key, string caption, string table, string value, string display, int col, int r)
        {
            Label label = new Label(); label.Text = caption; label.Dock = DockStyle.Fill; label.TextAlign = ContentAlignment.MiddleLeft;
            ComboBox combo = new ComboBox(); combo.Dock = DockStyle.Fill; combo.DropDownStyle = ComboBoxStyle.DropDownList;
            DataTable dt = DanhMucBUS.GetAll(table);
            DataRow blank = dt.NewRow(); blank[value] = ""; blank[display] = "-- Chọn --"; dt.Rows.InsertAt(blank, 0);
            combo.DataSource = dt; combo.ValueMember = value; combo.DisplayMember = display;
            string selected = row != null && row.Table.Columns.Contains(key) && row[key] != DBNull.Value ? Convert.ToString(row[key]) : "";
            combo.SelectedValue = selected;
            layout.Controls.Add(label, col, r); layout.Controls.Add(combo, col + 1, r);
            controls[key] = combo; comboKeys[key] = value;
        }

        private void AddLanguageChecks(TableLayoutPanel layout, DataRow row, int r)
        {
            Label label = new Label(); label.Text = "Ngoại ngữ"; label.Dock = DockStyle.Fill; label.TextAlign = ContentAlignment.MiddleLeft;
            FlowLayoutPanel flow = new FlowLayoutPanel(); flow.Dock = DockStyle.Fill; flow.AutoSize = true;
            DataTable langs = DanhMucBUS.GetAll("NgoaiNgu");
            DataTable selected = isEdit ? NhanVienBUS.GetNgoaiNgu(Convert.ToString(row["MaNV"])) : null;
            foreach (DataRow lang in langs.Rows)
            {
                string code = Convert.ToString(lang["MaNN"]);
                CheckBox cb = new CheckBox(); cb.Text = Convert.ToString(lang["TenNN"]); cb.Tag = code; cb.AutoSize = true;
                if (selected != null)
                    foreach (DataRow s in selected.Rows) if (Convert.ToString(s["MaNN"]) == code) cb.Checked = true;
                flow.Controls.Add(cb);
            }
            layout.Controls.Add(label, 0, r); layout.Controls.Add(flow, 1, r); layout.SetColumnSpan(flow, 3);
            controls["MaNgoaiNguPanel"] = flow;
        }

        private void Save_Click(object sender, EventArgs e)
        {
            TextBox ma = controls["MaNV"] as TextBox;
            TextBox ten = controls["HoTen"] as TextBox;
            NhanVienDTO nv = new NhanVienDTO();
            nv.MaNV = ma.Text.Trim(); nv.HoTen = ten.Text.Trim();
            nv.NgaySinh = datePicker.Checked ? (DateTime?)datePicker.Value.Date : null;
            string[] textKeys = { "QueQuan", "DiaChi", "DienThoai", "SoCMND", "VoChong", "Con" };
            foreach (string key in textKeys) nv.GetType().GetProperty(key).SetValue(nv, ((TextBox)controls[key]).Text.Trim());
            string[] comboNames = { "MaGT", "MaCV", "MaDT", "MaTG", "MaNS", "MaPhong", "MaHV", "MaCM" };
            foreach (string key in comboNames)
            {
                ComboBox cb = (ComboBox)controls[key];
                string value = cb.SelectedValue == null ? "" : Convert.ToString(cb.SelectedValue);
                nv.GetType().GetProperty(key).SetValue(nv, string.IsNullOrWhiteSpace(value) ? null : value);
            }
            FlowLayoutPanel panel = (FlowLayoutPanel)controls["MaNgoaiNguPanel"];
            foreach (Control c in panel.Controls)
                if (c is CheckBox && ((CheckBox)c).Checked) nv.MaNgoaiNgu.Add(Convert.ToString(c.Tag));
            // Kiểm tra nghiệp vụ do tầng BUS thực hiện; lỗi thì giữ hộp thoại mở để người dùng sửa.
            try { NhanVienBUS.KiemTraHopLe(nv, !isEdit); }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK,
                    ex is NghiepVuException ? MessageBoxIcon.Warning : MessageBoxIcon.Error);
                return;
            }
            DuLieu = nv; DialogResult = DialogResult.OK; Close();
        }
    }
}
