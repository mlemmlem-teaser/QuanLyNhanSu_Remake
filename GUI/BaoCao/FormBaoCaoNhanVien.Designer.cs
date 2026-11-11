namespace QuanLyNhanSu.GUI
{
    partial class FormBaoCaoNhanVien
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
            comboBoxChuyenMon = new ComboBox();
            labelChuyenMon = new Label();
            comboBoxNgoaiNgu = new ComboBox();
            labelNgoaiNgu = new Label();
            labelDanhSach = new Label();
            dataGridViewNhanVien = new DataGridView();
            buttonXuatExcel = new Button();
            groupBoxDieuKien.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewNhanVien).BeginInit();
            SuspendLayout();
            // 
            // labelTieuDe
            // 
            labelTieuDe.AutoSize = true;
            labelTieuDe.Location = new Point(261, 9);
            labelTieuDe.Name = "labelTieuDe";
            labelTieuDe.Size = new Size(238, 20);
            labelTieuDe.TabIndex = 0;
            labelTieuDe.Text = "BÁO CÁO THÔNG TIN NHÂN VIÊN";
            // 
            // groupBoxDieuKien
            // 
            groupBoxDieuKien.Controls.Add(buttonXuatExcel);
            groupBoxDieuKien.Controls.Add(buttonDong);
            groupBoxDieuKien.Controls.Add(buttonTaiLai);
            groupBoxDieuKien.Controls.Add(buttonLoc);
            groupBoxDieuKien.Controls.Add(comboBoxChuyenMon);
            groupBoxDieuKien.Controls.Add(labelChuyenMon);
            groupBoxDieuKien.Controls.Add(comboBoxNgoaiNgu);
            groupBoxDieuKien.Controls.Add(labelNgoaiNgu);
            groupBoxDieuKien.Location = new Point(12, 50);
            groupBoxDieuKien.Name = "groupBoxDieuKien";
            groupBoxDieuKien.Size = new Size(776, 222);
            groupBoxDieuKien.TabIndex = 1;
            groupBoxDieuKien.TabStop = false;
            groupBoxDieuKien.Text = "Điều kiện báo cáo";
            // 
            // buttonDong
            // 
            buttonDong.Location = new Point(545, 185);
            buttonDong.Name = "buttonDong";
            buttonDong.Size = new Size(94, 29);
            buttonDong.TabIndex = 8;
            buttonDong.Text = "Đóng";
            buttonDong.UseVisualStyleBackColor = true;
            // 
            // buttonTaiLai
            // 
            buttonTaiLai.Location = new Point(323, 186);
            buttonTaiLai.Name = "buttonTaiLai";
            buttonTaiLai.Size = new Size(94, 28);
            buttonTaiLai.TabIndex = 7;
            buttonTaiLai.Text = "Tải lại";
            buttonTaiLai.UseVisualStyleBackColor = true;
            // 
            // buttonLoc
            // 
            buttonLoc.Location = new Point(187, 186);
            buttonLoc.Name = "buttonLoc";
            buttonLoc.Size = new Size(130, 28);
            buttonLoc.TabIndex = 6;
            buttonLoc.Text = "Lọc báo cáo";
            buttonLoc.UseVisualStyleBackColor = true;
            // 
            // comboBoxChuyenMon
            // 
            comboBoxChuyenMon.FormattingEnabled = true;
            comboBoxChuyenMon.Location = new Point(14, 151);
            comboBoxChuyenMon.Name = "comboBoxChuyenMon";
            comboBoxChuyenMon.Size = new Size(151, 28);
            comboBoxChuyenMon.TabIndex = 5;
            // 
            // labelChuyenMon
            // 
            labelChuyenMon.AutoSize = true;
            labelChuyenMon.Location = new Point(14, 119);
            labelChuyenMon.Name = "labelChuyenMon";
            labelChuyenMon.Size = new Size(91, 20);
            labelChuyenMon.TabIndex = 4;
            labelChuyenMon.Text = "Chuyên môn";
            // 
            // comboBoxNgoaiNgu
            // 
            comboBoxNgoaiNgu.FormattingEnabled = true;
            comboBoxNgoaiNgu.Location = new Point(14, 68);
            comboBoxNgoaiNgu.Name = "comboBoxNgoaiNgu";
            comboBoxNgoaiNgu.Size = new Size(151, 28);
            comboBoxNgoaiNgu.TabIndex = 1;
            // 
            // labelNgoaiNgu
            // 
            labelNgoaiNgu.AutoSize = true;
            labelNgoaiNgu.Location = new Point(14, 36);
            labelNgoaiNgu.Name = "labelNgoaiNgu";
            labelNgoaiNgu.Size = new Size(80, 20);
            labelNgoaiNgu.TabIndex = 0;
            labelNgoaiNgu.Text = "Ngoại ngữ";
            // 
            // labelDanhSach
            // 
            labelDanhSach.AutoSize = true;
            labelDanhSach.Location = new Point(12, 292);
            labelDanhSach.Name = "labelDanhSach";
            labelDanhSach.Size = new Size(177, 20);
            labelDanhSach.TabIndex = 2;
            labelDanhSach.Text = "DANH SÁCH NHÂN VIÊN";
            // 
            // dataGridViewNhanVien
            // 
            dataGridViewNhanVien.AllowUserToAddRows = false;
            dataGridViewNhanVien.AllowUserToDeleteRows = false;
            dataGridViewNhanVien.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewNhanVien.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewNhanVien.Location = new Point(12, 326);
            dataGridViewNhanVien.MultiSelect = false;
            dataGridViewNhanVien.Name = "dataGridViewNhanVien";
            dataGridViewNhanVien.ReadOnly = true;
            dataGridViewNhanVien.RowHeadersVisible = false;
            dataGridViewNhanVien.RowHeadersWidth = 51;
            dataGridViewNhanVien.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewNhanVien.Size = new Size(776, 252);
            dataGridViewNhanVien.TabIndex = 3;
            // 
            // buttonXuatExcel
            // 
            buttonXuatExcel.Location = new Point(423, 187);
            buttonXuatExcel.Name = "buttonXuatExcel";
            buttonXuatExcel.Size = new Size(116, 29);
            buttonXuatExcel.TabIndex = 9;
            buttonXuatExcel.Text = "Xuất báo cáo";
            buttonXuatExcel.UseVisualStyleBackColor = true;
            // 
            // FormBaoCaoNhanVien
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 590);
            Controls.Add(dataGridViewNhanVien);
            Controls.Add(labelDanhSach);
            Controls.Add(groupBoxDieuKien);
            Controls.Add(labelTieuDe);
            Name = "FormBaoCaoNhanVien";
            Text = "FormBaoCaoNhanVien";
            groupBoxDieuKien.ResumeLayout(false);
            groupBoxDieuKien.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewNhanVien).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelTieuDe;
        private GroupBox groupBoxDieuKien;
        private ComboBox comboBoxNgoaiNgu;
        private Label labelNgoaiNgu;
        private Button buttonDong;
        private Button buttonTaiLai;
        private Button buttonLoc;
        private ComboBox comboBoxChuyenMon;
        private Label labelChuyenMon;
        private Label labelDanhSach;
        private DataGridView dataGridViewNhanVien;
        private Button buttonXuatExcel;
    }
}