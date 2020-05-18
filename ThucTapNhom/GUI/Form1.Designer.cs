namespace ThucTapNhom
{
    partial class frm_QLNV
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_QLNV));
            this.label1 = new System.Windows.Forms.Label();
            this.lbNameAcc = new System.Windows.Forms.Label();
            this.grbThaoTac = new System.Windows.Forms.GroupBox();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.btnHienThi = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnChinhSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.grbDSNV = new System.Windows.Forms.GroupBox();
            this.View_NhanVien = new System.Windows.Forms.DataGridView();
            this.grbThongtinNV = new System.Windows.Forms.GroupBox();
            this.cboMaNV = new System.Windows.Forms.ComboBox();
            this.txtTenNV = new System.Windows.Forms.TextBox();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.rdbNu = new System.Windows.Forms.RadioButton();
            this.rdbNam = new System.Windows.Forms.RadioButton();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.cboChucVuNV = new System.Windows.Forms.ComboBox();
            this.lbChucVu = new System.Windows.Forms.Label();
            this.lbSĐT = new System.Windows.Forms.Label();
            this.lbDiaChi = new System.Windows.Forms.Label();
            this.lbGioiTinh = new System.Windows.Forms.Label();
            this.lbTenNV = new System.Windows.Forms.Label();
            this.lbMaNV = new System.Windows.Forms.Label();
            this.grbThaoTac.SuspendLayout();
            this.grbDSNV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.View_NhanVien)).BeginInit();
            this.grbThongtinNV.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(211)))), ((int)(((byte)(215)))));
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Chào!";
            // 
            // lbNameAcc
            // 
            this.lbNameAcc.AutoSize = true;
            this.lbNameAcc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(211)))), ((int)(((byte)(215)))));
            this.lbNameAcc.Location = new System.Drawing.Point(64, 13);
            this.lbNameAcc.Name = "lbNameAcc";
            this.lbNameAcc.Size = new System.Drawing.Size(0, 13);
            this.lbNameAcc.TabIndex = 0;
            // 
            // grbThaoTac
            // 
            this.grbThaoTac.Controls.Add(this.btnTimKiem);
            this.grbThaoTac.Controls.Add(this.btnHienThi);
            this.grbThaoTac.Controls.Add(this.btnXoa);
            this.grbThaoTac.Controls.Add(this.btnChinhSua);
            this.grbThaoTac.Controls.Add(this.btnThem);
            this.grbThaoTac.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbThaoTac.Location = new System.Drawing.Point(9, 52);
            this.grbThaoTac.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grbThaoTac.Name = "grbThaoTac";
            this.grbThaoTac.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grbThaoTac.Size = new System.Drawing.Size(1030, 88);
            this.grbThaoTac.TabIndex = 9;
            this.grbThaoTac.TabStop = false;
            this.grbThaoTac.Text = "Thao tác";
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.ForeColor = System.Drawing.Color.Red;
            this.btnTimKiem.Image = ((System.Drawing.Image)(resources.GetObject("btnTimKiem.Image")));
            this.btnTimKiem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTimKiem.Location = new System.Drawing.Point(908, 17);
            this.btnTimKiem.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(86, 47);
            this.btnTimKiem.TabIndex = 4;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click_1);
            // 
            // btnHienThi
            // 
            this.btnHienThi.ForeColor = System.Drawing.Color.Red;
            this.btnHienThi.Image = ((System.Drawing.Image)(resources.GetObject("btnHienThi.Image")));
            this.btnHienThi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHienThi.Location = new System.Drawing.Point(696, 17);
            this.btnHienThi.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnHienThi.Name = "btnHienThi";
            this.btnHienThi.Size = new System.Drawing.Size(88, 47);
            this.btnHienThi.TabIndex = 3;
            this.btnHienThi.Text = "Hiển thị";
            this.btnHienThi.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnHienThi.UseVisualStyleBackColor = true;
            this.btnHienThi.Click += new System.EventHandler(this.btnHienThi_Click_1);
            // 
            // btnXoa
            // 
            this.btnXoa.ForeColor = System.Drawing.Color.Red;
            this.btnXoa.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa.Image")));
            this.btnXoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoa.Location = new System.Drawing.Point(509, 17);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(80, 47);
            this.btnXoa.TabIndex = 2;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click_1);
            // 
            // btnChinhSua
            // 
            this.btnChinhSua.ForeColor = System.Drawing.Color.Red;
            this.btnChinhSua.Image = ((System.Drawing.Image)(resources.GetObject("btnChinhSua.Image")));
            this.btnChinhSua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnChinhSua.Location = new System.Drawing.Point(269, 17);
            this.btnChinhSua.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnChinhSua.Name = "btnChinhSua";
            this.btnChinhSua.Size = new System.Drawing.Size(102, 47);
            this.btnChinhSua.TabIndex = 1;
            this.btnChinhSua.Text = "Chỉnh sửa ";
            this.btnChinhSua.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnChinhSua.UseVisualStyleBackColor = true;
            this.btnChinhSua.Click += new System.EventHandler(this.btnChinhSua_Click_1);
            // 
            // btnThem
            // 
            this.btnThem.ForeColor = System.Drawing.Color.Red;
            this.btnThem.Image = ((System.Drawing.Image)(resources.GetObject("btnThem.Image")));
            this.btnThem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThem.Location = new System.Drawing.Point(46, 17);
            this.btnThem.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(87, 47);
            this.btnThem.TabIndex = 0;
            this.btnThem.Text = "Thêm NV";
            this.btnThem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click_1);
            // 
            // grbDSNV
            // 
            this.grbDSNV.Controls.Add(this.View_NhanVien);
            this.grbDSNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbDSNV.Location = new System.Drawing.Point(339, 164);
            this.grbDSNV.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grbDSNV.Name = "grbDSNV";
            this.grbDSNV.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grbDSNV.Size = new System.Drawing.Size(700, 266);
            this.grbDSNV.TabIndex = 8;
            this.grbDSNV.TabStop = false;
            this.grbDSNV.Text = "Danh Sách Nhân Viên";
            // 
            // View_NhanVien
            // 
            this.View_NhanVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.View_NhanVien.Location = new System.Drawing.Point(15, 25);
            this.View_NhanVien.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.View_NhanVien.Name = "View_NhanVien";
            this.View_NhanVien.RowTemplate.Height = 24;
            this.View_NhanVien.Size = new System.Drawing.Size(663, 222);
            this.View_NhanVien.TabIndex = 0;
            this.View_NhanVien.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.View_NhanVien_CellContentClick_1);
            // 
            // grbThongtinNV
            // 
            this.grbThongtinNV.Controls.Add(this.cboMaNV);
            this.grbThongtinNV.Controls.Add(this.txtTenNV);
            this.grbThongtinNV.Controls.Add(this.txtDiaChi);
            this.grbThongtinNV.Controls.Add(this.rdbNu);
            this.grbThongtinNV.Controls.Add(this.rdbNam);
            this.grbThongtinNV.Controls.Add(this.txtSDT);
            this.grbThongtinNV.Controls.Add(this.cboChucVuNV);
            this.grbThongtinNV.Controls.Add(this.lbChucVu);
            this.grbThongtinNV.Controls.Add(this.lbSĐT);
            this.grbThongtinNV.Controls.Add(this.lbDiaChi);
            this.grbThongtinNV.Controls.Add(this.lbGioiTinh);
            this.grbThongtinNV.Controls.Add(this.lbTenNV);
            this.grbThongtinNV.Controls.Add(this.lbMaNV);
            this.grbThongtinNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbThongtinNV.Location = new System.Drawing.Point(9, 164);
            this.grbThongtinNV.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grbThongtinNV.Name = "grbThongtinNV";
            this.grbThongtinNV.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grbThongtinNV.Size = new System.Drawing.Size(305, 266);
            this.grbThongtinNV.TabIndex = 7;
            this.grbThongtinNV.TabStop = false;
            this.grbThongtinNV.Text = "Thông tin Nhân viên";
            // 
            // cboMaNV
            // 
            this.cboMaNV.FormattingEnabled = true;
            this.cboMaNV.Location = new System.Drawing.Point(96, 32);
            this.cboMaNV.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cboMaNV.Name = "cboMaNV";
            this.cboMaNV.Size = new System.Drawing.Size(191, 21);
            this.cboMaNV.TabIndex = 10;
            // 
            // txtTenNV
            // 
            this.txtTenNV.Location = new System.Drawing.Point(96, 64);
            this.txtTenNV.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtTenNV.Name = "txtTenNV";
            this.txtTenNV.Size = new System.Drawing.Size(191, 19);
            this.txtTenNV.TabIndex = 9;
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(96, 234);
            this.txtDiaChi.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(191, 19);
            this.txtDiaChi.TabIndex = 8;
            // 
            // rdbNu
            // 
            this.rdbNu.AutoSize = true;
            this.rdbNu.Location = new System.Drawing.Point(96, 136);
            this.rdbNu.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rdbNu.Name = "rdbNu";
            this.rdbNu.Size = new System.Drawing.Size(41, 17);
            this.rdbNu.TabIndex = 7;
            this.rdbNu.TabStop = true;
            this.rdbNu.Text = "Nữ";
            this.rdbNu.UseVisualStyleBackColor = true;
            // 
            // rdbNam
            // 
            this.rdbNam.AutoSize = true;
            this.rdbNam.Location = new System.Drawing.Point(96, 106);
            this.rdbNam.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rdbNam.Name = "rdbNam";
            this.rdbNam.Size = new System.Drawing.Size(50, 17);
            this.rdbNam.TabIndex = 6;
            this.rdbNam.TabStop = true;
            this.rdbNam.Text = "Nam";
            this.rdbNam.UseVisualStyleBackColor = true;
            // 
            // txtSDT
            // 
            this.txtSDT.Location = new System.Drawing.Point(96, 165);
            this.txtSDT.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(191, 19);
            this.txtSDT.TabIndex = 1;
            // 
            // cboChucVuNV
            // 
            this.cboChucVuNV.FormattingEnabled = true;
            this.cboChucVuNV.Location = new System.Drawing.Point(96, 204);
            this.cboChucVuNV.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cboChucVuNV.Name = "cboChucVuNV";
            this.cboChucVuNV.Size = new System.Drawing.Size(191, 21);
            this.cboChucVuNV.TabIndex = 2;
            // 
            // lbChucVu
            // 
            this.lbChucVu.AutoSize = true;
            this.lbChucVu.Location = new System.Drawing.Point(13, 199);
            this.lbChucVu.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbChucVu.Name = "lbChucVu";
            this.lbChucVu.Size = new System.Drawing.Size(55, 13);
            this.lbChucVu.TabIndex = 5;
            this.lbChucVu.Text = "Chức Vụ";
            // 
            // lbSĐT
            // 
            this.lbSĐT.AutoSize = true;
            this.lbSĐT.Location = new System.Drawing.Point(13, 162);
            this.lbSĐT.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbSĐT.Name = "lbSĐT";
            this.lbSĐT.Size = new System.Drawing.Size(69, 13);
            this.lbSĐT.TabIndex = 4;
            this.lbSĐT.Text = "Điện Thoại";
            // 
            // lbDiaChi
            // 
            this.lbDiaChi.AutoSize = true;
            this.lbDiaChi.Location = new System.Drawing.Point(13, 234);
            this.lbDiaChi.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbDiaChi.Name = "lbDiaChi";
            this.lbDiaChi.Size = new System.Drawing.Size(48, 13);
            this.lbDiaChi.TabIndex = 3;
            this.lbDiaChi.Text = "Địa Chỉ";
            // 
            // lbGioiTinh
            // 
            this.lbGioiTinh.AutoSize = true;
            this.lbGioiTinh.Location = new System.Drawing.Point(13, 90);
            this.lbGioiTinh.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbGioiTinh.Name = "lbGioiTinh";
            this.lbGioiTinh.Size = new System.Drawing.Size(64, 13);
            this.lbGioiTinh.TabIndex = 2;
            this.lbGioiTinh.Text = "Giới tính :";
            // 
            // lbTenNV
            // 
            this.lbTenNV.AutoSize = true;
            this.lbTenNV.Location = new System.Drawing.Point(13, 64);
            this.lbTenNV.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbTenNV.Name = "lbTenNV";
            this.lbTenNV.Size = new System.Drawing.Size(50, 13);
            this.lbTenNV.TabIndex = 1;
            this.lbTenNV.Text = "Tên NV";
            // 
            // lbMaNV
            // 
            this.lbMaNV.AutoSize = true;
            this.lbMaNV.Location = new System.Drawing.Point(13, 25);
            this.lbMaNV.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbMaNV.Name = "lbMaNV";
            this.lbMaNV.Size = new System.Drawing.Size(45, 13);
            this.lbMaNV.TabIndex = 0;
            this.lbMaNV.Text = "Mã NV";
            // 
            // frm_QLNV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(128)))), ((int)(((byte)(132)))));
            this.ClientSize = new System.Drawing.Size(1028, 450);
            this.Controls.Add(this.grbThaoTac);
            this.Controls.Add(this.grbDSNV);
            this.Controls.Add(this.grbThongtinNV);
            this.Controls.Add(this.lbNameAcc);
            this.Controls.Add(this.label1);
            this.Name = "frm_QLNV";
            this.Text = "Quản lý nhân viên";
            this.Load += new System.EventHandler(this.frm_QLNV_Load);
            this.grbThaoTac.ResumeLayout(false);
            this.grbDSNV.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.View_NhanVien)).EndInit();
            this.grbThongtinNV.ResumeLayout(false);
            this.grbThongtinNV.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbNameAcc;
        private System.Windows.Forms.GroupBox grbThaoTac;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.Button btnHienThi;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnChinhSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.GroupBox grbDSNV;
        private System.Windows.Forms.DataGridView View_NhanVien;
        private System.Windows.Forms.GroupBox grbThongtinNV;
        private System.Windows.Forms.ComboBox cboMaNV;
        private System.Windows.Forms.TextBox txtTenNV;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.RadioButton rdbNu;
        private System.Windows.Forms.RadioButton rdbNam;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.ComboBox cboChucVuNV;
        private System.Windows.Forms.Label lbChucVu;
        private System.Windows.Forms.Label lbSĐT;
        private System.Windows.Forms.Label lbDiaChi;
        private System.Windows.Forms.Label lbGioiTinh;
        private System.Windows.Forms.Label lbTenNV;
        private System.Windows.Forms.Label lbMaNV;
    }
}

