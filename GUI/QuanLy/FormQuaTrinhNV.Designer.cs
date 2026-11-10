namespace QuanLyNhanSu.GUI
{
    partial class FormQuaTrinhNV
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
            this.labelNhanVien = new System.Windows.Forms.Label();
            this.comboBoxNhanVien = new System.Windows.Forms.ComboBox();
            this.buttonRefresh = new System.Windows.Forms.Button();
            this.labelTomTat = new System.Windows.Forms.Label();
            this.tabControlQuaTrinh = new System.Windows.Forms.TabControl();
            this.tabPageQTDT = new System.Windows.Forms.TabPage();
            this.tabPageQTCT = new System.Windows.Forms.TabPage();
            this.dataGridViewQTDT = new System.Windows.Forms.DataGridView();
            this.buttonChiTietQTDT = new System.Windows.Forms.Button();
            this.dataGridViewQTCT = new System.Windows.Forms.DataGridView();
            this.buttonChiTietQTCT = new System.Windows.Forms.Button();
            this.panelHeader.SuspendLayout();
            this.tabControlQuaTrinh.SuspendLayout();
            this.tabPageQTDT.SuspendLayout();
            this.tabPageQTCT.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewQTDT)).BeginInit();
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
            this.labelTitle.Text = "QUÁ TRÌNH CỦA NHÂN VIÊN";
            // 
            // labelNhanVien
            // 
            this.labelNhanVien.AutoSize = true;
            this.labelNhanVien.Location = new System.Drawing.Point(24, 91);
            this.labelNhanVien.Name = "labelNhanVien";
            this.labelNhanVien.Text = "Nhân viên:";
            // 
            // comboBoxNhanVien
            // 
            this.comboBoxNhanVien.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxNhanVien.FormattingEnabled = true;
            this.comboBoxNhanVien.Location = new System.Drawing.Point(105, 87);
            this.comboBoxNhanVien.Name = "comboBoxNhanVien";
            this.comboBoxNhanVien.Size = new System.Drawing.Size(360, 23);
            this.comboBoxNhanVien.TabIndex = 1;
            this.comboBoxNhanVien.SelectedIndexChanged += new System.EventHandler(this.comboBoxNhanVien_SelectedIndexChanged);
            // 
            // buttonRefresh
            // 
            this.buttonRefresh.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left;
            this.buttonRefresh.Location = new System.Drawing.Point(480, 84);
            this.buttonRefresh.Name = "buttonRefresh";
            this.buttonRefresh.Size = new System.Drawing.Size(100, 29);
            this.buttonRefresh.TabIndex = 2;
            this.buttonRefresh.Text = "Làm mới";
            this.buttonRefresh.UseVisualStyleBackColor = true;
            this.buttonRefresh.Click += new System.EventHandler(this.buttonRefresh_Click);
            // 
            // labelTomTat
            // 
            this.labelTomTat.AutoSize = false;
            this.labelTomTat.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            this.labelTomTat.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.labelTomTat.ForeColor = System.Drawing.Color.FromArgb(51, 65, 85);
            this.labelTomTat.Location = new System.Drawing.Point(24, 124);
            this.labelTomTat.Name = "labelTomTat";
            this.labelTomTat.Size = new System.Drawing.Size(952, 22);
            this.labelTomTat.TabIndex = 3;
            this.labelTomTat.Text = "Hãy chọn một nhân viên để xem quá trình đào tạo và công tác.";
            this.labelTomTat.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tabControlQuaTrinh
            // 
            this.tabControlQuaTrinh.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            this.tabControlQuaTrinh.Location = new System.Drawing.Point(24, 152);
            this.tabControlQuaTrinh.Name = "tabControlQuaTrinh";
            this.tabControlQuaTrinh.SelectedIndex = 0;
            this.tabControlQuaTrinh.Size = new System.Drawing.Size(952, 440);
            this.tabControlQuaTrinh.TabIndex = 4;
            this.tabControlQuaTrinh.Controls.Add(this.tabPageQTDT);
            this.tabControlQuaTrinh.Controls.Add(this.tabPageQTCT);
            // 
            // tabPageQTDT
            // 
            this.tabPageQTDT.BackColor = System.Drawing.Color.White;
            this.tabPageQTDT.Location = new System.Drawing.Point(4, 24);
            this.tabPageQTDT.Name = "tabPageQTDT";
            this.tabPageQTDT.Padding = new System.Windows.Forms.Padding(8);
            this.tabPageQTDT.Size = new System.Drawing.Size(944, 412);
            this.tabPageQTDT.TabIndex = 0;
            this.tabPageQTDT.Text = "Quá trình đào tạo";
            this.tabPageQTDT.Controls.Add(this.dataGridViewQTDT);
            this.tabPageQTDT.Controls.Add(this.buttonChiTietQTDT);
            // 
            // tabPageQTCT
            // 
            this.tabPageQTCT.BackColor = System.Drawing.Color.White;
            this.tabPageQTCT.Location = new System.Drawing.Point(4, 24);
            this.tabPageQTCT.Name = "tabPageQTCT";
            this.tabPageQTCT.Padding = new System.Windows.Forms.Padding(8);
            this.tabPageQTCT.Size = new System.Drawing.Size(944, 412);
            this.tabPageQTCT.TabIndex = 1;
            this.tabPageQTCT.Text = "Quá trình công tác";
            this.tabPageQTCT.Controls.Add(this.dataGridViewQTCT);
            this.tabPageQTCT.Controls.Add(this.buttonChiTietQTCT);
            // 
            // dataGridViewQTDT
            // 
            this.dataGridViewQTDT.AllowUserToAddRows = false;
            this.dataGridViewQTDT.AllowUserToDeleteRows = false;
            this.dataGridViewQTDT.AllowUserToResizeRows = false;
            this.dataGridViewQTDT.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            this.dataGridViewQTDT.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewQTDT.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewQTDT.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewQTDT.Location = new System.Drawing.Point(8, 8);
            this.dataGridViewQTDT.MultiSelect = false;
            this.dataGridViewQTDT.Name = "dataGridViewQTDT";
            this.dataGridViewQTDT.ReadOnly = true;
            this.dataGridViewQTDT.RowHeadersVisible = false;
            this.dataGridViewQTDT.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewQTDT.Size = new System.Drawing.Size(926, 358);
            this.dataGridViewQTDT.TabIndex = 0;
            this.dataGridViewQTDT.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewQTDT_CellDoubleClick);
            // 
            // buttonChiTietQTDT
            // 
            this.buttonChiTietQTDT.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            this.buttonChiTietQTDT.Location = new System.Drawing.Point(8, 372);
            this.buttonChiTietQTDT.Name = "buttonChiTietQTDT";
            this.buttonChiTietQTDT.Size = new System.Drawing.Size(120, 32);
            this.buttonChiTietQTDT.TabIndex = 1;
            this.buttonChiTietQTDT.Text = "Xem chi tiết";
            this.buttonChiTietQTDT.UseVisualStyleBackColor = true;
            this.buttonChiTietQTDT.Click += new System.EventHandler(this.buttonChiTietQTDT_Click);
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
            this.dataGridViewQTCT.Location = new System.Drawing.Point(8, 8);
            this.dataGridViewQTCT.MultiSelect = false;
            this.dataGridViewQTCT.Name = "dataGridViewQTCT";
            this.dataGridViewQTCT.ReadOnly = true;
            this.dataGridViewQTCT.RowHeadersVisible = false;
            this.dataGridViewQTCT.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewQTCT.Size = new System.Drawing.Size(926, 358);
            this.dataGridViewQTCT.TabIndex = 0;
            this.dataGridViewQTCT.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewQTCT_CellDoubleClick);
            // 
            // buttonChiTietQTCT
            // 
            this.buttonChiTietQTCT.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            this.buttonChiTietQTCT.Location = new System.Drawing.Point(8, 372);
            this.buttonChiTietQTCT.Name = "buttonChiTietQTCT";
            this.buttonChiTietQTCT.Size = new System.Drawing.Size(120, 32);
            this.buttonChiTietQTCT.TabIndex = 1;
            this.buttonChiTietQTCT.Text = "Xem chi tiết";
            this.buttonChiTietQTCT.UseVisualStyleBackColor = true;
            this.buttonChiTietQTCT.Click += new System.EventHandler(this.buttonChiTietQTCT_Click);
            // 
            // FormQuaTrinhNV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(248, 250, 252);
            this.ClientSize = new System.Drawing.Size(1000, 620);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Name = "FormQuaTrinhNV";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quá trình của nhân viên - QuanLyNhanSu";
            this.Controls.Add(this.tabControlQuaTrinh);
            this.Controls.Add(this.labelTomTat);
            this.Controls.Add(this.buttonRefresh);
            this.Controls.Add(this.comboBoxNhanVien);
            this.Controls.Add(this.labelNhanVien);
            this.Controls.Add(this.panelHeader);
            this.Load += new System.EventHandler(this.FormQuaTrinhNV_Load);
            this.panelHeader.ResumeLayout(false);
            this.tabControlQuaTrinh.ResumeLayout(false);
            this.tabPageQTDT.ResumeLayout(false);
            this.tabPageQTCT.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewQTDT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewQTCT)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Label labelNhanVien;
        private System.Windows.Forms.ComboBox comboBoxNhanVien;
        private System.Windows.Forms.Button buttonRefresh;
        private System.Windows.Forms.Label labelTomTat;
        private System.Windows.Forms.TabControl tabControlQuaTrinh;
        private System.Windows.Forms.TabPage tabPageQTDT;
        private System.Windows.Forms.TabPage tabPageQTCT;
        private System.Windows.Forms.DataGridView dataGridViewQTDT;
        private System.Windows.Forms.Button buttonChiTietQTDT;
        private System.Windows.Forms.DataGridView dataGridViewQTCT;
        private System.Windows.Forms.Button buttonChiTietQTCT;
    }
}
