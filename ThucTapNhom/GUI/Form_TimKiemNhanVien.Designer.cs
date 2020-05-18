namespace ThucTapNhom.GUI
{
    partial class Form_TimKiemNhanVien
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_TimKiemNhanVien));
            this.grbThongTin_TimKiem = new System.Windows.Forms.GroupBox();
            this.lbDiaChi = new System.Windows.Forms.Label();
            this.btnTimkiem_DiaChiNV = new System.Windows.Forms.Button();
            this.cboDiaChi = new System.Windows.Forms.ComboBox();
            this.btnTimKiemChucVu = new System.Windows.Forms.Button();
            this.lbChucVu = new System.Windows.Forms.Label();
            this.cboChucVu = new System.Windows.Forms.ComboBox();
            this.lbTenNV = new System.Windows.Forms.Label();
            this.btnTiemkiem_tenNV = new System.Windows.Forms.Button();
            this.cboTenNV = new System.Windows.Forms.ComboBox();
            this.View_DSNhanVien_Timkiem = new System.Windows.Forms.DataGridView();
            this.grbDSNV_TimKiem = new System.Windows.Forms.GroupBox();
            this.grbThongTin_TimKiem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.View_DSNhanVien_Timkiem)).BeginInit();
            this.grbDSNV_TimKiem.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbThongTin_TimKiem
            // 
            this.grbThongTin_TimKiem.Controls.Add(this.lbDiaChi);
            this.grbThongTin_TimKiem.Controls.Add(this.btnTimkiem_DiaChiNV);
            this.grbThongTin_TimKiem.Controls.Add(this.cboDiaChi);
            this.grbThongTin_TimKiem.Controls.Add(this.btnTimKiemChucVu);
            this.grbThongTin_TimKiem.Controls.Add(this.lbChucVu);
            this.grbThongTin_TimKiem.Controls.Add(this.cboChucVu);
            this.grbThongTin_TimKiem.Controls.Add(this.lbTenNV);
            this.grbThongTin_TimKiem.Controls.Add(this.btnTiemkiem_tenNV);
            this.grbThongTin_TimKiem.Controls.Add(this.cboTenNV);
            this.grbThongTin_TimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbThongTin_TimKiem.Location = new System.Drawing.Point(16, 24);
            this.grbThongTin_TimKiem.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grbThongTin_TimKiem.Name = "grbThongTin_TimKiem";
            this.grbThongTin_TimKiem.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grbThongTin_TimKiem.Size = new System.Drawing.Size(638, 212);
            this.grbThongTin_TimKiem.TabIndex = 4;
            this.grbThongTin_TimKiem.TabStop = false;
            this.grbThongTin_TimKiem.Text = "Thông tin Tìm Kiếm";
            // 
            // lbDiaChi
            // 
            this.lbDiaChi.AutoSize = true;
            this.lbDiaChi.Location = new System.Drawing.Point(22, 100);
            this.lbDiaChi.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbDiaChi.Name = "lbDiaChi";
            this.lbDiaChi.Size = new System.Drawing.Size(48, 13);
            this.lbDiaChi.TabIndex = 9;
            this.lbDiaChi.Text = "Địa Chỉ";
            // 
            // btnTimkiem_DiaChiNV
            // 
            this.btnTimkiem_DiaChiNV.Image = ((System.Drawing.Image)(resources.GetObject("btnTimkiem_DiaChiNV.Image")));
            this.btnTimkiem_DiaChiNV.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTimkiem_DiaChiNV.Location = new System.Drawing.Point(431, 98);
            this.btnTimkiem_DiaChiNV.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnTimkiem_DiaChiNV.Name = "btnTimkiem_DiaChiNV";
            this.btnTimkiem_DiaChiNV.Size = new System.Drawing.Size(159, 26);
            this.btnTimkiem_DiaChiNV.TabIndex = 8;
            this.btnTimkiem_DiaChiNV.Text = "Tìm kiếm theo Địa chỉ NV";
            this.btnTimkiem_DiaChiNV.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTimkiem_DiaChiNV.UseVisualStyleBackColor = true;
            this.btnTimkiem_DiaChiNV.Click += new System.EventHandler(this.btnTimkiem_DiaChiNV_Click);
            // 
            // cboDiaChi
            // 
            this.cboDiaChi.FormattingEnabled = true;
            this.cboDiaChi.Location = new System.Drawing.Point(132, 98);
            this.cboDiaChi.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cboDiaChi.Name = "cboDiaChi";
            this.cboDiaChi.Size = new System.Drawing.Size(276, 21);
            this.cboDiaChi.TabIndex = 7;
            // 
            // btnTimKiemChucVu
            // 
            this.btnTimKiemChucVu.Image = ((System.Drawing.Image)(resources.GetObject("btnTimKiemChucVu.Image")));
            this.btnTimKiemChucVu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTimKiemChucVu.Location = new System.Drawing.Point(431, 161);
            this.btnTimKiemChucVu.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnTimKiemChucVu.Name = "btnTimKiemChucVu";
            this.btnTimKiemChucVu.Size = new System.Drawing.Size(159, 26);
            this.btnTimKiemChucVu.TabIndex = 6;
            this.btnTimKiemChucVu.Text = "Tìm kiếm theo Chức vụ NV";
            this.btnTimKiemChucVu.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTimKiemChucVu.UseVisualStyleBackColor = true;
            this.btnTimKiemChucVu.Click += new System.EventHandler(this.btnTimKiemChucVu_Click);
            // 
            // lbChucVu
            // 
            this.lbChucVu.AutoSize = true;
            this.lbChucVu.Location = new System.Drawing.Point(22, 170);
            this.lbChucVu.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbChucVu.Name = "lbChucVu";
            this.lbChucVu.Size = new System.Drawing.Size(55, 13);
            this.lbChucVu.TabIndex = 5;
            this.lbChucVu.Text = "Chức Vụ";
            // 
            // cboChucVu
            // 
            this.cboChucVu.FormattingEnabled = true;
            this.cboChucVu.Location = new System.Drawing.Point(132, 167);
            this.cboChucVu.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cboChucVu.Name = "cboChucVu";
            this.cboChucVu.Size = new System.Drawing.Size(276, 21);
            this.cboChucVu.TabIndex = 4;
            // 
            // lbTenNV
            // 
            this.lbTenNV.AutoSize = true;
            this.lbTenNV.Location = new System.Drawing.Point(22, 30);
            this.lbTenNV.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbTenNV.Name = "lbTenNV";
            this.lbTenNV.Size = new System.Drawing.Size(50, 13);
            this.lbTenNV.TabIndex = 3;
            this.lbTenNV.Text = "Tên NV";
            // 
            // btnTiemkiem_tenNV
            // 
            this.btnTiemkiem_tenNV.Image = ((System.Drawing.Image)(resources.GetObject("btnTiemkiem_tenNV.Image")));
            this.btnTiemkiem_tenNV.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTiemkiem_tenNV.Location = new System.Drawing.Point(431, 21);
            this.btnTiemkiem_tenNV.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnTiemkiem_tenNV.Name = "btnTiemkiem_tenNV";
            this.btnTiemkiem_tenNV.Size = new System.Drawing.Size(159, 26);
            this.btnTiemkiem_tenNV.TabIndex = 2;
            this.btnTiemkiem_tenNV.Text = "Tìm kiếm theo Tên NV";
            this.btnTiemkiem_tenNV.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTiemkiem_tenNV.UseVisualStyleBackColor = true;
            this.btnTiemkiem_tenNV.Click += new System.EventHandler(this.btnTiemkiem_tenNV_Click);
            // 
            // cboTenNV
            // 
            this.cboTenNV.FormattingEnabled = true;
            this.cboTenNV.Location = new System.Drawing.Point(132, 28);
            this.cboTenNV.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cboTenNV.Name = "cboTenNV";
            this.cboTenNV.Size = new System.Drawing.Size(276, 21);
            this.cboTenNV.TabIndex = 1;
            // 
            // View_DSNhanVien_Timkiem
            // 
            this.View_DSNhanVien_Timkiem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.View_DSNhanVien_Timkiem.Location = new System.Drawing.Point(5, 17);
            this.View_DSNhanVien_Timkiem.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.View_DSNhanVien_Timkiem.Name = "View_DSNhanVien_Timkiem";
            this.View_DSNhanVien_Timkiem.RowTemplate.Height = 24;
            this.View_DSNhanVien_Timkiem.Size = new System.Drawing.Size(622, 177);
            this.View_DSNhanVien_Timkiem.TabIndex = 2;
            // 
            // grbDSNV_TimKiem
            // 
            this.grbDSNV_TimKiem.Controls.Add(this.View_DSNhanVien_Timkiem);
            this.grbDSNV_TimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbDSNV_TimKiem.Location = new System.Drawing.Point(16, 265);
            this.grbDSNV_TimKiem.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grbDSNV_TimKiem.Name = "grbDSNV_TimKiem";
            this.grbDSNV_TimKiem.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grbDSNV_TimKiem.Size = new System.Drawing.Size(638, 206);
            this.grbDSNV_TimKiem.TabIndex = 5;
            this.grbDSNV_TimKiem.TabStop = false;
            this.grbDSNV_TimKiem.Text = "Danh sách Nhân Viên Tìm Kiếm";
            // 
            // Form_TimKiemNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(128)))), ((int)(((byte)(132)))));
            this.ClientSize = new System.Drawing.Size(671, 498);
            this.Controls.Add(this.grbThongTin_TimKiem);
            this.Controls.Add(this.grbDSNV_TimKiem);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form_TimKiemNhanVien";
            this.Text = "Form_TimKiemNhanVien";
            this.Load += new System.EventHandler(this.Form_TimKiemNhanVien_Load);
            this.grbThongTin_TimKiem.ResumeLayout(false);
            this.grbThongTin_TimKiem.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.View_DSNhanVien_Timkiem)).EndInit();
            this.grbDSNV_TimKiem.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbThongTin_TimKiem;
        private System.Windows.Forms.Label lbDiaChi;
        private System.Windows.Forms.Button btnTimkiem_DiaChiNV;
        private System.Windows.Forms.ComboBox cboDiaChi;
        private System.Windows.Forms.Button btnTimKiemChucVu;
        private System.Windows.Forms.Label lbChucVu;
        private System.Windows.Forms.ComboBox cboChucVu;
        private System.Windows.Forms.Label lbTenNV;
        private System.Windows.Forms.Button btnTiemkiem_tenNV;
        private System.Windows.Forms.ComboBox cboTenNV;
        private System.Windows.Forms.DataGridView View_DSNhanVien_Timkiem;
        private System.Windows.Forms.GroupBox grbDSNV_TimKiem;
    }
}