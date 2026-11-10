namespace QuanLyNhanSu.GUI
{
    partial class FormTimKiemQTDT
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            panelTimKiem = new Panel();
            tableLayoutPanelTimKiem = new TableLayoutPanel();
            labelNhanVien = new Label();
            labelTruongDaoTao = new Label();
            labelHinhThuc = new Label();
            comboBoxNhanVien = new ComboBox();
            comboBoxTruongDaoTao = new ComboBox();
            comboBoxHinhThuc = new ComboBox();
            labelTuNgay = new Label();
            labelDenNgay = new Label();
            dateTimePickerTuNgay = new DateTimePicker();
            dateTimePickerDenNgay = new DateTimePicker();
            labelGhiChuNgay = new Label();
            flowLayoutPanelNut = new FlowLayoutPanel();
            buttonLamMoi = new Button();
            buttonTimKiem = new Button();
            labelKetQua = new Label();
            labelTongSo = new Label();
            dataGridViewKetQua = new DataGridView();
            panelTimKiem.SuspendLayout();
            tableLayoutPanelTimKiem.SuspendLayout();
            flowLayoutPanelNut.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewKetQua).BeginInit();
            SuspendLayout();
            // 
            // panelTimKiem
            // 
            panelTimKiem.BackColor = Color.White;
            panelTimKiem.Controls.Add(tableLayoutPanelTimKiem);
            panelTimKiem.Dock = DockStyle.Top;
            panelTimKiem.Location = new Point(30, 20);
            panelTimKiem.Name = "panelTimKiem";
            panelTimKiem.Padding = new Padding(20, 16, 20, 16);
            panelTimKiem.Size = new Size(960, 208);
            panelTimKiem.TabIndex = 0;
            // 
            // tableLayoutPanelTimKiem
            // 
            tableLayoutPanelTimKiem.ColumnCount = 3;
            tableLayoutPanelTimKiem.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33F));
            tableLayoutPanelTimKiem.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33F));
            tableLayoutPanelTimKiem.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.34F));
            tableLayoutPanelTimKiem.Controls.Add(labelNhanVien, 0, 0);
            tableLayoutPanelTimKiem.Controls.Add(labelTruongDaoTao, 1, 0);
            tableLayoutPanelTimKiem.Controls.Add(labelHinhThuc, 2, 0);
            tableLayoutPanelTimKiem.Controls.Add(comboBoxNhanVien, 0, 1);
            tableLayoutPanelTimKiem.Controls.Add(comboBoxTruongDaoTao, 1, 1);
            tableLayoutPanelTimKiem.Controls.Add(comboBoxHinhThuc, 2, 1);
            tableLayoutPanelTimKiem.Controls.Add(labelTuNgay, 0, 2);
            tableLayoutPanelTimKiem.Controls.Add(labelDenNgay, 1, 2);
            tableLayoutPanelTimKiem.Controls.Add(dateTimePickerTuNgay, 0, 3);
            tableLayoutPanelTimKiem.Controls.Add(dateTimePickerDenNgay, 1, 3);
            tableLayoutPanelTimKiem.Controls.Add(labelGhiChuNgay, 2, 3);
            tableLayoutPanelTimKiem.Controls.Add(flowLayoutPanelNut, 0, 4);
            tableLayoutPanelTimKiem.Dock = DockStyle.Fill;
            tableLayoutPanelTimKiem.Location = new Point(20, 16);
            tableLayoutPanelTimKiem.Name = "tableLayoutPanelTimKiem";
            tableLayoutPanelTimKiem.RowCount = 5;
            tableLayoutPanelTimKiem.RowStyles.Add(new RowStyle(SizeType.Absolute, 24F));
            tableLayoutPanelTimKiem.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanelTimKiem.RowStyles.Add(new RowStyle(SizeType.Absolute, 24F));
            tableLayoutPanelTimKiem.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanelTimKiem.RowStyles.Add(new RowStyle(SizeType.Absolute, 48F));
            tableLayoutPanelTimKiem.Size = new Size(920, 176);
            tableLayoutPanelTimKiem.TabIndex = 0;
            // 
            // labelNhanVien
            // 
            labelNhanVien.Dock = DockStyle.Fill;
            labelNhanVien.Font = new Font("Segoe UI", 9.5F);
            labelNhanVien.ForeColor = Color.FromArgb(51, 65, 85);
            labelNhanVien.Location = new Point(3, 0);
            labelNhanVien.Name = "labelNhanVien";
            labelNhanVien.Size = new Size(300, 24);
            labelNhanVien.TabIndex = 0;
            labelNhanVien.Text = "Mã nhân viên";
            labelNhanVien.TextAlign = ContentAlignment.BottomLeft;
            // 
            // labelTruongDaoTao
            // 
            labelTruongDaoTao.Dock = DockStyle.Fill;
            labelTruongDaoTao.Font = new Font("Segoe UI", 9.5F);
            labelTruongDaoTao.ForeColor = Color.FromArgb(51, 65, 85);
            labelTruongDaoTao.Location = new Point(309, 0);
            labelTruongDaoTao.Name = "labelTruongDaoTao";
            labelTruongDaoTao.Size = new Size(300, 24);
            labelTruongDaoTao.TabIndex = 1;
            labelTruongDaoTao.Text = "Trường đào tạo";
            labelTruongDaoTao.TextAlign = ContentAlignment.BottomLeft;
            // 
            // labelHinhThuc
            // 
            labelHinhThuc.Dock = DockStyle.Fill;
            labelHinhThuc.Font = new Font("Segoe UI", 9.5F);
            labelHinhThuc.ForeColor = Color.FromArgb(51, 65, 85);
            labelHinhThuc.Location = new Point(615, 0);
            labelHinhThuc.Name = "labelHinhThuc";
            labelHinhThuc.Size = new Size(302, 24);
            labelHinhThuc.TabIndex = 2;
            labelHinhThuc.Text = "Hình thức";
            labelHinhThuc.TextAlign = ContentAlignment.BottomLeft;
            // 
            // comboBoxNhanVien
            // 
            comboBoxNhanVien.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            comboBoxNhanVien.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxNhanVien.Font = new Font("Segoe UI", 10.5F);
            comboBoxNhanVien.FormattingEnabled = true;
            comboBoxNhanVien.Location = new Point(0, 27);
            comboBoxNhanVien.Margin = new Padding(0, 3, 16, 3);
            comboBoxNhanVien.Name = "comboBoxNhanVien";
            comboBoxNhanVien.Size = new Size(290, 31);
            comboBoxNhanVien.TabIndex = 0;
            // 
            // comboBoxTruongDaoTao
            // 
            comboBoxTruongDaoTao.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            comboBoxTruongDaoTao.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxTruongDaoTao.Font = new Font("Segoe UI", 10.5F);
            comboBoxTruongDaoTao.FormattingEnabled = true;
            comboBoxTruongDaoTao.Location = new Point(306, 27);
            comboBoxTruongDaoTao.Margin = new Padding(0, 3, 16, 3);
            comboBoxTruongDaoTao.Name = "comboBoxTruongDaoTao";
            comboBoxTruongDaoTao.Size = new Size(290, 31);
            comboBoxTruongDaoTao.TabIndex = 1;
            // 
            // comboBoxHinhThuc
            // 
            comboBoxHinhThuc.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            comboBoxHinhThuc.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxHinhThuc.Font = new Font("Segoe UI", 10.5F);
            comboBoxHinhThuc.FormattingEnabled = true;
            comboBoxHinhThuc.Location = new Point(612, 27);
            comboBoxHinhThuc.Margin = new Padding(0, 3, 0, 3);
            comboBoxHinhThuc.Name = "comboBoxHinhThuc";
            comboBoxHinhThuc.Size = new Size(308, 31);
            comboBoxHinhThuc.TabIndex = 2;
            // 
            // labelTuNgay
            // 
            labelTuNgay.Dock = DockStyle.Fill;
            labelTuNgay.Font = new Font("Segoe UI", 9.5F);
            labelTuNgay.ForeColor = Color.FromArgb(51, 65, 85);
            labelTuNgay.Location = new Point(3, 64);
            labelTuNgay.Name = "labelTuNgay";
            labelTuNgay.Size = new Size(300, 24);
            labelTuNgay.TabIndex = 3;
            labelTuNgay.Text = "Từ ngày";
            labelTuNgay.TextAlign = ContentAlignment.BottomLeft;
            // 
            // labelDenNgay
            // 
            labelDenNgay.Dock = DockStyle.Fill;
            labelDenNgay.Font = new Font("Segoe UI", 9.5F);
            labelDenNgay.ForeColor = Color.FromArgb(51, 65, 85);
            labelDenNgay.Location = new Point(309, 64);
            labelDenNgay.Name = "labelDenNgay";
            labelDenNgay.Size = new Size(300, 24);
            labelDenNgay.TabIndex = 4;
            labelDenNgay.Text = "Đến ngày";
            labelDenNgay.TextAlign = ContentAlignment.BottomLeft;
            // 
            // dateTimePickerTuNgay
            // 
            dateTimePickerTuNgay.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            dateTimePickerTuNgay.Checked = false;
            dateTimePickerTuNgay.CustomFormat = "dd/MM/yyyy";
            dateTimePickerTuNgay.Font = new Font("Segoe UI", 10.5F);
            dateTimePickerTuNgay.Format = DateTimePickerFormat.Custom;
            dateTimePickerTuNgay.Location = new Point(0, 92);
            dateTimePickerTuNgay.Margin = new Padding(0, 3, 16, 3);
            dateTimePickerTuNgay.Name = "dateTimePickerTuNgay";
            dateTimePickerTuNgay.ShowCheckBox = true;
            dateTimePickerTuNgay.Size = new Size(290, 31);
            dateTimePickerTuNgay.TabIndex = 3;
            // 
            // dateTimePickerDenNgay
            // 
            dateTimePickerDenNgay.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            dateTimePickerDenNgay.Checked = false;
            dateTimePickerDenNgay.CustomFormat = "dd/MM/yyyy";
            dateTimePickerDenNgay.Font = new Font("Segoe UI", 10.5F);
            dateTimePickerDenNgay.Format = DateTimePickerFormat.Custom;
            dateTimePickerDenNgay.Location = new Point(306, 92);
            dateTimePickerDenNgay.Margin = new Padding(0, 3, 16, 3);
            dateTimePickerDenNgay.Name = "dateTimePickerDenNgay";
            dateTimePickerDenNgay.ShowCheckBox = true;
            dateTimePickerDenNgay.Size = new Size(290, 31);
            dateTimePickerDenNgay.TabIndex = 4;
            // 
            // labelGhiChuNgay
            // 
            labelGhiChuNgay.Dock = DockStyle.Fill;
            labelGhiChuNgay.Font = new Font("Segoe UI", 9F, FontStyle.Italic);
            labelGhiChuNgay.ForeColor = Color.FromArgb(100, 116, 139);
            labelGhiChuNgay.Location = new Point(615, 88);
            labelGhiChuNgay.Name = "labelGhiChuNgay";
            labelGhiChuNgay.Size = new Size(302, 40);
            labelGhiChuNgay.TabIndex = 5;
            labelGhiChuNgay.Text = "Tích vào ô vuông cạnh ngày để bật lọc theo ngày.";
            labelGhiChuNgay.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // flowLayoutPanelNut
            // 
            tableLayoutPanelTimKiem.SetColumnSpan(flowLayoutPanelNut, 3);
            flowLayoutPanelNut.Controls.Add(buttonLamMoi);
            flowLayoutPanelNut.Controls.Add(buttonTimKiem);
            flowLayoutPanelNut.Dock = DockStyle.Fill;
            flowLayoutPanelNut.FlowDirection = FlowDirection.RightToLeft;
            flowLayoutPanelNut.Location = new Point(0, 128);
            flowLayoutPanelNut.Margin = new Padding(0);
            flowLayoutPanelNut.Name = "flowLayoutPanelNut";
            flowLayoutPanelNut.Size = new Size(920, 48);
            flowLayoutPanelNut.TabIndex = 5;
            // 
            // buttonLamMoi
            // 
            buttonLamMoi.BackColor = Color.White;
            buttonLamMoi.Cursor = Cursors.Hand;
            buttonLamMoi.FlatAppearance.BorderColor = Color.FromArgb(203, 213, 225);
            buttonLamMoi.FlatAppearance.MouseOverBackColor = Color.FromArgb(241, 245, 249);
            buttonLamMoi.FlatStyle = FlatStyle.Flat;
            buttonLamMoi.Font = new Font("Segoe UI", 10F);
            buttonLamMoi.ForeColor = Color.FromArgb(30, 41, 59);
            buttonLamMoi.Location = new Point(800, 6);
            buttonLamMoi.Margin = new Padding(12, 6, 0, 0);
            buttonLamMoi.Name = "buttonLamMoi";
            buttonLamMoi.Size = new Size(120, 38);
            buttonLamMoi.TabIndex = 1;
            buttonLamMoi.Text = "Làm mới";
            buttonLamMoi.UseVisualStyleBackColor = false;
            buttonLamMoi.Click += buttonLamMoi_Click;
            // 
            // buttonTimKiem
            // 
            buttonTimKiem.BackColor = Color.FromArgb(37, 99, 235);
            buttonTimKiem.Cursor = Cursors.Hand;
            buttonTimKiem.FlatAppearance.BorderSize = 0;
            buttonTimKiem.FlatAppearance.MouseOverBackColor = Color.FromArgb(29, 78, 216);
            buttonTimKiem.FlatStyle = FlatStyle.Flat;
            buttonTimKiem.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            buttonTimKiem.ForeColor = Color.White;
            buttonTimKiem.Location = new Point(668, 6);
            buttonTimKiem.Margin = new Padding(12, 6, 0, 0);
            buttonTimKiem.Name = "buttonTimKiem";
            buttonTimKiem.Size = new Size(120, 38);
            buttonTimKiem.TabIndex = 0;
            buttonTimKiem.Text = "Tìm kiếm";
            buttonTimKiem.UseVisualStyleBackColor = false;
            buttonTimKiem.Click += buttonTimKiem_Click;
            // 
            // labelKetQua
            // 
            labelKetQua.Dock = DockStyle.Top;
            labelKetQua.Font = new Font("Segoe UI", 10.5F, FontStyle.Bold);
            labelKetQua.ForeColor = Color.FromArgb(15, 23, 42);
            labelKetQua.Location = new Point(30, 228);
            labelKetQua.Name = "labelKetQua";
            labelKetQua.Size = new Size(960, 40);
            labelKetQua.TabIndex = 1;
            labelKetQua.Text = "Kết quả tìm kiếm";
            labelKetQua.TextAlign = ContentAlignment.BottomLeft;
            // 
            // labelTongSo
            // 
            labelTongSo.Dock = DockStyle.Bottom;
            labelTongSo.Font = new Font("Segoe UI", 10F);
            labelTongSo.ForeColor = Color.FromArgb(71, 85, 105);
            labelTongSo.Location = new Point(30, 592);
            labelTongSo.Name = "labelTongSo";
            labelTongSo.Size = new Size(960, 32);
            labelTongSo.TabIndex = 3;
            labelTongSo.Text = "Tổng số: 0 kết quả";
            labelTongSo.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // dataGridViewKetQua
            // 
            dataGridViewKetQua.AllowUserToAddRows = false;
            dataGridViewKetQua.AllowUserToDeleteRows = false;
            dataGridViewKetQua.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(241, 245, 249);
            dataGridViewKetQua.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewKetQua.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewKetQua.BackgroundColor = Color.White;
            dataGridViewKetQua.BorderStyle = BorderStyle.None;
            dataGridViewKetQua.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewKetQua.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(37, 99, 235);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.Padding = new Padding(6, 0, 0, 0);
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(37, 99, 235);
            dataGridViewCellStyle2.SelectionForeColor = Color.White;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGridViewKetQua.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewKetQua.ColumnHeadersHeight = 38;
            dataGridViewKetQua.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 10F);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(15, 23, 42);
            dataGridViewCellStyle3.Padding = new Padding(6, 0, 0, 0);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(219, 234, 254);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(15, 23, 42);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dataGridViewKetQua.DefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewKetQua.Dock = DockStyle.Fill;
            dataGridViewKetQua.EnableHeadersVisualStyles = false;
            dataGridViewKetQua.GridColor = Color.FromArgb(226, 232, 240);
            dataGridViewKetQua.Location = new Point(30, 268);
            dataGridViewKetQua.MultiSelect = false;
            dataGridViewKetQua.Name = "dataGridViewKetQua";
            dataGridViewKetQua.ReadOnly = true;
            dataGridViewKetQua.RowHeadersVisible = false;
            dataGridViewKetQua.RowHeadersWidth = 51;
            dataGridViewKetQua.RowTemplate.Height = 32;
            dataGridViewKetQua.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewKetQua.Size = new Size(960, 324);
            dataGridViewKetQua.TabIndex = 2;
            // 
            // FormTimKiemQTDT
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(241, 245, 249);
            ClientSize = new Size(1020, 644);
            Controls.Add(dataGridViewKetQua);
            Controls.Add(labelTongSo);
            Controls.Add(labelKetQua);
            Controls.Add(panelTimKiem);
            Name = "FormTimKiemQTDT";
            Padding = new Padding(30, 20, 30, 20);
            Text = "Tìm kiếm quá trình đào tạo";
            Load += FormTimKiemQTDT_Load;
            panelTimKiem.ResumeLayout(false);
            tableLayoutPanelTimKiem.ResumeLayout(false);
            flowLayoutPanelNut.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewKetQua).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelTimKiem;
        private TableLayoutPanel tableLayoutPanelTimKiem;
        private Label labelNhanVien;
        private Label labelTruongDaoTao;
        private Label labelHinhThuc;
        private Label labelTuNgay;
        private Label labelDenNgay;
        private Label labelGhiChuNgay;
        private ComboBox comboBoxNhanVien;
        private ComboBox comboBoxTruongDaoTao;
        private ComboBox comboBoxHinhThuc;
        private DateTimePicker dateTimePickerTuNgay;
        private DateTimePicker dateTimePickerDenNgay;
        private FlowLayoutPanel flowLayoutPanelNut;
        private Button buttonTimKiem;
        private Button buttonLamMoi;
        private Label labelKetQua;
        private Label labelTongSo;
        private DataGridView dataGridViewKetQua;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumnMaQTDT;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumnMaNV;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumnHoTen;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumnTuNgay;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumnDenNgay;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumnTruongDaoTao;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumnHinhThuc;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumnNganhDaoTao;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumnXepLoai;
    }
}