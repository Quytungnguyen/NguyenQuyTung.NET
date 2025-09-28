namespace WindowsFormsApp_CauThu
{
    partial class Menu
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.dataGridViewCauThu = new System.Windows.Forms.DataGridView();
            this.colAnh = new System.Windows.Forms.DataGridViewImageColumn();
            this.colTen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colViTri = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colQuocTich = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCLB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.listBoxYeuThich = new System.Windows.Forms.ListBox();
            this.btnXemDanhSach = new System.Windows.Forms.Button();
            this.btnKetQua = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCauThu)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewCauThu
            // 
            this.dataGridViewCauThu.AllowUserToAddRows = false;
            this.dataGridViewCauThu.AllowUserToDeleteRows = false;
            this.dataGridViewCauThu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCauThu.MultiSelect = false; // chỉ chọn 1 dòng
            this.dataGridViewCauThu.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewCauThu.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colAnh,
            this.colTen,
            this.colViTri,
            this.colQuocTich,
            this.colCLB});
            this.dataGridViewCauThu.Location = new System.Drawing.Point(12, 12);
            this.dataGridViewCauThu.Name = "dataGridViewCauThu";
            this.dataGridViewCauThu.RowTemplate.Height = 80;
            this.dataGridViewCauThu.Size = new System.Drawing.Size(700, 250);
            this.dataGridViewCauThu.TabIndex = 0;
            // 
            // colAnh
            // 
            this.colAnh.HeaderText = "Ảnh";
            this.colAnh.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.colAnh.Name = "colAnh";
            this.colAnh.Width = 80;
            // 
            // colTen
            // 
            this.colTen.HeaderText = "Tên";
            this.colTen.Name = "colTen";
            this.colTen.Width = 150;
            // 
            // colViTri
            // 
            this.colViTri.HeaderText = "Vị trí";
            this.colViTri.Name = "colViTri";
            this.colViTri.Width = 80;
            // 
            // colQuocTich
            // 
            this.colQuocTich.HeaderText = "Quốc tịch";
            this.colQuocTich.Name = "colQuocTich";
            this.colQuocTich.Width = 120;
            // 
            // colCLB
            // 
            this.colCLB.HeaderText = "CLB";
            this.colCLB.Name = "colCLB";
            this.colCLB.Width = 150;
            // 
            // listBoxYeuThich
            // 
            this.listBoxYeuThich.FormattingEnabled = true;
            this.listBoxYeuThich.Location = new System.Drawing.Point(12, 280);
            this.listBoxYeuThich.Name = "listBoxYeuThich";
            this.listBoxYeuThich.Size = new System.Drawing.Size(450, 95);
            this.listBoxYeuThich.TabIndex = 1;
            // 
            // btnXemDanhSach
            // 
            this.btnXemDanhSach.Location = new System.Drawing.Point(500, 280);
            this.btnXemDanhSach.Name = "btnXemDanhSach";
            this.btnXemDanhSach.Size = new System.Drawing.Size(150, 37);
            this.btnXemDanhSach.TabIndex = 2;
            this.btnXemDanhSach.Text = "Xem cầu thủ đã chọn";
            this.btnXemDanhSach.UseVisualStyleBackColor = true;
            this.btnXemDanhSach.Click += new System.EventHandler(this.btnXemDanhSach_Click);
            // 
            // btnKetQua
            // 
            this.btnKetQua.Location = new System.Drawing.Point(500, 338);
            this.btnKetQua.Name = "btnKetQua";
            this.btnKetQua.Size = new System.Drawing.Size(150, 37);
            this.btnKetQua.TabIndex = 3;
            this.btnKetQua.Text = "Kết quả bình chọn TOTY";
            this.btnKetQua.UseVisualStyleBackColor = true;
            this.btnKetQua.Click += new System.EventHandler(this.btnKetQua_Click);
            // 
            // Menu
            // 
            this.ClientSize = new System.Drawing.Size(730, 400);
            this.Controls.Add(this.btnKetQua);
            this.Controls.Add(this.btnXemDanhSach);
            this.Controls.Add(this.listBoxYeuThich);
            this.Controls.Add(this.dataGridViewCauThu);
            this.Name = "Menu";
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.Menu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCauThu)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewCauThu;
        private System.Windows.Forms.DataGridViewImageColumn colAnh;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTen;
        private System.Windows.Forms.DataGridViewTextBoxColumn colViTri;
        private System.Windows.Forms.DataGridViewTextBoxColumn colQuocTich;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCLB;
        private System.Windows.Forms.ListBox listBoxYeuThich;
        private System.Windows.Forms.Button btnXemDanhSach;
        private System.Windows.Forms.Button btnKetQua;
    }
}
