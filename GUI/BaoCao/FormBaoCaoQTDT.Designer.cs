namespace QuanLyNhanSu.GUI
{
    partial class FormBaoCaoQTDT
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
            labelTieuDe = new Label();
            groupBoxDieuKien = new GroupBox();
            buttonDong = new Button();
            buttonTaiLai = new Button();
            buttonLoc = new Button();
            comboBoxNganhDT = new ComboBox();
            comboBoxTruongDT = new ComboBox();
            labelNganhDT = new Label();
            labelTruongDT = new Label();
            comboBoxNhanVien = new ComboBox();
            labelNhanVien = new Label();
            labelDanhSach = new Label();
            dataGridViewQTDT = new DataGridView();
            buttonXuatExcel = new Button();
            groupBoxDieuKien.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewQTDT).BeginInit();
            SuspendLayout();
            // 
            // labelTieuDe
            // 
            labelTieuDe.AutoSize = true;
            labelTieuDe.Location = new Point(271, 9);
            labelTieuDe.Name = "labelTieuDe";
            labelTieuDe.Size = new Size(224, 20);
            labelTieuDe.TabIndex = 0;
            labelTieuDe.Text = "BÁO CÁO QUÁ TRÌNH ĐÀO TẠO";
            // 
            // groupBoxDieuKien
            // 
            groupBoxDieuKien.Controls.Add(buttonXuatExcel);
            groupBoxDieuKien.Controls.Add(buttonDong);
            groupBoxDieuKien.Controls.Add(buttonTaiLai);
            groupBoxDieuKien.Controls.Add(buttonLoc);
            groupBoxDieuKien.Controls.Add(comboBoxNganhDT);
            groupBoxDieuKien.Controls.Add(comboBoxTruongDT);
            groupBoxDieuKien.Controls.Add(labelNganhDT);
            groupBoxDieuKien.Controls.Add(labelTruongDT);
            groupBoxDieuKien.Controls.Add(comboBoxNhanVien);
            groupBoxDieuKien.Controls.Add(labelNhanVien);
            groupBoxDieuKien.Location = new Point(12, 46);
            groupBoxDieuKien.Name = "groupBoxDieuKien";
            groupBoxDieuKien.Size = new Size(776, 292);
            groupBoxDieuKien.TabIndex = 1;
            groupBoxDieuKien.TabStop = false;
            groupBoxDieuKien.Text = "Điều kiện báo cáo";
            // 
            // buttonDong
            // 
            buttonDong.Location = new Point(576, 257);
            buttonDong.Name = "buttonDong";
            buttonDong.Size = new Size(94, 29);
            buttonDong.TabIndex = 8;
            buttonDong.Text = "Đóng";
            buttonDong.UseVisualStyleBackColor = true;
            // 
            // buttonTaiLai
            // 
            buttonTaiLai.Location = new Point(343, 257);
            buttonTaiLai.Name = "buttonTaiLai";
            buttonTaiLai.Size = new Size(94, 29);
            buttonTaiLai.TabIndex = 7;
            buttonTaiLai.Text = "Tải lại";
            buttonTaiLai.UseVisualStyleBackColor = true;
            // 
            // buttonLoc
            // 
            buttonLoc.Location = new Point(203, 257);
            buttonLoc.Name = "buttonLoc";
            buttonLoc.Size = new Size(134, 29);
            buttonLoc.TabIndex = 6;
            buttonLoc.Text = "Lọc báo cáo";
            buttonLoc.UseVisualStyleBackColor = true;
            // 
            // comboBoxNganhDT
            // 
            comboBoxNganhDT.FormattingEnabled = true;
            comboBoxNganhDT.Location = new Point(19, 213);
            comboBoxNganhDT.Name = "comboBoxNganhDT";
            comboBoxNganhDT.Size = new Size(151, 28);
            comboBoxNganhDT.TabIndex = 5;
            // 
            // comboBoxTruongDT
            // 
            comboBoxTruongDT.FormattingEnabled = true;
            comboBoxTruongDT.Location = new Point(19, 139);
            comboBoxTruongDT.Name = "comboBoxTruongDT";
            comboBoxTruongDT.Size = new Size(151, 28);
            comboBoxTruongDT.TabIndex = 4;
            // 
            // labelNganhDT
            // 
            labelNganhDT.AutoSize = true;
            labelNganhDT.Location = new Point(19, 181);
            labelNganhDT.Name = "labelNganhDT";
            labelNganhDT.Size = new Size(109, 20);
            labelNganhDT.TabIndex = 3;
            labelNganhDT.Text = "Ngành đào tạo";
            // 
            // labelTruongDT
            // 
            labelTruongDT.AutoSize = true;
            labelTruongDT.Location = new Point(19, 104);
            labelTruongDT.Name = "labelTruongDT";
            labelTruongDT.Size = new Size(112, 20);
            labelTruongDT.TabIndex = 2;
            labelTruongDT.Text = "Trường đào tạo";
            // 
            // comboBoxNhanVien
            // 
            comboBoxNhanVien.FormattingEnabled = true;
            comboBoxNhanVien.Location = new Point(19, 64);
            comboBoxNhanVien.Name = "comboBoxNhanVien";
            comboBoxNhanVien.Size = new Size(151, 28);
            comboBoxNhanVien.TabIndex = 1;
            // 
            // labelNhanVien
            // 
            labelNhanVien.AutoSize = true;
            labelNhanVien.Location = new Point(19, 32);
            labelNhanVien.Name = "labelNhanVien";
            labelNhanVien.Size = new Size(75, 20);
            labelNhanVien.TabIndex = 0;
            labelNhanVien.Text = "Nhân viên";
            // 
            // labelDanhSach
            // 
            labelDanhSach.AutoSize = true;
            labelDanhSach.Location = new Point(12, 351);
            labelDanhSach.Name = "labelDanhSach";
            labelDanhSach.Size = new Size(245, 20);
            labelDanhSach.TabIndex = 2;
            labelDanhSach.Text = "DANH SÁCH QUÁ TRÌNH ĐÀO TẠO";
            // 
            // dataGridViewQTDT
            // 
            dataGridViewQTDT.AllowUserToAddRows = false;
            dataGridViewQTDT.AllowUserToDeleteRows = false;
            dataGridViewQTDT.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewQTDT.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewQTDT.Location = new Point(12, 374);
            dataGridViewQTDT.MultiSelect = false;
            dataGridViewQTDT.Name = "dataGridViewQTDT";
            dataGridViewQTDT.ReadOnly = true;
            dataGridViewQTDT.RowHeadersVisible = false;
            dataGridViewQTDT.RowHeadersWidth = 51;
            dataGridViewQTDT.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewQTDT.Size = new Size(776, 226);
            dataGridViewQTDT.TabIndex = 3;
            // 
            // buttonXuatExcel
            // 
            buttonXuatExcel.Location = new Point(443, 257);
            buttonXuatExcel.Name = "buttonXuatExcel";
            buttonXuatExcel.Size = new Size(127, 29);
            buttonXuatExcel.TabIndex = 9;
            buttonXuatExcel.Text = "Xuất báo cáo";
            buttonXuatExcel.UseVisualStyleBackColor = true;
            // 
            // FormBaoCaoQTDT
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 612);
            Controls.Add(dataGridViewQTDT);
            Controls.Add(labelDanhSach);
            Controls.Add(groupBoxDieuKien);
            Controls.Add(labelTieuDe);
            Name = "FormBaoCaoQTDT";
            Text = "FormBaoCaoQTDT";
            groupBoxDieuKien.ResumeLayout(false);
            groupBoxDieuKien.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewQTDT).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelTieuDe;
        private GroupBox groupBoxDieuKien;
        private ComboBox comboBoxNganhDT;
        private ComboBox comboBoxTruongDT;
        private Label labelNganhDT;
        private Label labelTruongDT;
        private ComboBox comboBoxNhanVien;
        private Label labelNhanVien;
        private Button buttonDong;
        private Button buttonTaiLai;
        private Button buttonLoc;
        private Label labelDanhSach;
        private DataGridView dataGridViewQTDT;
        private Button buttonXuatExcel;
    }
}