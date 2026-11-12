namespace QuanLyNhanSu.GUI
{
    partial class FormBaoCaoQTCT
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
            comboBoxPhongBan = new ComboBox();
            labelPhongBan = new Label();
            comboBoxNhanVien = new ComboBox();
            labelNhanVien = new Label();
            labelDanhSach = new Label();
            dataGridViewQTCT = new DataGridView();
            buttonXuatExcel = new Button();
            groupBoxDieuKien.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewQTCT).BeginInit();
            SuspendLayout();
            // 
            // labelTieuDe
            // 
            labelTieuDe.AutoSize = true;
            labelTieuDe.Anchor = AnchorStyles.Top;
            labelTieuDe.Location = new Point(269, 9);
            labelTieuDe.Name = "labelTieuDe";
            labelTieuDe.Size = new Size(230, 20);
            labelTieuDe.TabIndex = 0;
            labelTieuDe.Text = "BÁO CÁO QUÁ TRÌNH CÔNG TÁC";
            // 
            // groupBoxDieuKien
            // 
            groupBoxDieuKien.Controls.Add(buttonXuatExcel);
            groupBoxDieuKien.Controls.Add(buttonDong);
            groupBoxDieuKien.Controls.Add(buttonTaiLai);
            groupBoxDieuKien.Controls.Add(buttonLoc);
            groupBoxDieuKien.Controls.Add(comboBoxPhongBan);
            groupBoxDieuKien.Controls.Add(labelPhongBan);
            groupBoxDieuKien.Controls.Add(comboBoxNhanVien);
            groupBoxDieuKien.Controls.Add(labelNhanVien);
            groupBoxDieuKien.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            groupBoxDieuKien.Location = new Point(12, 52);
            groupBoxDieuKien.Name = "groupBoxDieuKien";
            groupBoxDieuKien.Size = new Size(776, 256);
            groupBoxDieuKien.TabIndex = 1;
            groupBoxDieuKien.TabStop = false;
            groupBoxDieuKien.Text = "Điều kiện báo cáo";
            // 
            // buttonDong
            // 
            buttonDong.Location = new Point(562, 213);
            buttonDong.Name = "buttonDong";
            buttonDong.Size = new Size(94, 29);
            buttonDong.TabIndex = 6;
            buttonDong.Text = "Đóng";
            buttonDong.UseVisualStyleBackColor = true;
            // 
            // buttonTaiLai
            // 
            buttonTaiLai.Location = new Point(326, 213);
            buttonTaiLai.Name = "buttonTaiLai";
            buttonTaiLai.Size = new Size(94, 29);
            buttonTaiLai.TabIndex = 5;
            buttonTaiLai.Text = "Tải lại";
            buttonTaiLai.UseVisualStyleBackColor = true;
            // 
            // buttonLoc
            // 
            buttonLoc.Location = new Point(187, 213);
            buttonLoc.Name = "buttonLoc";
            buttonLoc.Size = new Size(133, 29);
            buttonLoc.TabIndex = 4;
            buttonLoc.Text = "Lọc báo cáo";
            buttonLoc.UseVisualStyleBackColor = true;
            // 
            // comboBoxPhongBan
            // 
            comboBoxPhongBan.FormattingEnabled = true;
            comboBoxPhongBan.Location = new Point(18, 147);
            comboBoxPhongBan.Name = "comboBoxPhongBan";
            comboBoxPhongBan.Size = new Size(280, 28);
            comboBoxPhongBan.TabIndex = 3;
            // 
            // labelPhongBan
            // 
            labelPhongBan.AutoSize = true;
            labelPhongBan.Location = new Point(18, 113);
            labelPhongBan.Name = "labelPhongBan";
            labelPhongBan.Size = new Size(80, 20);
            labelPhongBan.TabIndex = 2;
            labelPhongBan.Text = "Phòng ban";
            // 
            // comboBoxNhanVien
            // 
            comboBoxNhanVien.FormattingEnabled = true;
            comboBoxNhanVien.Location = new Point(18, 65);
            comboBoxNhanVien.Name = "comboBoxNhanVien";
            comboBoxNhanVien.Size = new Size(280, 28);
            comboBoxNhanVien.TabIndex = 1;
            // 
            // labelNhanVien
            // 
            labelNhanVien.AutoSize = true;
            labelNhanVien.Location = new Point(18, 33);
            labelNhanVien.Name = "labelNhanVien";
            labelNhanVien.Size = new Size(75, 20);
            labelNhanVien.TabIndex = 0;
            labelNhanVien.Text = "Nhân viên";
            // 
            // labelDanhSach
            // 
            labelDanhSach.AutoSize = true;
            labelDanhSach.Location = new Point(12, 333);
            labelDanhSach.Name = "labelDanhSach";
            labelDanhSach.Size = new Size(251, 20);
            labelDanhSach.TabIndex = 2;
            labelDanhSach.Text = "DANH SÁCH QUÁ TRÌNH CÔNG TÁC";
            // 
            // dataGridViewQTCT
            // 
            dataGridViewQTCT.AllowUserToAddRows = false;
            dataGridViewQTCT.AllowUserToDeleteRows = false;
            dataGridViewQTCT.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewQTCT.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewQTCT.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewQTCT.Location = new Point(12, 356);
            dataGridViewQTCT.MultiSelect = false;
            dataGridViewQTCT.Name = "dataGridViewQTCT";
            dataGridViewQTCT.RowHeadersVisible = false;
            dataGridViewQTCT.RowHeadersWidth = 51;
            dataGridViewQTCT.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewQTCT.Size = new Size(776, 278);
            dataGridViewQTCT.TabIndex = 3;
            // 
            // buttonXuatExcel
            // 
            buttonXuatExcel.Location = new Point(426, 213);
            buttonXuatExcel.Name = "buttonXuatExcel";
            buttonXuatExcel.Size = new Size(130, 29);
            buttonXuatExcel.TabIndex = 7;
            buttonXuatExcel.Text = "Xuất báo cáo";
            buttonXuatExcel.UseVisualStyleBackColor = true;
            // 
            // FormBaoCaoQTCT
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 646);
            Controls.Add(dataGridViewQTCT);
            Controls.Add(labelDanhSach);
            Controls.Add(groupBoxDieuKien);
            Controls.Add(labelTieuDe);
            Name = "FormBaoCaoQTCT";
            Text = "FormBaoCaoQTCT";
            groupBoxDieuKien.ResumeLayout(false);
            groupBoxDieuKien.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewQTCT).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelTieuDe;
        private GroupBox groupBoxDieuKien;
        private Button buttonDong;
        private Button buttonTaiLai;
        private Button buttonLoc;
        private ComboBox comboBoxPhongBan;
        private Label labelPhongBan;
        private ComboBox comboBoxNhanVien;
        private Label labelNhanVien;
        private Label labelDanhSach;
        private DataGridView dataGridViewQTCT;
        private Button buttonXuatExcel;
    }
}