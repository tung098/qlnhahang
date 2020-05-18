namespace ThucTapNhom.GUI
{
    partial class Form_TimKiemDSThongTinDatHangNCC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_TimKiemDSThongTinDatHangNCC));
            this.grbTimKiem = new System.Windows.Forms.GroupBox();
            this.dtpkDenNgay = new System.Windows.Forms.DateTimePicker();
            this.lbDenNgay = new System.Windows.Forms.Label();
            this.dtpkTuNgay = new System.Windows.Forms.DateTimePicker();
            this.lbNgayNhap = new System.Windows.Forms.Label();
            this.cboNhanVien = new System.Windows.Forms.ComboBox();
            this.cboNCC = new System.Windows.Forms.ComboBox();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.lbTenNV = new System.Windows.Forms.Label();
            this.lbNCC = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.view_NCC = new System.Windows.Forms.DataGridView();
            this.grbTimKiem.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.view_NCC)).BeginInit();
            this.SuspendLayout();
            // 
            // grbTimKiem
            // 
            this.grbTimKiem.Controls.Add(this.dtpkDenNgay);
            this.grbTimKiem.Controls.Add(this.lbDenNgay);
            this.grbTimKiem.Controls.Add(this.dtpkTuNgay);
            this.grbTimKiem.Controls.Add(this.lbNgayNhap);
            this.grbTimKiem.Controls.Add(this.cboNhanVien);
            this.grbTimKiem.Controls.Add(this.cboNCC);
            this.grbTimKiem.Controls.Add(this.btnTimKiem);
            this.grbTimKiem.Controls.Add(this.lbTenNV);
            this.grbTimKiem.Controls.Add(this.lbNCC);
            this.grbTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbTimKiem.Location = new System.Drawing.Point(9, 10);
            this.grbTimKiem.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grbTimKiem.Name = "grbTimKiem";
            this.grbTimKiem.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grbTimKiem.Size = new System.Drawing.Size(768, 152);
            this.grbTimKiem.TabIndex = 2;
            this.grbTimKiem.TabStop = false;
            this.grbTimKiem.Text = "Tìm Kiếm";
            // 
            // dtpkDenNgay
            // 
            this.dtpkDenNgay.Location = new System.Drawing.Point(558, 65);
            this.dtpkDenNgay.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtpkDenNgay.Name = "dtpkDenNgay";
            this.dtpkDenNgay.Size = new System.Drawing.Size(206, 19);
            this.dtpkDenNgay.TabIndex = 7;
            // 
            // lbDenNgay
            // 
            this.lbDenNgay.AutoSize = true;
            this.lbDenNgay.Location = new System.Drawing.Point(472, 65);
            this.lbDenNgay.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbDenNgay.Name = "lbDenNgay";
            this.lbDenNgay.Size = new System.Drawing.Size(61, 13);
            this.lbDenNgay.TabIndex = 6;
            this.lbDenNgay.Text = "Đến ngày";
            // 
            // dtpkTuNgay
            // 
            this.dtpkTuNgay.Location = new System.Drawing.Point(117, 62);
            this.dtpkTuNgay.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtpkTuNgay.Name = "dtpkTuNgay";
            this.dtpkTuNgay.Size = new System.Drawing.Size(218, 19);
            this.dtpkTuNgay.TabIndex = 5;
            // 
            // lbNgayNhap
            // 
            this.lbNgayNhap.AutoSize = true;
            this.lbNgayNhap.Location = new System.Drawing.Point(28, 62);
            this.lbNgayNhap.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbNgayNhap.Name = "lbNgayNhap";
            this.lbNgayNhap.Size = new System.Drawing.Size(55, 13);
            this.lbNgayNhap.TabIndex = 4;
            this.lbNgayNhap.Text = "Từ Ngày";
            // 
            // cboNhanVien
            // 
            this.cboNhanVien.FormattingEnabled = true;
            this.cboNhanVien.Location = new System.Drawing.Point(558, 18);
            this.cboNhanVien.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cboNhanVien.Name = "cboNhanVien";
            this.cboNhanVien.Size = new System.Drawing.Size(206, 21);
            this.cboNhanVien.TabIndex = 3;
            // 
            // cboNCC
            // 
            this.cboNCC.FormattingEnabled = true;
            this.cboNCC.Location = new System.Drawing.Point(117, 17);
            this.cboNCC.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cboNCC.Name = "cboNCC";
            this.cboNCC.Size = new System.Drawing.Size(218, 21);
            this.cboNCC.TabIndex = 2;
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Image = ((System.Drawing.Image)(resources.GetObject("btnTimKiem.Image")));
            this.btnTimKiem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTimKiem.Location = new System.Drawing.Point(677, 121);
            this.btnTimKiem.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(86, 26);
            this.btnTimKiem.TabIndex = 3;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // lbTenNV
            // 
            this.lbTenNV.AutoSize = true;
            this.lbTenNV.Location = new System.Drawing.Point(470, 23);
            this.lbTenNV.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbTenNV.Name = "lbTenNV";
            this.lbTenNV.Size = new System.Drawing.Size(89, 13);
            this.lbTenNV.TabIndex = 1;
            this.lbTenNV.Text = "Tên nhân viên";
            // 
            // lbNCC
            // 
            this.lbNCC.AutoSize = true;
            this.lbNCC.Location = new System.Drawing.Point(28, 18);
            this.lbNCC.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbNCC.Name = "lbNCC";
            this.lbNCC.Size = new System.Drawing.Size(87, 13);
            this.lbNCC.TabIndex = 0;
            this.lbNCC.Text = "Nhà cung cấp";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.view_NCC);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(10, 177);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(767, 197);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách Phiếu mua hàng Nhà Cung Cấp";
            // 
            // view_NCC
            // 
            this.view_NCC.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.view_NCC.Location = new System.Drawing.Point(4, 17);
            this.view_NCC.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.view_NCC.Name = "view_NCC";
            this.view_NCC.RowTemplate.Height = 24;
            this.view_NCC.Size = new System.Drawing.Size(758, 175);
            this.view_NCC.TabIndex = 0;
            // 
            // Form_TimKiemDSThongTinDatHangNCC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(128)))), ((int)(((byte)(132)))));
            this.ClientSize = new System.Drawing.Size(806, 397);
            this.Controls.Add(this.grbTimKiem);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form_TimKiemDSThongTinDatHangNCC";
            this.Text = "Form_TimKiemDSThongTinDatHangNCC";
            this.Load += new System.EventHandler(this.Form_TimKiemDSThongTinDatHangNCC_Load);
            this.grbTimKiem.ResumeLayout(false);
            this.grbTimKiem.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.view_NCC)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbTimKiem;
        private System.Windows.Forms.DateTimePicker dtpkDenNgay;
        private System.Windows.Forms.Label lbDenNgay;
        private System.Windows.Forms.DateTimePicker dtpkTuNgay;
        private System.Windows.Forms.Label lbNgayNhap;
        private System.Windows.Forms.ComboBox cboNhanVien;
        private System.Windows.Forms.ComboBox cboNCC;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.Label lbTenNV;
        private System.Windows.Forms.Label lbNCC;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView view_NCC;
    }
}