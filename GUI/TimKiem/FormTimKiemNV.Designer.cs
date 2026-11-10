namespace QuanLyNhanSu.GUI
{
    partial class FormTimKiemNV
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
            labelMaNV = new Label();
            labelHoTen = new Label();
            labelPhongBan = new Label();
            textBoxMaNV = new TextBox();
            textBoxHoTen = new TextBox();
            comboBoxPhongBan = new ComboBox();
            labelChucVu = new Label();
            labelHocVan = new Label();
            labelNgoaiNgu = new Label();
            comboBoxChucVu = new ComboBox();
            comboBoxHocVan = new ComboBox();
            comboBoxNgoaiNgu = new ComboBox();
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
            tableLayoutPanelTimKiem.Controls.Add(labelMaNV, 0, 0);
            tableLayoutPanelTimKiem.Controls.Add(labelHoTen, 1, 0);
            tableLayoutPanelTimKiem.Controls.Add(labelPhongBan, 2, 0);
            tableLayoutPanelTimKiem.Controls.Add(textBoxMaNV, 0, 1);
            tableLayoutPanelTimKiem.Controls.Add(textBoxHoTen, 1, 1);
            tableLayoutPanelTimKiem.Controls.Add(comboBoxPhongBan, 2, 1);
            tableLayoutPanelTimKiem.Controls.Add(labelChucVu, 0, 2);
            tableLayoutPanelTimKiem.Controls.Add(labelHocVan, 1, 2);
            tableLayoutPanelTimKiem.Controls.Add(labelNgoaiNgu, 2, 2);
            tableLayoutPanelTimKiem.Controls.Add(comboBoxChucVu, 0, 3);
            tableLayoutPanelTimKiem.Controls.Add(comboBoxHocVan, 1, 3);
            tableLayoutPanelTimKiem.Controls.Add(comboBoxNgoaiNgu, 2, 3);
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
            // labelMaNV
            // 
            labelMaNV.Dock = DockStyle.Fill;
            labelMaNV.Font = new Font("Segoe UI", 9.5F);
            labelMaNV.ForeColor = Color.FromArgb(51, 65, 85);
            labelMaNV.Location = new Point(3, 0);
            labelMaNV.Name = "labelMaNV";
            labelMaNV.Size = new Size(300, 24);
            labelMaNV.TabIndex = 0;
            labelMaNV.Text = "Mã nhân viên";
            labelMaNV.TextAlign = ContentAlignment.BottomLeft;
            // 
            // labelHoTen
            // 
            labelHoTen.Dock = DockStyle.Fill;
            labelHoTen.Font = new Font("Segoe UI", 9.5F);
            labelHoTen.ForeColor = Color.FromArgb(51, 65, 85);
            labelHoTen.Location = new Point(309, 0);
            labelHoTen.Name = "labelHoTen";
            labelHoTen.Size = new Size(300, 24);
            labelHoTen.TabIndex = 1;
            labelHoTen.Text = "Họ tên";
            labelHoTen.TextAlign = ContentAlignment.BottomLeft;
            // 
            // labelPhongBan
            // 
            labelPhongBan.Dock = DockStyle.Fill;
            labelPhongBan.Font = new Font("Segoe UI", 9.5F);
            labelPhongBan.ForeColor = Color.FromArgb(51, 65, 85);
            labelPhongBan.Location = new Point(615, 0);
            labelPhongBan.Name = "labelPhongBan";
            labelPhongBan.Size = new Size(302, 24);
            labelPhongBan.TabIndex = 2;
            labelPhongBan.Text = "Phòng ban";
            labelPhongBan.TextAlign = ContentAlignment.BottomLeft;
            // 
            // textBoxMaNV
            // 
            textBoxMaNV.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            textBoxMaNV.Font = new Font("Segoe UI", 10.5F);
            textBoxMaNV.Location = new Point(0, 28);
            textBoxMaNV.Margin = new Padding(0, 3, 16, 3);
            textBoxMaNV.MaxLength = 10;
            textBoxMaNV.Name = "textBoxMaNV";
            textBoxMaNV.Size = new Size(290, 31);
            textBoxMaNV.TabIndex = 0;
            textBoxMaNV.KeyDown += textBoxTimKiem_KeyDown;
            // 
            // textBoxHoTen
            // 
            textBoxHoTen.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            textBoxHoTen.Font = new Font("Segoe UI", 10.5F);
            textBoxHoTen.Location = new Point(306, 28);
            textBoxHoTen.Margin = new Padding(0, 3, 16, 3);
            textBoxHoTen.MaxLength = 50;
            textBoxHoTen.Name = "textBoxHoTen";
            textBoxHoTen.Size = new Size(290, 31);
            textBoxHoTen.TabIndex = 1;
            textBoxHoTen.KeyDown += textBoxTimKiem_KeyDown;
            // 
            // comboBoxPhongBan
            // 
            comboBoxPhongBan.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            comboBoxPhongBan.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxPhongBan.Font = new Font("Segoe UI", 10.5F);
            comboBoxPhongBan.FormattingEnabled = true;
            comboBoxPhongBan.Location = new Point(612, 27);
            comboBoxPhongBan.Margin = new Padding(0, 3, 0, 3);
            comboBoxPhongBan.Name = "comboBoxPhongBan";
            comboBoxPhongBan.Size = new Size(308, 31);
            comboBoxPhongBan.TabIndex = 2;
            // 
            // labelChucVu
            // 
            labelChucVu.Dock = DockStyle.Fill;
            labelChucVu.Font = new Font("Segoe UI", 9.5F);
            labelChucVu.ForeColor = Color.FromArgb(51, 65, 85);
            labelChucVu.Location = new Point(3, 64);
            labelChucVu.Name = "labelChucVu";
            labelChucVu.Size = new Size(300, 24);
            labelChucVu.TabIndex = 3;
            labelChucVu.Text = "Chức vụ";
            labelChucVu.TextAlign = ContentAlignment.BottomLeft;
            // 
            // labelHocVan
            // 
            labelHocVan.Dock = DockStyle.Fill;
            labelHocVan.Font = new Font("Segoe UI", 9.5F);
            labelHocVan.ForeColor = Color.FromArgb(51, 65, 85);
            labelHocVan.Location = new Point(309, 64);
            labelHocVan.Name = "labelHocVan";
            labelHocVan.Size = new Size(300, 24);
            labelHocVan.TabIndex = 4;
            labelHocVan.Text = "Học vấn";
            labelHocVan.TextAlign = ContentAlignment.BottomLeft;
            // 
            // labelNgoaiNgu
            // 
            labelNgoaiNgu.Dock = DockStyle.Fill;
            labelNgoaiNgu.Font = new Font("Segoe UI", 9.5F);
            labelNgoaiNgu.ForeColor = Color.FromArgb(51, 65, 85);
            labelNgoaiNgu.Location = new Point(615, 64);
            labelNgoaiNgu.Name = "labelNgoaiNgu";
            labelNgoaiNgu.Size = new Size(302, 24);
            labelNgoaiNgu.TabIndex = 5;
            labelNgoaiNgu.Text = "Ngoại ngữ";
            labelNgoaiNgu.TextAlign = ContentAlignment.BottomLeft;
            // 
            // comboBoxChucVu
            // 
            comboBoxChucVu.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            comboBoxChucVu.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxChucVu.Font = new Font("Segoe UI", 10.5F);
            comboBoxChucVu.FormattingEnabled = true;
            comboBoxChucVu.Location = new Point(0, 91);
            comboBoxChucVu.Margin = new Padding(0, 3, 16, 3);
            comboBoxChucVu.Name = "comboBoxChucVu";
            comboBoxChucVu.Size = new Size(290, 31);
            comboBoxChucVu.TabIndex = 3;
            // 
            // comboBoxHocVan
            // 
            comboBoxHocVan.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            comboBoxHocVan.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxHocVan.Font = new Font("Segoe UI", 10.5F);
            comboBoxHocVan.FormattingEnabled = true;
            comboBoxHocVan.Location = new Point(306, 91);
            comboBoxHocVan.Margin = new Padding(0, 3, 16, 3);
            comboBoxHocVan.Name = "comboBoxHocVan";
            comboBoxHocVan.Size = new Size(290, 31);
            comboBoxHocVan.TabIndex = 4;
            // 
            // comboBoxNgoaiNgu
            // 
            comboBoxNgoaiNgu.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            comboBoxNgoaiNgu.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxNgoaiNgu.Font = new Font("Segoe UI", 10.5F);
            comboBoxNgoaiNgu.FormattingEnabled = true;
            comboBoxNgoaiNgu.Location = new Point(612, 91);
            comboBoxNgoaiNgu.Margin = new Padding(0, 3, 0, 3);
            comboBoxNgoaiNgu.Name = "comboBoxNgoaiNgu";
            comboBoxNgoaiNgu.Size = new Size(308, 31);
            comboBoxNgoaiNgu.TabIndex = 5;
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
            flowLayoutPanelNut.TabIndex = 6;
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
            // FormTimKiemNV
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(241, 245, 249);
            ClientSize = new Size(1020, 644);
            Controls.Add(dataGridViewKetQua);
            Controls.Add(labelTongSo);
            Controls.Add(labelKetQua);
            Controls.Add(panelTimKiem);
            Name = "FormTimKiemNV";
            Padding = new Padding(30, 20, 30, 20);
            Text = "Tìm kiếm nhân viên";
            Load += FormTimKiemNV_Load;
            panelTimKiem.ResumeLayout(false);
            tableLayoutPanelTimKiem.ResumeLayout(false);
            tableLayoutPanelTimKiem.PerformLayout();
            flowLayoutPanelNut.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewKetQua).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelTimKiem;
        private TableLayoutPanel tableLayoutPanelTimKiem;
        private Label labelMaNV;
        private Label labelHoTen;
        private Label labelPhongBan;
        private Label labelChucVu;
        private Label labelHocVan;
        private Label labelNgoaiNgu;
        private TextBox textBoxMaNV;
        private TextBox textBoxHoTen;
        private ComboBox comboBoxPhongBan;
        private ComboBox comboBoxChucVu;
        private ComboBox comboBoxHocVan;
        private ComboBox comboBoxNgoaiNgu;
        private FlowLayoutPanel flowLayoutPanelNut;
        private Button buttonTimKiem;
        private Button buttonLamMoi;
        private Label labelKetQua;
        private Label labelTongSo;
        private DataGridView dataGridViewKetQua;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumnMaNV;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumnHoTen;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumnPhongBan;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumnChucVu;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumnHocVan;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumnNgoaiNgu;
    }
}