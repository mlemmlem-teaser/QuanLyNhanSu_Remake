namespace QuanLyNhanSu.GUI
{
    partial class FormQTCT
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelHeader = new System.Windows.Forms.Panel();
            this.labelTitle = new System.Windows.Forms.Label();
            this.labelLocNhanVien = new System.Windows.Forms.Label();
            this.comboBoxLocNhanVien = new System.Windows.Forms.ComboBox();
            this.labelLocPhongBan = new System.Windows.Forms.Label();
            this.comboBoxLocPhongBan = new System.Windows.Forms.ComboBox();
            this.groupBoxNhap = new System.Windows.Forms.GroupBox();
            this.labelMa = new System.Windows.Forms.Label();
            this.textBoxMa = new System.Windows.Forms.TextBox();
            this.labelNhanVien = new System.Windows.Forms.Label();
            this.comboBoxNhanVien = new System.Windows.Forms.ComboBox();
            this.labelPhongBan = new System.Windows.Forms.Label();
            this.comboBoxPhongBan = new System.Windows.Forms.ComboBox();
            this.labelChucVu = new System.Windows.Forms.Label();
            this.comboBoxChucVu = new System.Windows.Forms.ComboBox();
            this.labelTuNgay = new System.Windows.Forms.Label();
            this.dateTimePickerTuNgay = new System.Windows.Forms.DateTimePicker();
            this.labelDenNgay = new System.Windows.Forms.Label();
            this.dateTimePickerDenNgay = new System.Windows.Forms.DateTimePicker();
            this.dataGridViewQTCT = new System.Windows.Forms.DataGridView();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonRefresh = new System.Windows.Forms.Button();
            this.panelHeader.SuspendLayout();
            this.groupBoxNhap.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewQTCT)).BeginInit();
            this.SuspendLayout();
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.FromArgb(31, 41, 55);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(1000, 70);
            this.panelHeader.TabIndex = 0;
            this.panelHeader.Controls.Add(this.labelTitle);
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.labelTitle.ForeColor = System.Drawing.Color.White;
            this.labelTitle.Location = new System.Drawing.Point(22, 18);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Text = "QUẢN LÝ QUÁ TRÌNH CÔNG TÁC";
            // 
            // labelLocNhanVien
            // 
            this.labelLocNhanVien.AutoSize = true;
            this.labelLocNhanVien.Location = new System.Drawing.Point(24, 89);
            this.labelLocNhanVien.Name = "labelLocNhanVien";
            this.labelLocNhanVien.Text = "Lọc theo nhân viên:";
            // 
            // comboBoxLocNhanVien
            // 
            this.comboBoxLocNhanVien.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxLocNhanVien.FormattingEnabled = true;
            this.comboBoxLocNhanVien.Location = new System.Drawing.Point(150, 85);
            this.comboBoxLocNhanVien.Name = "comboBoxLocNhanVien";
            this.comboBoxLocNhanVien.Size = new System.Drawing.Size(290, 23);
            this.comboBoxLocNhanVien.TabIndex = 1;
            this.comboBoxLocNhanVien.SelectedIndexChanged += new System.EventHandler(this.comboBoxLoc_SelectedIndexChanged);
            // 
            // labelLocPhongBan
            // 
            this.labelLocPhongBan.AutoSize = true;
            this.labelLocPhongBan.Location = new System.Drawing.Point(470, 89);
            this.labelLocPhongBan.Name = "labelLocPhongBan";
            this.labelLocPhongBan.Text = "Phòng ban:";
            // 
            // comboBoxLocPhongBan
            // 
            this.comboBoxLocPhongBan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxLocPhongBan.FormattingEnabled = true;
            this.comboBoxLocPhongBan.Location = new System.Drawing.Point(545, 85);
            this.comboBoxLocPhongBan.Name = "comboBoxLocPhongBan";
            this.comboBoxLocPhongBan.Size = new System.Drawing.Size(250, 23);
            this.comboBoxLocPhongBan.TabIndex = 2;
            this.comboBoxLocPhongBan.SelectedIndexChanged += new System.EventHandler(this.comboBoxLoc_SelectedIndexChanged);
            // 
            // groupBoxNhap
            // 
            this.groupBoxNhap.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            this.groupBoxNhap.Location = new System.Drawing.Point(24, 122);
            this.groupBoxNhap.Name = "groupBoxNhap";
            this.groupBoxNhap.Size = new System.Drawing.Size(952, 108);
            this.groupBoxNhap.TabIndex = 3;
            this.groupBoxNhap.TabStop = false;
            this.groupBoxNhap.Text = "Thông tin quá trình công tác";
            this.groupBoxNhap.Controls.Add(this.labelMa);
            this.groupBoxNhap.Controls.Add(this.textBoxMa);
            this.groupBoxNhap.Controls.Add(this.labelNhanVien);
            this.groupBoxNhap.Controls.Add(this.comboBoxNhanVien);
            this.groupBoxNhap.Controls.Add(this.labelPhongBan);
            this.groupBoxNhap.Controls.Add(this.comboBoxPhongBan);
            this.groupBoxNhap.Controls.Add(this.labelChucVu);
            this.groupBoxNhap.Controls.Add(this.comboBoxChucVu);
            this.groupBoxNhap.Controls.Add(this.labelTuNgay);
            this.groupBoxNhap.Controls.Add(this.dateTimePickerTuNgay);
            this.groupBoxNhap.Controls.Add(this.labelDenNgay);
            this.groupBoxNhap.Controls.Add(this.dateTimePickerDenNgay);
            // 
            // labelMa
            // 
            this.labelMa.AutoSize = true;
            this.labelMa.Location = new System.Drawing.Point(16, 31);
            this.labelMa.Name = "labelMa";
            this.labelMa.Text = "Mã QTCT:";
            // 
            // textBoxMa
            // 
            this.textBoxMa.Location = new System.Drawing.Point(105, 28);
            this.textBoxMa.Name = "textBoxMa";
            this.textBoxMa.Size = new System.Drawing.Size(190, 23);
            this.textBoxMa.TabIndex = 0;
            this.textBoxMa.MaxLength = 10;
            // 
            // labelNhanVien
            // 
            this.labelNhanVien.AutoSize = true;
            this.labelNhanVien.Location = new System.Drawing.Point(320, 31);
            this.labelNhanVien.Name = "labelNhanVien";
            this.labelNhanVien.Text = "Nhân viên:";
            // 
            // comboBoxNhanVien
            // 
            this.comboBoxNhanVien.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxNhanVien.FormattingEnabled = true;
            this.comboBoxNhanVien.Location = new System.Drawing.Point(415, 28);
            this.comboBoxNhanVien.Name = "comboBoxNhanVien";
            this.comboBoxNhanVien.Size = new System.Drawing.Size(200, 23);
            this.comboBoxNhanVien.TabIndex = 1;
            // 
            // labelPhongBan
            // 
            this.labelPhongBan.AutoSize = true;
            this.labelPhongBan.Location = new System.Drawing.Point(630, 31);
            this.labelPhongBan.Name = "labelPhongBan";
            this.labelPhongBan.Text = "Phòng ban:";
            // 
            // comboBoxPhongBan
            // 
            this.comboBoxPhongBan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxPhongBan.FormattingEnabled = true;
            this.comboBoxPhongBan.Location = new System.Drawing.Point(735, 28);
            this.comboBoxPhongBan.Name = "comboBoxPhongBan";
            this.comboBoxPhongBan.Size = new System.Drawing.Size(190, 23);
            this.comboBoxPhongBan.TabIndex = 2;
            // 
            // labelChucVu
            // 
            this.labelChucVu.AutoSize = true;
            this.labelChucVu.Location = new System.Drawing.Point(16, 67);
            this.labelChucVu.Name = "labelChucVu";
            this.labelChucVu.Text = "Chức vụ:";
            // 
            // comboBoxChucVu
            // 
            this.comboBoxChucVu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxChucVu.FormattingEnabled = true;
            this.comboBoxChucVu.Location = new System.Drawing.Point(105, 64);
            this.comboBoxChucVu.Name = "comboBoxChucVu";
            this.comboBoxChucVu.Size = new System.Drawing.Size(190, 23);
            this.comboBoxChucVu.TabIndex = 3;
            // 
            // labelTuNgay
            // 
            this.labelTuNgay.AutoSize = true;
            this.labelTuNgay.Location = new System.Drawing.Point(320, 67);
            this.labelTuNgay.Name = "labelTuNgay";
            this.labelTuNgay.Text = "Từ ngày:";
            // 
            // dateTimePickerTuNgay
            // 
            this.dateTimePickerTuNgay.CustomFormat = "dd/MM/yyyy";
            this.dateTimePickerTuNgay.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerTuNgay.Location = new System.Drawing.Point(415, 64);
            this.dateTimePickerTuNgay.Name = "dateTimePickerTuNgay";
            this.dateTimePickerTuNgay.Size = new System.Drawing.Size(200, 23);
            this.dateTimePickerTuNgay.TabIndex = 4;
            // 
            // labelDenNgay
            // 
            this.labelDenNgay.AutoSize = true;
            this.labelDenNgay.Location = new System.Drawing.Point(630, 67);
            this.labelDenNgay.Name = "labelDenNgay";
            this.labelDenNgay.Text = "Đến ngày:";
            // 
            // dateTimePickerDenNgay
            // 
            this.dateTimePickerDenNgay.CustomFormat = "dd/MM/yyyy";
            this.dateTimePickerDenNgay.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerDenNgay.Location = new System.Drawing.Point(735, 64);
            this.dateTimePickerDenNgay.Name = "dateTimePickerDenNgay";
            this.dateTimePickerDenNgay.Size = new System.Drawing.Size(190, 23);
            this.dateTimePickerDenNgay.TabIndex = 5;
            this.dateTimePickerDenNgay.ShowCheckBox = true;
            this.dateTimePickerDenNgay.Checked = false;
            // 
            // dataGridViewQTCT
            // 
            this.dataGridViewQTCT.AllowUserToAddRows = false;
            this.dataGridViewQTCT.AllowUserToDeleteRows = false;
            this.dataGridViewQTCT.AllowUserToResizeRows = false;
            this.dataGridViewQTCT.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            this.dataGridViewQTCT.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewQTCT.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewQTCT.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewQTCT.Location = new System.Drawing.Point(24, 243);
            this.dataGridViewQTCT.MultiSelect = false;
            this.dataGridViewQTCT.Name = "dataGridViewQTCT";
            this.dataGridViewQTCT.ReadOnly = true;
            this.dataGridViewQTCT.RowHeadersVisible = false;
            this.dataGridViewQTCT.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewQTCT.Size = new System.Drawing.Size(952, 307);
            this.dataGridViewQTCT.TabIndex = 4;
            this.dataGridViewQTCT.SelectionChanged += new System.EventHandler(this.dataGridViewQTCT_SelectionChanged);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            this.buttonAdd.Location = new System.Drawing.Point(24, 568);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(105, 34);
            this.buttonAdd.TabIndex = 5;
            this.buttonAdd.Text = "Thêm";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonEdit
            // 
            this.buttonEdit.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            this.buttonEdit.Location = new System.Drawing.Point(140, 568);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(105, 34);
            this.buttonEdit.TabIndex = 6;
            this.buttonEdit.Text = "Sửa";
            this.buttonEdit.UseVisualStyleBackColor = true;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            this.buttonDelete.Location = new System.Drawing.Point(256, 568);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(105, 34);
            this.buttonDelete.TabIndex = 7;
            this.buttonDelete.Text = "Xóa";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonRefresh
            // 
            this.buttonRefresh.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            this.buttonRefresh.Location = new System.Drawing.Point(372, 568);
            this.buttonRefresh.Name = "buttonRefresh";
            this.buttonRefresh.Size = new System.Drawing.Size(105, 34);
            this.buttonRefresh.TabIndex = 8;
            this.buttonRefresh.Text = "Làm mới";
            this.buttonRefresh.UseVisualStyleBackColor = true;
            this.buttonRefresh.Click += new System.EventHandler(this.buttonRefresh_Click);
            // 
            // FormQTCT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(248, 250, 252);
            this.ClientSize = new System.Drawing.Size(1000, 620);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Name = "FormQTCT";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý quá trình công tác - QuanLyNhanSu";
            this.Controls.Add(this.buttonRefresh);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.dataGridViewQTCT);
            this.Controls.Add(this.groupBoxNhap);
            this.Controls.Add(this.comboBoxLocPhongBan);
            this.Controls.Add(this.labelLocPhongBan);
            this.Controls.Add(this.comboBoxLocNhanVien);
            this.Controls.Add(this.labelLocNhanVien);
            this.Controls.Add(this.panelHeader);
            this.Load += new System.EventHandler(this.FormQTCT_Load);
            this.panelHeader.ResumeLayout(false);
            this.groupBoxNhap.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.groupBoxNhap.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewQTCT)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Label labelLocNhanVien;
        private System.Windows.Forms.ComboBox comboBoxLocNhanVien;
        private System.Windows.Forms.Label labelLocPhongBan;
        private System.Windows.Forms.ComboBox comboBoxLocPhongBan;
        private System.Windows.Forms.GroupBox groupBoxNhap;
        private System.Windows.Forms.Label labelMa;
        private System.Windows.Forms.TextBox textBoxMa;
        private System.Windows.Forms.Label labelNhanVien;
        private System.Windows.Forms.ComboBox comboBoxNhanVien;
        private System.Windows.Forms.Label labelPhongBan;
        private System.Windows.Forms.ComboBox comboBoxPhongBan;
        private System.Windows.Forms.Label labelChucVu;
        private System.Windows.Forms.ComboBox comboBoxChucVu;
        private System.Windows.Forms.Label labelTuNgay;
        private System.Windows.Forms.DateTimePicker dateTimePickerTuNgay;
        private System.Windows.Forms.Label labelDenNgay;
        private System.Windows.Forms.DateTimePicker dateTimePickerDenNgay;
        private System.Windows.Forms.DataGridView dataGridViewQTCT;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonRefresh;
    }
}
