namespace QuanLyNhanSu.GUI
{
    partial class FormBaoCaoQTDT_ChuaKetThuc
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
            labelMoTa = new Label();
            buttonLoc = new Button();
            buttonTaiLai = new Button();
            buttonDong = new Button();
            labelDanhSach = new Label();
            dataGridViewQTDTChuaKetThuc = new DataGridView();
            buttonXuatExcel = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewQTDTChuaKetThuc).BeginInit();
            SuspendLayout();
            // 
            // labelTieuDe
            // 
            labelTieuDe.AutoSize = true;
            labelTieuDe.Anchor = AnchorStyles.Top;
            labelTieuDe.Location = new Point(250, 9);
            labelTieuDe.Name = "labelTieuDe";
            labelTieuDe.Size = new Size(258, 20);
            labelTieuDe.TabIndex = 0;
            labelTieuDe.Text = "BÁO CÁO ĐÀO TẠO CHƯA KẾT THÚC";
            // 
            // labelMoTa
            // 
            labelMoTa.AutoSize = true;
            labelMoTa.Location = new Point(53, 66);
            labelMoTa.Name = "labelMoTa";
            labelMoTa.Size = new Size(310, 20);
            labelMoTa.TabIndex = 1;
            labelMoTa.Text = "Danh sách các quá trình đào tạo đang diễn ra";
            // 
            // buttonLoc
            // 
            buttonLoc.Location = new Point(192, 113);
            buttonLoc.Name = "buttonLoc";
            buttonLoc.Size = new Size(131, 29);
            buttonLoc.TabIndex = 2;
            buttonLoc.Text = "Xem báo cáo";
            buttonLoc.UseVisualStyleBackColor = true;
            // 
            // buttonTaiLai
            // 
            buttonTaiLai.Location = new Point(329, 113);
            buttonTaiLai.Name = "buttonTaiLai";
            buttonTaiLai.Size = new Size(94, 29);
            buttonTaiLai.TabIndex = 3;
            buttonTaiLai.Text = "Tải lại";
            buttonTaiLai.UseVisualStyleBackColor = true;
            // 
            // buttonDong
            // 
            buttonDong.Location = new Point(553, 113);
            buttonDong.Name = "buttonDong";
            buttonDong.Size = new Size(94, 29);
            buttonDong.TabIndex = 4;
            buttonDong.Text = "Đóng";
            buttonDong.UseVisualStyleBackColor = true;
            // 
            // labelDanhSach
            // 
            labelDanhSach.AutoSize = true;
            labelDanhSach.Location = new Point(22, 181);
            labelDanhSach.Name = "labelDanhSach";
            labelDanhSach.Size = new Size(361, 20);
            labelDanhSach.TabIndex = 5;
            labelDanhSach.Text = "DANH SÁCH QUÁ TRÌNH ĐÀO TẠO CHƯA KẾT THÚC";
            // 
            // dataGridViewQTDTChuaKetThuc
            // 
            dataGridViewQTDTChuaKetThuc.AllowUserToAddRows = false;
            dataGridViewQTDTChuaKetThuc.AllowUserToDeleteRows = false;
            dataGridViewQTDTChuaKetThuc.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewQTDTChuaKetThuc.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewQTDTChuaKetThuc.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewQTDTChuaKetThuc.Location = new Point(12, 213);
            dataGridViewQTDTChuaKetThuc.MultiSelect = false;
            dataGridViewQTDTChuaKetThuc.Name = "dataGridViewQTDTChuaKetThuc";
            dataGridViewQTDTChuaKetThuc.ReadOnly = true;
            dataGridViewQTDTChuaKetThuc.RowHeadersVisible = false;
            dataGridViewQTDTChuaKetThuc.RowHeadersWidth = 51;
            dataGridViewQTDTChuaKetThuc.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewQTDTChuaKetThuc.Size = new Size(776, 265);
            dataGridViewQTDTChuaKetThuc.TabIndex = 6;
            // 
            // buttonXuatExcel
            // 
            buttonXuatExcel.Location = new Point(429, 113);
            buttonXuatExcel.Name = "buttonXuatExcel";
            buttonXuatExcel.Size = new Size(118, 29);
            buttonXuatExcel.TabIndex = 7;
            buttonXuatExcel.Text = "Xuất báo cáo";
            buttonXuatExcel.UseVisualStyleBackColor = true;
            // 
            // FormBaoCaoQTDT_ChuaKetThuc
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 490);
            Controls.Add(buttonXuatExcel);
            Controls.Add(dataGridViewQTDTChuaKetThuc);
            Controls.Add(labelDanhSach);
            Controls.Add(buttonDong);
            Controls.Add(buttonTaiLai);
            Controls.Add(buttonLoc);
            Controls.Add(labelMoTa);
            Controls.Add(labelTieuDe);
            Name = "FormBaoCaoQTDT_ChuaKetThuc";
            Text = "FormBaoCaoQTDT_ChuaKetThuc";
            ((System.ComponentModel.ISupportInitialize)dataGridViewQTDTChuaKetThuc).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelTieuDe;
        private Label labelMoTa;
        private Button buttonLoc;
        private Button buttonTaiLai;
        private Button buttonDong;
        private Label labelDanhSach;
        private DataGridView dataGridViewQTDTChuaKetThuc;
        private Button buttonXuatExcel;
    }
}