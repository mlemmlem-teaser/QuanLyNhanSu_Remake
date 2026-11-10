namespace QuanLyNhanSu.GUI
{
    partial class FormDanhMuc
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Label labelLoai;
        private System.Windows.Forms.ComboBox comboBoxLoaiDanhMuc;
        private System.Windows.Forms.Label labelTuKhoa;
        private System.Windows.Forms.TextBox textBoxTuKhoa;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.DataGridView dataGridViewDanhMuc;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonRefresh;
        private System.Windows.Forms.Button buttonBack;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.panelHeader = new System.Windows.Forms.Panel();
            this.labelTitle = new System.Windows.Forms.Label();
            this.labelLoai = new System.Windows.Forms.Label();
            this.comboBoxLoaiDanhMuc = new System.Windows.Forms.ComboBox();
            this.labelTuKhoa = new System.Windows.Forms.Label();
            this.textBoxTuKhoa = new System.Windows.Forms.TextBox();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.dataGridViewDanhMuc = new System.Windows.Forms.DataGridView();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonRefresh = new System.Windows.Forms.Button();
            this.buttonBack = new System.Windows.Forms.Button();
            this.panelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDanhMuc)).BeginInit();
            this.SuspendLayout();
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.FromArgb(31, 41, 55);
            this.panelHeader.Controls.Add(this.labelTitle);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Height = 70;
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.labelTitle.ForeColor = System.Drawing.Color.White;
            this.labelTitle.Location = new System.Drawing.Point(22, 18);
            this.labelTitle.Text = "QUẢN LÝ DANH MỤC";
            // 
            // labelLoai
            // 
            this.labelLoai.AutoSize = true;
            this.labelLoai.Location = new System.Drawing.Point(24, 94);
            this.labelLoai.Text = "Loại danh mục:";
            // 
            // comboBoxLoaiDanhMuc
            // 
            this.comboBoxLoaiDanhMuc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxLoaiDanhMuc.FormattingEnabled = true;
            this.comboBoxLoaiDanhMuc.Items.AddRange(new object[] { "Chọn loại danh mục..." });
            this.comboBoxLoaiDanhMuc.Location = new System.Drawing.Point(130, 90);
            this.comboBoxLoaiDanhMuc.Size = new System.Drawing.Size(220, 23);
            this.comboBoxLoaiDanhMuc.Name = "comboBoxLoaiDanhMuc";
            this.comboBoxLoaiDanhMuc.SelectedIndex = 0;
            // 
            // labelTuKhoa
            // 
            this.labelTuKhoa.AutoSize = true;
            this.labelTuKhoa.Location = new System.Drawing.Point(380, 94);
            this.labelTuKhoa.Text = "Từ khóa:";
            // 
            // textBoxTuKhoa
            // 
            this.textBoxTuKhoa.Location = new System.Drawing.Point(445, 90);
            this.textBoxTuKhoa.Size = new System.Drawing.Size(240, 23);
            this.textBoxTuKhoa.Name = "textBoxTuKhoa";
            // 
            // buttonSearch
            // 
            this.buttonSearch.Location = new System.Drawing.Point(700, 88);
            this.buttonSearch.Size = new System.Drawing.Size(95, 28);
            this.buttonSearch.Text = "Tìm kiếm";
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // dataGridViewDanhMuc
            // 
            this.dataGridViewDanhMuc.AllowUserToAddRows = false;
            this.dataGridViewDanhMuc.AllowUserToDeleteRows = false;
            this.dataGridViewDanhMuc.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewDanhMuc.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewDanhMuc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDanhMuc.Location = new System.Drawing.Point(24, 135);
            this.dataGridViewDanhMuc.Name = "dataGridViewDanhMuc";
            this.dataGridViewDanhMuc.ReadOnly = true;
            this.dataGridViewDanhMuc.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewDanhMuc.Size = new System.Drawing.Size(930, 360);
            // 
            // buttons
            // 
            this.buttonAdd.Location = new System.Drawing.Point(24, 515);
            this.buttonAdd.Size = new System.Drawing.Size(105, 34);
            this.buttonAdd.Text = "Thêm";
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            this.buttonEdit.Location = new System.Drawing.Point(140, 515);
            this.buttonEdit.Size = new System.Drawing.Size(105, 34);
            this.buttonEdit.Text = "Sửa";
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            this.buttonDelete.Location = new System.Drawing.Point(256, 515);
            this.buttonDelete.Size = new System.Drawing.Size(105, 34);
            this.buttonDelete.Text = "Xóa";
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            this.buttonRefresh.Location = new System.Drawing.Point(372, 515);
            this.buttonRefresh.Size = new System.Drawing.Size(105, 34);
            this.buttonRefresh.Text = "Làm mới";
            this.buttonRefresh.Name = "buttonRefresh";
            this.buttonRefresh.Click += new System.EventHandler(this.buttonRefresh_Click);
            this.buttonBack.Location = new System.Drawing.Point(849, 515);
            this.buttonBack.Size = new System.Drawing.Size(105, 34);
            this.buttonBack.Text = "Quay lại";
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // FormDanhMuc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(248, 250, 252);
            this.ClientSize = new System.Drawing.Size(980, 580);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.buttonRefresh);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.dataGridViewDanhMuc);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.textBoxTuKhoa);
            this.Controls.Add(this.labelTuKhoa);
            this.Controls.Add(this.comboBoxLoaiDanhMuc);
            this.Controls.Add(this.labelLoai);
            this.Controls.Add(this.panelHeader);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Name = "FormDanhMuc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý danh mục - QuanLyNhanSu";
            this.Load += new System.EventHandler(this.FormDanhMuc_Load);
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDanhMuc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
