namespace QuanLyNhanSu.GUI
{
    partial class FormMain
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
            panelMenu = new Panel();
            panelTieuDe = new Panel();
            panelTongQuan = new Panel();
            panelNoiDung = new Panel();
            labelHeThong = new Label();
            labelTieuDe = new Label();
            buttonTongQuan = new Button();
            labelQuanLy = new Label();
            buttonDanhMuc = new Button();
            buttonNhanVien = new Button();
            buttonQTDT = new Button();
            buttonQTCT = new Button();
            buttonQuaTrinhNV = new Button();
            labelTraCuu = new Label();
            buttonTimKiemNV = new Button();
            buttonTimKiemQTDT = new Button();
            labelBaoCao = new Label();
            buttonBaoCaoNhanVien = new Button();
            buttonBaoCaoQTCT = new Button();
            buttonBaoCaoQTDT = new Button();
            buttonBaoCaoQTDTChuaKetThuc = new Button();
            panelTheQuanLy = new Panel();
            panelTheTraCuu = new Panel();
            panelTheBaoCao = new Panel();
            labelSoQuanLy = new Label();
            labelSoTraCuu = new Label();
            labelSoBaoCao = new Label();
            labelNhanQuanLy = new Label();
            labelNhanTraCuu = new Label();
            labelNhanBaoCao = new Label();
            labelChaoMung = new Label();
            labelMoTa = new Label();
            labelLoiTat = new Label();
            flowLayoutPanelLoiTat = new FlowLayoutPanel();
            buttonLoiTatNhanVien = new Button();
            buttonLoiTatDanhMuc = new Button();
            buttonLoiTatQTDT = new Button();
            buttonLoiTatQTCT = new Button();
            buttonLoiTatTimKiemNV = new Button();
            buttonLoiTatTimKiemQTDT = new Button();
            buttonLoiTatBaoCaoNhanVien = new Button();
            buttonLoiTatBaoCaoQTDT = new Button();
            panelMenu.SuspendLayout();
            panelTieuDe.SuspendLayout();
            panelTongQuan.SuspendLayout();
            panelTheQuanLy.SuspendLayout();
            panelTheTraCuu.SuspendLayout();
            panelTheBaoCao.SuspendLayout();
            flowLayoutPanelLoiTat.SuspendLayout();
            SuspendLayout();
            // 
            // panelMenu
            // 
            panelMenu.BackColor = Color.FromArgb(30, 41, 59);
            panelMenu.Controls.Add(buttonBaoCaoQTDTChuaKetThuc);
            panelMenu.Controls.Add(buttonBaoCaoQTDT);
            panelMenu.Controls.Add(buttonBaoCaoQTCT);
            panelMenu.Controls.Add(buttonBaoCaoNhanVien);
            panelMenu.Controls.Add(labelBaoCao);
            panelMenu.Controls.Add(buttonTimKiemQTDT);
            panelMenu.Controls.Add(buttonTimKiemNV);
            panelMenu.Controls.Add(labelTraCuu);
            panelMenu.Controls.Add(buttonQuaTrinhNV);
            panelMenu.Controls.Add(buttonQTCT);
            panelMenu.Controls.Add(buttonQTDT);
            panelMenu.Controls.Add(buttonNhanVien);
            panelMenu.Controls.Add(buttonDanhMuc);
            panelMenu.Controls.Add(labelQuanLy);
            panelMenu.Controls.Add(buttonTongQuan);
            panelMenu.Dock = DockStyle.Left;
            panelMenu.Location = new Point(0, 0);
            panelMenu.Name = "panelMenu";
            panelMenu.Padding = new Padding(0, 10, 0, 0);
            panelMenu.Size = new Size(260, 720);
            panelMenu.TabIndex = 0;
            // 
            // buttonTongQuan
            // 
            buttonTongQuan.BackColor = Color.FromArgb(30, 41, 59);
            buttonTongQuan.Cursor = Cursors.Hand;
            buttonTongQuan.Dock = DockStyle.Top;
            buttonTongQuan.FlatAppearance.BorderSize = 0;
            buttonTongQuan.FlatAppearance.MouseOverBackColor = Color.FromArgb(51, 65, 85);
            buttonTongQuan.FlatStyle = FlatStyle.Flat;
            buttonTongQuan.Font = new Font("Segoe UI", 10F);
            buttonTongQuan.ForeColor = Color.White;
            buttonTongQuan.Name = "buttonTongQuan";
            buttonTongQuan.Padding = new Padding(24, 0, 0, 0);
            buttonTongQuan.Size = new Size(260, 40);
            buttonTongQuan.TabIndex = 0;
            buttonTongQuan.Text = "Tổng quan";
            buttonTongQuan.TextAlign = ContentAlignment.MiddleLeft;
            buttonTongQuan.UseVisualStyleBackColor = false;
            buttonTongQuan.Click += buttonTongQuan_Click;
            // 
            // labelQuanLy
            // 
            labelQuanLy.AutoSize = false;
            labelQuanLy.Dock = DockStyle.Top;
            labelQuanLy.Font = new Font("Segoe UI", 8.5F, FontStyle.Bold);
            labelQuanLy.ForeColor = Color.FromArgb(148, 163, 184);
            labelQuanLy.Name = "labelQuanLy";
            labelQuanLy.Padding = new Padding(24, 0, 0, 4);
            labelQuanLy.Size = new Size(260, 36);
            labelQuanLy.Text = "QUẢN LÝ";
            labelQuanLy.TextAlign = ContentAlignment.BottomLeft;
            // 
            // buttonDanhMuc
            // 
            buttonDanhMuc.BackColor = Color.FromArgb(30, 41, 59);
            buttonDanhMuc.Cursor = Cursors.Hand;
            buttonDanhMuc.Dock = DockStyle.Top;
            buttonDanhMuc.FlatAppearance.BorderSize = 0;
            buttonDanhMuc.FlatAppearance.MouseOverBackColor = Color.FromArgb(51, 65, 85);
            buttonDanhMuc.FlatStyle = FlatStyle.Flat;
            buttonDanhMuc.Font = new Font("Segoe UI", 10F);
            buttonDanhMuc.ForeColor = Color.White;
            buttonDanhMuc.Name = "buttonDanhMuc";
            buttonDanhMuc.Padding = new Padding(24, 0, 0, 0);
            buttonDanhMuc.Size = new Size(260, 40);
            buttonDanhMuc.TabIndex = 1;
            buttonDanhMuc.Text = "Quản lý danh mục";
            buttonDanhMuc.TextAlign = ContentAlignment.MiddleLeft;
            buttonDanhMuc.UseVisualStyleBackColor = false;
            buttonDanhMuc.Click += buttonDanhMuc_Click;
            // 
            // buttonNhanVien
            // 
            buttonNhanVien.BackColor = Color.FromArgb(30, 41, 59);
            buttonNhanVien.Cursor = Cursors.Hand;
            buttonNhanVien.Dock = DockStyle.Top;
            buttonNhanVien.FlatAppearance.BorderSize = 0;
            buttonNhanVien.FlatAppearance.MouseOverBackColor = Color.FromArgb(51, 65, 85);
            buttonNhanVien.FlatStyle = FlatStyle.Flat;
            buttonNhanVien.Font = new Font("Segoe UI", 10F);
            buttonNhanVien.ForeColor = Color.White;
            buttonNhanVien.Name = "buttonNhanVien";
            buttonNhanVien.Padding = new Padding(24, 0, 0, 0);
            buttonNhanVien.Size = new Size(260, 40);
            buttonNhanVien.TabIndex = 2;
            buttonNhanVien.Text = "Quản lý hồ sơ nhân viên";
            buttonNhanVien.TextAlign = ContentAlignment.MiddleLeft;
            buttonNhanVien.UseVisualStyleBackColor = false;
            buttonNhanVien.Click += buttonNhanVien_Click;
            // 
            // buttonQTDT
            // 
            buttonQTDT.BackColor = Color.FromArgb(30, 41, 59);
            buttonQTDT.Cursor = Cursors.Hand;
            buttonQTDT.Dock = DockStyle.Top;
            buttonQTDT.FlatAppearance.BorderSize = 0;
            buttonQTDT.FlatAppearance.MouseOverBackColor = Color.FromArgb(51, 65, 85);
            buttonQTDT.FlatStyle = FlatStyle.Flat;
            buttonQTDT.Font = new Font("Segoe UI", 10F);
            buttonQTDT.ForeColor = Color.White;
            buttonQTDT.Name = "buttonQTDT";
            buttonQTDT.Padding = new Padding(24, 0, 0, 0);
            buttonQTDT.Size = new Size(260, 40);
            buttonQTDT.TabIndex = 3;
            buttonQTDT.Text = "Quá trình đào tạo";
            buttonQTDT.TextAlign = ContentAlignment.MiddleLeft;
            buttonQTDT.UseVisualStyleBackColor = false;
            buttonQTDT.Click += buttonQTDT_Click;
            // 
            // buttonQTCT
            // 
            buttonQTCT.BackColor = Color.FromArgb(30, 41, 59);
            buttonQTCT.Cursor = Cursors.Hand;
            buttonQTCT.Dock = DockStyle.Top;
            buttonQTCT.FlatAppearance.BorderSize = 0;
            buttonQTCT.FlatAppearance.MouseOverBackColor = Color.FromArgb(51, 65, 85);
            buttonQTCT.FlatStyle = FlatStyle.Flat;
            buttonQTCT.Font = new Font("Segoe UI", 10F);
            buttonQTCT.ForeColor = Color.White;
            buttonQTCT.Name = "buttonQTCT";
            buttonQTCT.Padding = new Padding(24, 0, 0, 0);
            buttonQTCT.Size = new Size(260, 40);
            buttonQTCT.TabIndex = 4;
            buttonQTCT.Text = "Quá trình công tác";
            buttonQTCT.TextAlign = ContentAlignment.MiddleLeft;
            buttonQTCT.UseVisualStyleBackColor = false;
            buttonQTCT.Click += buttonQTCT_Click;
            // 
            // buttonQuaTrinhNV
            // 
            buttonQuaTrinhNV.BackColor = Color.FromArgb(30, 41, 59);
            buttonQuaTrinhNV.Cursor = Cursors.Hand;
            buttonQuaTrinhNV.Dock = DockStyle.Top;
            buttonQuaTrinhNV.FlatAppearance.BorderSize = 0;
            buttonQuaTrinhNV.FlatAppearance.MouseOverBackColor = Color.FromArgb(51, 65, 85);
            buttonQuaTrinhNV.FlatStyle = FlatStyle.Flat;
            buttonQuaTrinhNV.Font = new Font("Segoe UI", 10F);
            buttonQuaTrinhNV.ForeColor = Color.White;
            buttonQuaTrinhNV.Name = "buttonQuaTrinhNV";
            buttonQuaTrinhNV.Padding = new Padding(24, 0, 0, 0);
            buttonQuaTrinhNV.Size = new Size(260, 40);
            buttonQuaTrinhNV.TabIndex = 5;
            buttonQuaTrinhNV.Text = "Quá trình của nhân viên";
            buttonQuaTrinhNV.TextAlign = ContentAlignment.MiddleLeft;
            buttonQuaTrinhNV.UseVisualStyleBackColor = false;
            buttonQuaTrinhNV.Click += buttonQuaTrinhNV_Click;
            // 
            // labelTraCuu
            // 
            labelTraCuu.AutoSize = false;
            labelTraCuu.Dock = DockStyle.Top;
            labelTraCuu.Font = new Font("Segoe UI", 8.5F, FontStyle.Bold);
            labelTraCuu.ForeColor = Color.FromArgb(148, 163, 184);
            labelTraCuu.Name = "labelTraCuu";
            labelTraCuu.Padding = new Padding(24, 0, 0, 4);
            labelTraCuu.Size = new Size(260, 36);
            labelTraCuu.Text = "TRA CỨU";
            labelTraCuu.TextAlign = ContentAlignment.BottomLeft;
            // 
            // buttonTimKiemNV
            // 
            buttonTimKiemNV.BackColor = Color.FromArgb(30, 41, 59);
            buttonTimKiemNV.Cursor = Cursors.Hand;
            buttonTimKiemNV.Dock = DockStyle.Top;
            buttonTimKiemNV.FlatAppearance.BorderSize = 0;
            buttonTimKiemNV.FlatAppearance.MouseOverBackColor = Color.FromArgb(51, 65, 85);
            buttonTimKiemNV.FlatStyle = FlatStyle.Flat;
            buttonTimKiemNV.Font = new Font("Segoe UI", 10F);
            buttonTimKiemNV.ForeColor = Color.White;
            buttonTimKiemNV.Name = "buttonTimKiemNV";
            buttonTimKiemNV.Padding = new Padding(24, 0, 0, 0);
            buttonTimKiemNV.Size = new Size(260, 40);
            buttonTimKiemNV.TabIndex = 6;
            buttonTimKiemNV.Text = "Tìm kiếm nhân viên";
            buttonTimKiemNV.TextAlign = ContentAlignment.MiddleLeft;
            buttonTimKiemNV.UseVisualStyleBackColor = false;
            buttonTimKiemNV.Click += buttonTimKiemNV_Click;
            // 
            // buttonTimKiemQTDT
            // 
            buttonTimKiemQTDT.BackColor = Color.FromArgb(30, 41, 59);
            buttonTimKiemQTDT.Cursor = Cursors.Hand;
            buttonTimKiemQTDT.Dock = DockStyle.Top;
            buttonTimKiemQTDT.FlatAppearance.BorderSize = 0;
            buttonTimKiemQTDT.FlatAppearance.MouseOverBackColor = Color.FromArgb(51, 65, 85);
            buttonTimKiemQTDT.FlatStyle = FlatStyle.Flat;
            buttonTimKiemQTDT.Font = new Font("Segoe UI", 10F);
            buttonTimKiemQTDT.ForeColor = Color.White;
            buttonTimKiemQTDT.Name = "buttonTimKiemQTDT";
            buttonTimKiemQTDT.Padding = new Padding(24, 0, 0, 0);
            buttonTimKiemQTDT.Size = new Size(260, 40);
            buttonTimKiemQTDT.TabIndex = 7;
            buttonTimKiemQTDT.Text = "Tìm kiếm quá trình đào tạo";
            buttonTimKiemQTDT.TextAlign = ContentAlignment.MiddleLeft;
            buttonTimKiemQTDT.UseVisualStyleBackColor = false;
            buttonTimKiemQTDT.Click += buttonTimKiemQTDT_Click;
            // 
            // labelBaoCao
            // 
            labelBaoCao.AutoSize = false;
            labelBaoCao.Dock = DockStyle.Top;
            labelBaoCao.Font = new Font("Segoe UI", 8.5F, FontStyle.Bold);
            labelBaoCao.ForeColor = Color.FromArgb(148, 163, 184);
            labelBaoCao.Name = "labelBaoCao";
            labelBaoCao.Padding = new Padding(24, 0, 0, 4);
            labelBaoCao.Size = new Size(260, 36);
            labelBaoCao.Text = "BÁO CÁO";
            labelBaoCao.TextAlign = ContentAlignment.BottomLeft;
            // 
            // buttonBaoCaoNhanVien
            // 
            buttonBaoCaoNhanVien.BackColor = Color.FromArgb(30, 41, 59);
            buttonBaoCaoNhanVien.Cursor = Cursors.Hand;
            buttonBaoCaoNhanVien.Dock = DockStyle.Top;
            buttonBaoCaoNhanVien.FlatAppearance.BorderSize = 0;
            buttonBaoCaoNhanVien.FlatAppearance.MouseOverBackColor = Color.FromArgb(51, 65, 85);
            buttonBaoCaoNhanVien.FlatStyle = FlatStyle.Flat;
            buttonBaoCaoNhanVien.Font = new Font("Segoe UI", 10F);
            buttonBaoCaoNhanVien.ForeColor = Color.White;
            buttonBaoCaoNhanVien.Name = "buttonBaoCaoNhanVien";
            buttonBaoCaoNhanVien.Padding = new Padding(24, 0, 0, 0);
            buttonBaoCaoNhanVien.Size = new Size(260, 40);
            buttonBaoCaoNhanVien.TabIndex = 8;
            buttonBaoCaoNhanVien.Text = "Báo cáo nhân viên";
            buttonBaoCaoNhanVien.TextAlign = ContentAlignment.MiddleLeft;
            buttonBaoCaoNhanVien.UseVisualStyleBackColor = false;
            buttonBaoCaoNhanVien.Click += buttonBaoCaoNhanVien_Click;
            // 
            // buttonBaoCaoQTCT
            // 
            buttonBaoCaoQTCT.BackColor = Color.FromArgb(30, 41, 59);
            buttonBaoCaoQTCT.Cursor = Cursors.Hand;
            buttonBaoCaoQTCT.Dock = DockStyle.Top;
            buttonBaoCaoQTCT.FlatAppearance.BorderSize = 0;
            buttonBaoCaoQTCT.FlatAppearance.MouseOverBackColor = Color.FromArgb(51, 65, 85);
            buttonBaoCaoQTCT.FlatStyle = FlatStyle.Flat;
            buttonBaoCaoQTCT.Font = new Font("Segoe UI", 10F);
            buttonBaoCaoQTCT.ForeColor = Color.White;
            buttonBaoCaoQTCT.Name = "buttonBaoCaoQTCT";
            buttonBaoCaoQTCT.Padding = new Padding(24, 0, 0, 0);
            buttonBaoCaoQTCT.Size = new Size(260, 40);
            buttonBaoCaoQTCT.TabIndex = 9;
            buttonBaoCaoQTCT.Text = "Báo cáo quá trình công tác";
            buttonBaoCaoQTCT.TextAlign = ContentAlignment.MiddleLeft;
            buttonBaoCaoQTCT.UseVisualStyleBackColor = false;
            buttonBaoCaoQTCT.Click += buttonBaoCaoQTCT_Click;
            // 
            // buttonBaoCaoQTDT
            // 
            buttonBaoCaoQTDT.BackColor = Color.FromArgb(30, 41, 59);
            buttonBaoCaoQTDT.Cursor = Cursors.Hand;
            buttonBaoCaoQTDT.Dock = DockStyle.Top;
            buttonBaoCaoQTDT.FlatAppearance.BorderSize = 0;
            buttonBaoCaoQTDT.FlatAppearance.MouseOverBackColor = Color.FromArgb(51, 65, 85);
            buttonBaoCaoQTDT.FlatStyle = FlatStyle.Flat;
            buttonBaoCaoQTDT.Font = new Font("Segoe UI", 10F);
            buttonBaoCaoQTDT.ForeColor = Color.White;
            buttonBaoCaoQTDT.Name = "buttonBaoCaoQTDT";
            buttonBaoCaoQTDT.Padding = new Padding(24, 0, 0, 0);
            buttonBaoCaoQTDT.Size = new Size(260, 40);
            buttonBaoCaoQTDT.TabIndex = 10;
            buttonBaoCaoQTDT.Text = "Báo cáo quá trình đào tạo";
            buttonBaoCaoQTDT.TextAlign = ContentAlignment.MiddleLeft;
            buttonBaoCaoQTDT.UseVisualStyleBackColor = false;
            buttonBaoCaoQTDT.Click += buttonBaoCaoQTDT_Click;
            // 
            // buttonBaoCaoQTDTChuaKetThuc
            // 
            buttonBaoCaoQTDTChuaKetThuc.BackColor = Color.FromArgb(30, 41, 59);
            buttonBaoCaoQTDTChuaKetThuc.Cursor = Cursors.Hand;
            buttonBaoCaoQTDTChuaKetThuc.Dock = DockStyle.Top;
            buttonBaoCaoQTDTChuaKetThuc.FlatAppearance.BorderSize = 0;
            buttonBaoCaoQTDTChuaKetThuc.FlatAppearance.MouseOverBackColor = Color.FromArgb(51, 65, 85);
            buttonBaoCaoQTDTChuaKetThuc.FlatStyle = FlatStyle.Flat;
            buttonBaoCaoQTDTChuaKetThuc.Font = new Font("Segoe UI", 10F);
            buttonBaoCaoQTDTChuaKetThuc.ForeColor = Color.White;
            buttonBaoCaoQTDTChuaKetThuc.Name = "buttonBaoCaoQTDTChuaKetThuc";
            buttonBaoCaoQTDTChuaKetThuc.Padding = new Padding(24, 0, 0, 0);
            buttonBaoCaoQTDTChuaKetThuc.Size = new Size(260, 40);
            buttonBaoCaoQTDTChuaKetThuc.TabIndex = 11;
            buttonBaoCaoQTDTChuaKetThuc.Text = "Báo cáo đào tạo chưa kết thúc";
            buttonBaoCaoQTDTChuaKetThuc.TextAlign = ContentAlignment.MiddleLeft;
            buttonBaoCaoQTDTChuaKetThuc.UseVisualStyleBackColor = false;
            buttonBaoCaoQTDTChuaKetThuc.Click += buttonBaoCaoQTDTChuaKetThuc_Click;
            // 
            // panelTieuDe
            // 
            panelTieuDe.BackColor = Color.White;
            panelTieuDe.Controls.Add(labelTieuDe);
            panelTieuDe.Controls.Add(labelHeThong);
            panelTieuDe.Dock = DockStyle.Top;
            panelTieuDe.Location = new Point(260, 0);
            panelTieuDe.Name = "panelTieuDe";
            panelTieuDe.Size = new Size(1020, 76);
            panelTieuDe.TabIndex = 1;
            // 
            // labelHeThong
            // 
            labelHeThong.AutoSize = true;
            labelHeThong.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            labelHeThong.ForeColor = Color.FromArgb(100, 116, 139);
            labelHeThong.Location = new Point(28, 10);
            labelHeThong.Name = "labelHeThong";
            labelHeThong.Text = "HỆ THỐNG QUẢN LÝ NHÂN SỰ";
            // 
            // labelTieuDe
            // 
            labelTieuDe.AutoSize = true;
            labelTieuDe.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            labelTieuDe.ForeColor = Color.FromArgb(15, 23, 42);
            labelTieuDe.Location = new Point(26, 30);
            labelTieuDe.Name = "labelTieuDe";
            labelTieuDe.Text = "Tổng quan";
            // 
            // panelTongQuan
            // 
            panelTongQuan.BackColor = Color.FromArgb(241, 245, 249);
            panelTongQuan.Controls.Add(flowLayoutPanelLoiTat);
            panelTongQuan.Controls.Add(labelLoiTat);
            panelTongQuan.Controls.Add(panelTheBaoCao);
            panelTongQuan.Controls.Add(panelTheTraCuu);
            panelTongQuan.Controls.Add(panelTheQuanLy);
            panelTongQuan.Controls.Add(labelMoTa);
            panelTongQuan.Controls.Add(labelChaoMung);
            panelTongQuan.Dock = DockStyle.Fill;
            panelTongQuan.Location = new Point(260, 76);
            panelTongQuan.Name = "panelTongQuan";
            panelTongQuan.Size = new Size(1020, 644);
            panelTongQuan.TabIndex = 2;
            // 
            // labelChaoMung
            // 
            labelChaoMung.AutoSize = true;
            labelChaoMung.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            labelChaoMung.ForeColor = Color.FromArgb(15, 23, 42);
            labelChaoMung.Location = new Point(30, 26);
            labelChaoMung.Name = "labelChaoMung";
            labelChaoMung.Text = "Chào mừng đến với Hệ thống Quản lý Nhân sự";
            // 
            // labelMoTa
            // 
            labelMoTa.AutoSize = true;
            labelMoTa.Font = new Font("Segoe UI", 10.5F);
            labelMoTa.ForeColor = Color.FromArgb(71, 85, 105);
            labelMoTa.Location = new Point(33, 78);
            labelMoTa.Name = "labelMoTa";
            labelMoTa.Text = "Chọn một chức năng ở menu bên trái hoặc dùng các lối tắt bên dưới để bắt đầu.";
            // 
            // panelTheQuanLy
            // 
            panelTheQuanLy.BackColor = Color.White;
            panelTheQuanLy.Controls.Add(labelNhanQuanLy);
            panelTheQuanLy.Controls.Add(labelSoQuanLy);
            panelTheQuanLy.Location = new Point(33, 130);
            panelTheQuanLy.Name = "panelTheQuanLy";
            panelTheQuanLy.Size = new Size(230, 92);
            panelTheQuanLy.TabIndex = 3;
            // 
            // labelSoQuanLy
            // 
            labelSoQuanLy.AutoSize = true;
            labelSoQuanLy.Font = new Font("Segoe UI", 24F, FontStyle.Bold);
            labelSoQuanLy.ForeColor = Color.FromArgb(37, 99, 235);
            labelSoQuanLy.Location = new Point(16, 8);
            labelSoQuanLy.Name = "labelSoQuanLy";
            labelSoQuanLy.Text = "5";
            // 
            // labelNhanQuanLy
            // 
            labelNhanQuanLy.AutoSize = true;
            labelNhanQuanLy.Font = new Font("Segoe UI", 10F);
            labelNhanQuanLy.ForeColor = Color.FromArgb(100, 116, 139);
            labelNhanQuanLy.Location = new Point(19, 62);
            labelNhanQuanLy.Name = "labelNhanQuanLy";
            labelNhanQuanLy.Text = "Chức năng quản lý";
            // 
            // panelTheTraCuu
            // 
            panelTheTraCuu.BackColor = Color.White;
            panelTheTraCuu.Controls.Add(labelNhanTraCuu);
            panelTheTraCuu.Controls.Add(labelSoTraCuu);
            panelTheTraCuu.Location = new Point(283, 130);
            panelTheTraCuu.Name = "panelTheTraCuu";
            panelTheTraCuu.Size = new Size(230, 92);
            panelTheTraCuu.TabIndex = 4;
            // 
            // labelSoTraCuu
            // 
            labelSoTraCuu.AutoSize = true;
            labelSoTraCuu.Font = new Font("Segoe UI", 24F, FontStyle.Bold);
            labelSoTraCuu.ForeColor = Color.FromArgb(37, 99, 235);
            labelSoTraCuu.Location = new Point(16, 8);
            labelSoTraCuu.Name = "labelSoTraCuu";
            labelSoTraCuu.Text = "2";
            // 
            // labelNhanTraCuu
            // 
            labelNhanTraCuu.AutoSize = true;
            labelNhanTraCuu.Font = new Font("Segoe UI", 10F);
            labelNhanTraCuu.ForeColor = Color.FromArgb(100, 116, 139);
            labelNhanTraCuu.Location = new Point(19, 62);
            labelNhanTraCuu.Name = "labelNhanTraCuu";
            labelNhanTraCuu.Text = "Chức năng tra cứu";
            // 
            // panelTheBaoCao
            // 
            panelTheBaoCao.BackColor = Color.White;
            panelTheBaoCao.Controls.Add(labelNhanBaoCao);
            panelTheBaoCao.Controls.Add(labelSoBaoCao);
            panelTheBaoCao.Location = new Point(533, 130);
            panelTheBaoCao.Name = "panelTheBaoCao";
            panelTheBaoCao.Size = new Size(230, 92);
            panelTheBaoCao.TabIndex = 5;
            // 
            // labelSoBaoCao
            // 
            labelSoBaoCao.AutoSize = true;
            labelSoBaoCao.Font = new Font("Segoe UI", 24F, FontStyle.Bold);
            labelSoBaoCao.ForeColor = Color.FromArgb(37, 99, 235);
            labelSoBaoCao.Location = new Point(16, 8);
            labelSoBaoCao.Name = "labelSoBaoCao";
            labelSoBaoCao.Text = "4";
            // 
            // labelNhanBaoCao
            // 
            labelNhanBaoCao.AutoSize = true;
            labelNhanBaoCao.Font = new Font("Segoe UI", 10F);
            labelNhanBaoCao.ForeColor = Color.FromArgb(100, 116, 139);
            labelNhanBaoCao.Location = new Point(19, 62);
            labelNhanBaoCao.Name = "labelNhanBaoCao";
            labelNhanBaoCao.Text = "Báo cáo";
            // 
            // labelLoiTat
            // 
            labelLoiTat.AutoSize = true;
            labelLoiTat.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            labelLoiTat.ForeColor = Color.FromArgb(15, 23, 42);
            labelLoiTat.Location = new Point(31, 254);
            labelLoiTat.Name = "labelLoiTat";
            labelLoiTat.Text = "Lối tắt";
            // 
            // flowLayoutPanelLoiTat
            // 
            flowLayoutPanelLoiTat.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            flowLayoutPanelLoiTat.Controls.Add(buttonLoiTatNhanVien);
            flowLayoutPanelLoiTat.Controls.Add(buttonLoiTatDanhMuc);
            flowLayoutPanelLoiTat.Controls.Add(buttonLoiTatQTDT);
            flowLayoutPanelLoiTat.Controls.Add(buttonLoiTatQTCT);
            flowLayoutPanelLoiTat.Controls.Add(buttonLoiTatTimKiemNV);
            flowLayoutPanelLoiTat.Controls.Add(buttonLoiTatTimKiemQTDT);
            flowLayoutPanelLoiTat.Controls.Add(buttonLoiTatBaoCaoNhanVien);
            flowLayoutPanelLoiTat.Controls.Add(buttonLoiTatBaoCaoQTDT);
            flowLayoutPanelLoiTat.Location = new Point(33, 292);
            flowLayoutPanelLoiTat.Name = "flowLayoutPanelLoiTat";
            flowLayoutPanelLoiTat.Size = new Size(954, 200);
            flowLayoutPanelLoiTat.TabIndex = 6;
            // 
            // buttonLoiTatNhanVien
            // 
            buttonLoiTatNhanVien.BackColor = Color.White;
            buttonLoiTatNhanVien.Cursor = Cursors.Hand;
            buttonLoiTatNhanVien.FlatAppearance.BorderColor = Color.FromArgb(226, 232, 240);
            buttonLoiTatNhanVien.FlatAppearance.MouseOverBackColor = Color.FromArgb(219, 234, 254);
            buttonLoiTatNhanVien.FlatStyle = FlatStyle.Flat;
            buttonLoiTatNhanVien.Font = new Font("Segoe UI", 10.5F, FontStyle.Bold);
            buttonLoiTatNhanVien.ForeColor = Color.FromArgb(30, 41, 59);
            buttonLoiTatNhanVien.Margin = new Padding(0, 0, 16, 16);
            buttonLoiTatNhanVien.Name = "buttonLoiTatNhanVien";
            buttonLoiTatNhanVien.Size = new Size(222, 80);
            buttonLoiTatNhanVien.TabIndex = 0;
            buttonLoiTatNhanVien.Text = "Hồ sơ nhân viên";
            buttonLoiTatNhanVien.UseVisualStyleBackColor = false;
            buttonLoiTatNhanVien.Click += buttonNhanVien_Click;
            // 
            // buttonLoiTatDanhMuc
            // 
            buttonLoiTatDanhMuc.BackColor = Color.White;
            buttonLoiTatDanhMuc.Cursor = Cursors.Hand;
            buttonLoiTatDanhMuc.FlatAppearance.BorderColor = Color.FromArgb(226, 232, 240);
            buttonLoiTatDanhMuc.FlatAppearance.MouseOverBackColor = Color.FromArgb(219, 234, 254);
            buttonLoiTatDanhMuc.FlatStyle = FlatStyle.Flat;
            buttonLoiTatDanhMuc.Font = new Font("Segoe UI", 10.5F, FontStyle.Bold);
            buttonLoiTatDanhMuc.ForeColor = Color.FromArgb(30, 41, 59);
            buttonLoiTatDanhMuc.Margin = new Padding(0, 0, 16, 16);
            buttonLoiTatDanhMuc.Name = "buttonLoiTatDanhMuc";
            buttonLoiTatDanhMuc.Size = new Size(222, 80);
            buttonLoiTatDanhMuc.TabIndex = 1;
            buttonLoiTatDanhMuc.Text = "Danh mục";
            buttonLoiTatDanhMuc.UseVisualStyleBackColor = false;
            buttonLoiTatDanhMuc.Click += buttonDanhMuc_Click;
            // 
            // buttonLoiTatQTDT
            // 
            buttonLoiTatQTDT.BackColor = Color.White;
            buttonLoiTatQTDT.Cursor = Cursors.Hand;
            buttonLoiTatQTDT.FlatAppearance.BorderColor = Color.FromArgb(226, 232, 240);
            buttonLoiTatQTDT.FlatAppearance.MouseOverBackColor = Color.FromArgb(219, 234, 254);
            buttonLoiTatQTDT.FlatStyle = FlatStyle.Flat;
            buttonLoiTatQTDT.Font = new Font("Segoe UI", 10.5F, FontStyle.Bold);
            buttonLoiTatQTDT.ForeColor = Color.FromArgb(30, 41, 59);
            buttonLoiTatQTDT.Margin = new Padding(0, 0, 16, 16);
            buttonLoiTatQTDT.Name = "buttonLoiTatQTDT";
            buttonLoiTatQTDT.Size = new Size(222, 80);
            buttonLoiTatQTDT.TabIndex = 2;
            buttonLoiTatQTDT.Text = "Quá trình đào tạo";
            buttonLoiTatQTDT.UseVisualStyleBackColor = false;
            buttonLoiTatQTDT.Click += buttonQTDT_Click;
            // 
            // buttonLoiTatQTCT
            // 
            buttonLoiTatQTCT.BackColor = Color.White;
            buttonLoiTatQTCT.Cursor = Cursors.Hand;
            buttonLoiTatQTCT.FlatAppearance.BorderColor = Color.FromArgb(226, 232, 240);
            buttonLoiTatQTCT.FlatAppearance.MouseOverBackColor = Color.FromArgb(219, 234, 254);
            buttonLoiTatQTCT.FlatStyle = FlatStyle.Flat;
            buttonLoiTatQTCT.Font = new Font("Segoe UI", 10.5F, FontStyle.Bold);
            buttonLoiTatQTCT.ForeColor = Color.FromArgb(30, 41, 59);
            buttonLoiTatQTCT.Margin = new Padding(0, 0, 16, 16);
            buttonLoiTatQTCT.Name = "buttonLoiTatQTCT";
            buttonLoiTatQTCT.Size = new Size(222, 80);
            buttonLoiTatQTCT.TabIndex = 3;
            buttonLoiTatQTCT.Text = "Quá trình công tác";
            buttonLoiTatQTCT.UseVisualStyleBackColor = false;
            buttonLoiTatQTCT.Click += buttonQTCT_Click;
            // 
            // buttonLoiTatTimKiemNV
            // 
            buttonLoiTatTimKiemNV.BackColor = Color.White;
            buttonLoiTatTimKiemNV.Cursor = Cursors.Hand;
            buttonLoiTatTimKiemNV.FlatAppearance.BorderColor = Color.FromArgb(226, 232, 240);
            buttonLoiTatTimKiemNV.FlatAppearance.MouseOverBackColor = Color.FromArgb(219, 234, 254);
            buttonLoiTatTimKiemNV.FlatStyle = FlatStyle.Flat;
            buttonLoiTatTimKiemNV.Font = new Font("Segoe UI", 10.5F, FontStyle.Bold);
            buttonLoiTatTimKiemNV.ForeColor = Color.FromArgb(30, 41, 59);
            buttonLoiTatTimKiemNV.Margin = new Padding(0, 0, 16, 16);
            buttonLoiTatTimKiemNV.Name = "buttonLoiTatTimKiemNV";
            buttonLoiTatTimKiemNV.Size = new Size(222, 80);
            buttonLoiTatTimKiemNV.TabIndex = 4;
            buttonLoiTatTimKiemNV.Text = "Tìm kiếm nhân viên";
            buttonLoiTatTimKiemNV.UseVisualStyleBackColor = false;
            buttonLoiTatTimKiemNV.Click += buttonTimKiemNV_Click;
            // 
            // buttonLoiTatTimKiemQTDT
            // 
            buttonLoiTatTimKiemQTDT.BackColor = Color.White;
            buttonLoiTatTimKiemQTDT.Cursor = Cursors.Hand;
            buttonLoiTatTimKiemQTDT.FlatAppearance.BorderColor = Color.FromArgb(226, 232, 240);
            buttonLoiTatTimKiemQTDT.FlatAppearance.MouseOverBackColor = Color.FromArgb(219, 234, 254);
            buttonLoiTatTimKiemQTDT.FlatStyle = FlatStyle.Flat;
            buttonLoiTatTimKiemQTDT.Font = new Font("Segoe UI", 10.5F, FontStyle.Bold);
            buttonLoiTatTimKiemQTDT.ForeColor = Color.FromArgb(30, 41, 59);
            buttonLoiTatTimKiemQTDT.Margin = new Padding(0, 0, 16, 16);
            buttonLoiTatTimKiemQTDT.Name = "buttonLoiTatTimKiemQTDT";
            buttonLoiTatTimKiemQTDT.Size = new Size(222, 80);
            buttonLoiTatTimKiemQTDT.TabIndex = 5;
            buttonLoiTatTimKiemQTDT.Text = "Tìm kiếm đào tạo";
            buttonLoiTatTimKiemQTDT.UseVisualStyleBackColor = false;
            buttonLoiTatTimKiemQTDT.Click += buttonTimKiemQTDT_Click;
            // 
            // buttonLoiTatBaoCaoNhanVien
            // 
            buttonLoiTatBaoCaoNhanVien.BackColor = Color.White;
            buttonLoiTatBaoCaoNhanVien.Cursor = Cursors.Hand;
            buttonLoiTatBaoCaoNhanVien.FlatAppearance.BorderColor = Color.FromArgb(226, 232, 240);
            buttonLoiTatBaoCaoNhanVien.FlatAppearance.MouseOverBackColor = Color.FromArgb(219, 234, 254);
            buttonLoiTatBaoCaoNhanVien.FlatStyle = FlatStyle.Flat;
            buttonLoiTatBaoCaoNhanVien.Font = new Font("Segoe UI", 10.5F, FontStyle.Bold);
            buttonLoiTatBaoCaoNhanVien.ForeColor = Color.FromArgb(30, 41, 59);
            buttonLoiTatBaoCaoNhanVien.Margin = new Padding(0, 0, 16, 16);
            buttonLoiTatBaoCaoNhanVien.Name = "buttonLoiTatBaoCaoNhanVien";
            buttonLoiTatBaoCaoNhanVien.Size = new Size(222, 80);
            buttonLoiTatBaoCaoNhanVien.TabIndex = 6;
            buttonLoiTatBaoCaoNhanVien.Text = "Báo cáo nhân viên";
            buttonLoiTatBaoCaoNhanVien.UseVisualStyleBackColor = false;
            buttonLoiTatBaoCaoNhanVien.Click += buttonBaoCaoNhanVien_Click;
            // 
            // buttonLoiTatBaoCaoQTDT
            // 
            buttonLoiTatBaoCaoQTDT.BackColor = Color.White;
            buttonLoiTatBaoCaoQTDT.Cursor = Cursors.Hand;
            buttonLoiTatBaoCaoQTDT.FlatAppearance.BorderColor = Color.FromArgb(226, 232, 240);
            buttonLoiTatBaoCaoQTDT.FlatAppearance.MouseOverBackColor = Color.FromArgb(219, 234, 254);
            buttonLoiTatBaoCaoQTDT.FlatStyle = FlatStyle.Flat;
            buttonLoiTatBaoCaoQTDT.Font = new Font("Segoe UI", 10.5F, FontStyle.Bold);
            buttonLoiTatBaoCaoQTDT.ForeColor = Color.FromArgb(30, 41, 59);
            buttonLoiTatBaoCaoQTDT.Margin = new Padding(0, 0, 16, 16);
            buttonLoiTatBaoCaoQTDT.Name = "buttonLoiTatBaoCaoQTDT";
            buttonLoiTatBaoCaoQTDT.Size = new Size(222, 80);
            buttonLoiTatBaoCaoQTDT.TabIndex = 7;
            buttonLoiTatBaoCaoQTDT.Text = "Báo cáo đào tạo";
            buttonLoiTatBaoCaoQTDT.UseVisualStyleBackColor = false;
            buttonLoiTatBaoCaoQTDT.Click += buttonBaoCaoQTDT_Click;
            // 
            // panelNoiDung
            // 
            panelNoiDung.BackColor = Color.White;
            panelNoiDung.Dock = DockStyle.Fill;
            panelNoiDung.Location = new Point(260, 76);
            panelNoiDung.Name = "panelNoiDung";
            panelNoiDung.Size = new Size(1020, 644);
            panelNoiDung.TabIndex = 3;
            panelNoiDung.Visible = false;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1280, 720);
            Controls.Add(panelNoiDung);
            Controls.Add(panelTongQuan);
            Controls.Add(panelTieuDe);
            Controls.Add(panelMenu);
            MinimumSize = new Size(1100, 640);
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Hệ thống Quản lý Nhân sự";
            panelMenu.ResumeLayout(false);
            panelTieuDe.ResumeLayout(false);
            panelTieuDe.PerformLayout();
            panelTongQuan.ResumeLayout(false);
            panelTongQuan.PerformLayout();
            panelTheQuanLy.ResumeLayout(false);
            panelTheQuanLy.PerformLayout();
            panelTheTraCuu.ResumeLayout(false);
            panelTheTraCuu.PerformLayout();
            panelTheBaoCao.ResumeLayout(false);
            panelTheBaoCao.PerformLayout();
            flowLayoutPanelLoiTat.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panelMenu;
        private Panel panelTieuDe;
        private Panel panelTongQuan;
        private Panel panelNoiDung;
        private Label labelHeThong;
        private Label labelTieuDe;
        private Button buttonTongQuan;
        private Label labelQuanLy;
        private Button buttonDanhMuc;
        private Button buttonNhanVien;
        private Button buttonQTDT;
        private Button buttonQTCT;
        private Button buttonQuaTrinhNV;
        private Label labelTraCuu;
        private Button buttonTimKiemNV;
        private Button buttonTimKiemQTDT;
        private Label labelBaoCao;
        private Button buttonBaoCaoNhanVien;
        private Button buttonBaoCaoQTCT;
        private Button buttonBaoCaoQTDT;
        private Button buttonBaoCaoQTDTChuaKetThuc;
        private Panel panelTheQuanLy;
        private Panel panelTheTraCuu;
        private Panel panelTheBaoCao;
        private Label labelSoQuanLy;
        private Label labelSoTraCuu;
        private Label labelSoBaoCao;
        private Label labelNhanQuanLy;
        private Label labelNhanTraCuu;
        private Label labelNhanBaoCao;
        private Label labelChaoMung;
        private Label labelMoTa;
        private Label labelLoiTat;
        private FlowLayoutPanel flowLayoutPanelLoiTat;
        private Button buttonLoiTatNhanVien;
        private Button buttonLoiTatDanhMuc;
        private Button buttonLoiTatQTDT;
        private Button buttonLoiTatQTCT;
        private Button buttonLoiTatTimKiemNV;
        private Button buttonLoiTatTimKiemQTDT;
        private Button buttonLoiTatBaoCaoNhanVien;
        private Button buttonLoiTatBaoCaoQTDT;
    }
}
