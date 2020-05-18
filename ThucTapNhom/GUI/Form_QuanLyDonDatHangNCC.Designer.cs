namespace ThucTapNhom.GUI
{
    partial class Form_QuanLyDonDatHangNCC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_QuanLyDonDatHangNCC));
            this.dtpNgayNhap = new System.Windows.Forms.DateTimePicker();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnHienThiPN = new System.Windows.Forms.Button();
            this.btnSuaPN = new System.Windows.Forms.Button();
            this.btnTaoMoiPN = new System.Windows.Forms.Button();
            this.cboMaNV = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMaPhieuNhap = new System.Windows.Forms.TextBox();
            this.cboMaNCC1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cboSĐT = new System.Windows.Forms.ComboBox();
            this.lbSĐT = new System.Windows.Forms.Label();
            this.cboDiaChi = new System.Windows.Forms.ComboBox();
            this.grbDSPhieuNhap = new System.Windows.Forms.GroupBox();
            this.View_DSPN = new System.Windows.Forms.DataGridView();
            this.lbMaNCC = new System.Windows.Forms.Label();
            this.grbThongTinPN = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cboMaNCC = new System.Windows.Forms.ComboBox();
            this.lbMaPhieuNhap = new System.Windows.Forms.Label();
            this.lbNgayNhap = new System.Windows.Forms.Label();
            this.btnHienThiNCC = new System.Windows.Forms.Button();
            this.btnSuaNCC = new System.Windows.Forms.Button();
            this.btnXoaNCC = new System.Windows.Forms.Button();
            this.btnThemNCC = new System.Windows.Forms.Button();
            this.grbDSNCC = new System.Windows.Forms.GroupBox();
            this.View_DSNCC = new System.Windows.Forms.DataGridView();
            this.lbDiachi = new System.Windows.Forms.Label();
            this.cboNCC = new System.Windows.Forms.ComboBox();
            this.lbNCC = new System.Windows.Forms.Label();
            this.grbThongTinNCC = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnNhapTP = new System.Windows.Forms.Button();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.grbDSPhieuNhap.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.View_DSPN)).BeginInit();
            this.grbThongTinPN.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.grbDSNCC.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.View_DSNCC)).BeginInit();
            this.grbThongTinNCC.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtpNgayNhap
            // 
            this.dtpNgayNhap.Location = new System.Drawing.Point(300, 110);
            this.dtpNgayNhap.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtpNgayNhap.Name = "dtpNgayNhap";
            this.dtpNgayNhap.Size = new System.Drawing.Size(215, 19);
            this.dtpNgayNhap.TabIndex = 37;
            // 
            // btnXoa
            // 
            this.btnXoa.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa.Image")));
            this.btnXoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoa.Location = new System.Drawing.Point(4, 106);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(98, 30);
            this.btnXoa.TabIndex = 35;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnHienThiPN
            // 
            this.btnHienThiPN.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHienThiPN.Image = ((System.Drawing.Image)(resources.GetObject("btnHienThiPN.Image")));
            this.btnHienThiPN.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHienThiPN.Location = new System.Drawing.Point(5, 12);
            this.btnHienThiPN.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnHienThiPN.Name = "btnHienThiPN";
            this.btnHienThiPN.Size = new System.Drawing.Size(98, 24);
            this.btnHienThiPN.TabIndex = 5;
            this.btnHienThiPN.Text = "Hiển thị";
            this.btnHienThiPN.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnHienThiPN.UseVisualStyleBackColor = true;
            this.btnHienThiPN.Click += new System.EventHandler(this.btnHienThiPN_Click);
            // 
            // btnSuaPN
            // 
            this.btnSuaPN.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSuaPN.Image = ((System.Drawing.Image)(resources.GetObject("btnSuaPN.Image")));
            this.btnSuaPN.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSuaPN.Location = new System.Drawing.Point(4, 72);
            this.btnSuaPN.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSuaPN.Name = "btnSuaPN";
            this.btnSuaPN.Size = new System.Drawing.Size(98, 30);
            this.btnSuaPN.TabIndex = 34;
            this.btnSuaPN.Text = "Sửa";
            this.btnSuaPN.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSuaPN.UseVisualStyleBackColor = true;
            this.btnSuaPN.Click += new System.EventHandler(this.btnSuaPN_Click);
            // 
            // btnTaoMoiPN
            // 
            this.btnTaoMoiPN.Image = ((System.Drawing.Image)(resources.GetObject("btnTaoMoiPN.Image")));
            this.btnTaoMoiPN.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTaoMoiPN.Location = new System.Drawing.Point(5, 41);
            this.btnTaoMoiPN.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnTaoMoiPN.Name = "btnTaoMoiPN";
            this.btnTaoMoiPN.Size = new System.Drawing.Size(98, 25);
            this.btnTaoMoiPN.TabIndex = 33;
            this.btnTaoMoiPN.Text = "Tạo mới PN";
            this.btnTaoMoiPN.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTaoMoiPN.UseVisualStyleBackColor = true;
            this.btnTaoMoiPN.Click += new System.EventHandler(this.btnTaoMoiPN_Click);
            // 
            // cboMaNV
            // 
            this.cboMaNV.FormattingEnabled = true;
            this.cboMaNV.Location = new System.Drawing.Point(300, 78);
            this.cboMaNV.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cboMaNV.Name = "cboMaNV";
            this.cboMaNV.Size = new System.Drawing.Size(215, 21);
            this.cboMaNV.TabIndex = 32;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(178, 79);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 31;
            this.label1.Text = "Mã nhân viên";
            // 
            // txtMaPhieuNhap
            // 
            this.txtMaPhieuNhap.Location = new System.Drawing.Point(300, 41);
            this.txtMaPhieuNhap.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtMaPhieuNhap.Name = "txtMaPhieuNhap";
            this.txtMaPhieuNhap.Size = new System.Drawing.Size(215, 19);
            this.txtMaPhieuNhap.TabIndex = 29;
            // 
            // cboMaNCC1
            // 
            this.cboMaNCC1.FormattingEnabled = true;
            this.cboMaNCC1.Location = new System.Drawing.Point(293, 169);
            this.cboMaNCC1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cboMaNCC1.Name = "cboMaNCC1";
            this.cboMaNCC1.Size = new System.Drawing.Size(215, 21);
            this.cboMaNCC1.TabIndex = 36;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(172, 168);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 35;
            this.label2.Text = "Mã NCC";
            // 
            // cboSĐT
            // 
            this.cboSĐT.FormattingEnabled = true;
            this.cboSĐT.Location = new System.Drawing.Point(293, 83);
            this.cboSĐT.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cboSĐT.Name = "cboSĐT";
            this.cboSĐT.Size = new System.Drawing.Size(215, 21);
            this.cboSĐT.TabIndex = 25;
            // 
            // lbSĐT
            // 
            this.lbSĐT.AutoSize = true;
            this.lbSĐT.Location = new System.Drawing.Point(172, 83);
            this.lbSĐT.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbSĐT.Name = "lbSĐT";
            this.lbSĐT.Size = new System.Drawing.Size(32, 13);
            this.lbSĐT.TabIndex = 24;
            this.lbSĐT.Text = "SĐT";
            // 
            // cboDiaChi
            // 
            this.cboDiaChi.FormattingEnabled = true;
            this.cboDiaChi.Location = new System.Drawing.Point(293, 128);
            this.cboDiaChi.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cboDiaChi.Name = "cboDiaChi";
            this.cboDiaChi.Size = new System.Drawing.Size(215, 21);
            this.cboDiaChi.TabIndex = 23;
            // 
            // grbDSPhieuNhap
            // 
            this.grbDSPhieuNhap.Controls.Add(this.View_DSPN);
            this.grbDSPhieuNhap.Location = new System.Drawing.Point(559, 24);
            this.grbDSPhieuNhap.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grbDSPhieuNhap.Name = "grbDSPhieuNhap";
            this.grbDSPhieuNhap.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grbDSPhieuNhap.Size = new System.Drawing.Size(472, 180);
            this.grbDSPhieuNhap.TabIndex = 36;
            this.grbDSPhieuNhap.TabStop = false;
            this.grbDSPhieuNhap.Text = "Danh sách Phiếu nhập";
            // 
            // View_DSPN
            // 
            this.View_DSPN.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.View_DSPN.Location = new System.Drawing.Point(5, 17);
            this.View_DSPN.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.View_DSPN.Name = "View_DSPN";
            this.View_DSPN.RowTemplate.Height = 24;
            this.View_DSPN.Size = new System.Drawing.Size(466, 147);
            this.View_DSPN.TabIndex = 0;
            this.View_DSPN.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.View_DSPN_CellContentClick);
            // 
            // lbMaNCC
            // 
            this.lbMaNCC.AutoSize = true;
            this.lbMaNCC.Location = new System.Drawing.Point(179, 138);
            this.lbMaNCC.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbMaNCC.Name = "lbMaNCC";
            this.lbMaNCC.Size = new System.Drawing.Size(53, 13);
            this.lbMaNCC.TabIndex = 20;
            this.lbMaNCC.Text = "Mã NCC";
            // 
            // grbThongTinPN
            // 
            this.grbThongTinPN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(128)))), ((int)(((byte)(132)))));
            this.grbThongTinPN.Controls.Add(this.groupBox2);
            this.grbThongTinPN.Controls.Add(this.dtpNgayNhap);
            this.grbThongTinPN.Controls.Add(this.grbDSPhieuNhap);
            this.grbThongTinPN.Controls.Add(this.cboMaNV);
            this.grbThongTinPN.Controls.Add(this.label1);
            this.grbThongTinPN.Controls.Add(this.txtMaPhieuNhap);
            this.grbThongTinPN.Controls.Add(this.cboMaNCC);
            this.grbThongTinPN.Controls.Add(this.lbMaNCC);
            this.grbThongTinPN.Controls.Add(this.lbMaPhieuNhap);
            this.grbThongTinPN.Controls.Add(this.lbNgayNhap);
            this.grbThongTinPN.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbThongTinPN.Location = new System.Drawing.Point(9, 114);
            this.grbThongTinPN.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grbThongTinPN.Name = "grbThongTinPN";
            this.grbThongTinPN.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grbThongTinPN.Size = new System.Drawing.Size(1036, 214);
            this.grbThongTinPN.TabIndex = 29;
            this.grbThongTinPN.TabStop = false;
            this.grbThongTinPN.Text = "Thông tin phiếu nhập";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnXoa);
            this.groupBox2.Controls.Add(this.btnSuaPN);
            this.groupBox2.Controls.Add(this.btnHienThiPN);
            this.groupBox2.Controls.Add(this.btnTaoMoiPN);
            this.groupBox2.Location = new System.Drawing.Point(7, 33);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Size = new System.Drawing.Size(107, 145);
            this.groupBox2.TabIndex = 38;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thao tác";
            // 
            // cboMaNCC
            // 
            this.cboMaNCC.FormattingEnabled = true;
            this.cboMaNCC.Location = new System.Drawing.Point(300, 143);
            this.cboMaNCC.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cboMaNCC.Name = "cboMaNCC";
            this.cboMaNCC.Size = new System.Drawing.Size(215, 21);
            this.cboMaNCC.TabIndex = 21;
            // 
            // lbMaPhieuNhap
            // 
            this.lbMaPhieuNhap.AutoSize = true;
            this.lbMaPhieuNhap.Location = new System.Drawing.Point(178, 41);
            this.lbMaPhieuNhap.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbMaPhieuNhap.Name = "lbMaPhieuNhap";
            this.lbMaPhieuNhap.Size = new System.Drawing.Size(94, 13);
            this.lbMaPhieuNhap.TabIndex = 28;
            this.lbMaPhieuNhap.Text = "Mã Phiếu Nhập";
            // 
            // lbNgayNhap
            // 
            this.lbNgayNhap.AutoSize = true;
            this.lbNgayNhap.Location = new System.Drawing.Point(178, 107);
            this.lbNgayNhap.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbNgayNhap.Name = "lbNgayNhap";
            this.lbNgayNhap.Size = new System.Drawing.Size(68, 13);
            this.lbNgayNhap.TabIndex = 27;
            this.lbNgayNhap.Text = "Ngày nhập";
            // 
            // btnHienThiNCC
            // 
            this.btnHienThiNCC.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHienThiNCC.Image = ((System.Drawing.Image)(resources.GetObject("btnHienThiNCC.Image")));
            this.btnHienThiNCC.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHienThiNCC.Location = new System.Drawing.Point(4, 17);
            this.btnHienThiNCC.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnHienThiNCC.Name = "btnHienThiNCC";
            this.btnHienThiNCC.Size = new System.Drawing.Size(93, 27);
            this.btnHienThiNCC.TabIndex = 38;
            this.btnHienThiNCC.Text = "Hiển thị";
            this.btnHienThiNCC.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnHienThiNCC.UseVisualStyleBackColor = true;
            this.btnHienThiNCC.Click += new System.EventHandler(this.btnHienThiNCC_Click);
            // 
            // btnSuaNCC
            // 
            this.btnSuaNCC.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSuaNCC.Image = ((System.Drawing.Image)(resources.GetObject("btnSuaNCC.Image")));
            this.btnSuaNCC.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSuaNCC.Location = new System.Drawing.Point(4, 80);
            this.btnSuaNCC.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSuaNCC.Name = "btnSuaNCC";
            this.btnSuaNCC.Size = new System.Drawing.Size(93, 29);
            this.btnSuaNCC.TabIndex = 37;
            this.btnSuaNCC.Text = "Sửa NCC";
            this.btnSuaNCC.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSuaNCC.UseVisualStyleBackColor = true;
            this.btnSuaNCC.Click += new System.EventHandler(this.btnSuaNCC_Click);
            // 
            // btnXoaNCC
            // 
            this.btnXoaNCC.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaNCC.Image = ((System.Drawing.Image)(resources.GetObject("btnXoaNCC.Image")));
            this.btnXoaNCC.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoaNCC.Location = new System.Drawing.Point(4, 115);
            this.btnXoaNCC.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnXoaNCC.Name = "btnXoaNCC";
            this.btnXoaNCC.Size = new System.Drawing.Size(94, 28);
            this.btnXoaNCC.TabIndex = 1;
            this.btnXoaNCC.Text = "Xóa";
            this.btnXoaNCC.UseVisualStyleBackColor = true;
            this.btnXoaNCC.Click += new System.EventHandler(this.btnXoaNCC_Click);
            // 
            // btnThemNCC
            // 
            this.btnThemNCC.Image = ((System.Drawing.Image)(resources.GetObject("btnThemNCC.Image")));
            this.btnThemNCC.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThemNCC.Location = new System.Drawing.Point(4, 49);
            this.btnThemNCC.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnThemNCC.Name = "btnThemNCC";
            this.btnThemNCC.Size = new System.Drawing.Size(93, 28);
            this.btnThemNCC.TabIndex = 34;
            this.btnThemNCC.Text = "Thêm NCC";
            this.btnThemNCC.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThemNCC.UseVisualStyleBackColor = true;
            this.btnThemNCC.Click += new System.EventHandler(this.btnThemNCC_Click);
            // 
            // grbDSNCC
            // 
            this.grbDSNCC.Controls.Add(this.View_DSNCC);
            this.grbDSNCC.Location = new System.Drawing.Point(553, 24);
            this.grbDSNCC.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grbDSNCC.Name = "grbDSNCC";
            this.grbDSNCC.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grbDSNCC.Size = new System.Drawing.Size(472, 218);
            this.grbDSNCC.TabIndex = 37;
            this.grbDSNCC.TabStop = false;
            this.grbDSNCC.Text = "Danh sách Nhà cung cấp";
            // 
            // View_DSNCC
            // 
            this.View_DSNCC.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.View_DSNCC.Location = new System.Drawing.Point(5, 17);
            this.View_DSNCC.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.View_DSNCC.Name = "View_DSNCC";
            this.View_DSNCC.RowTemplate.Height = 24;
            this.View_DSNCC.Size = new System.Drawing.Size(466, 181);
            this.View_DSNCC.TabIndex = 1;
            this.View_DSNCC.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.View_DSNCC_CellContentClick);
            // 
            // lbDiachi
            // 
            this.lbDiachi.AutoSize = true;
            this.lbDiachi.Location = new System.Drawing.Point(172, 130);
            this.lbDiachi.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbDiachi.Name = "lbDiachi";
            this.lbDiachi.Size = new System.Drawing.Size(47, 13);
            this.lbDiachi.TabIndex = 22;
            this.lbDiachi.Text = "Địa chỉ";
            // 
            // cboNCC
            // 
            this.cboNCC.FormattingEnabled = true;
            this.cboNCC.Location = new System.Drawing.Point(293, 41);
            this.cboNCC.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cboNCC.Name = "cboNCC";
            this.cboNCC.Size = new System.Drawing.Size(215, 21);
            this.cboNCC.TabIndex = 19;
            // 
            // lbNCC
            // 
            this.lbNCC.AutoSize = true;
            this.lbNCC.Location = new System.Drawing.Point(172, 44);
            this.lbNCC.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbNCC.Name = "lbNCC";
            this.lbNCC.Size = new System.Drawing.Size(87, 13);
            this.lbNCC.TabIndex = 18;
            this.lbNCC.Text = "Nhà cung cấp";
            // 
            // grbThongTinNCC
            // 
            this.grbThongTinNCC.Controls.Add(this.groupBox3);
            this.grbThongTinNCC.Controls.Add(this.grbDSNCC);
            this.grbThongTinNCC.Controls.Add(this.cboMaNCC1);
            this.grbThongTinNCC.Controls.Add(this.label2);
            this.grbThongTinNCC.Controls.Add(this.cboSĐT);
            this.grbThongTinNCC.Controls.Add(this.lbSĐT);
            this.grbThongTinNCC.Controls.Add(this.cboDiaChi);
            this.grbThongTinNCC.Controls.Add(this.lbDiachi);
            this.grbThongTinNCC.Controls.Add(this.cboNCC);
            this.grbThongTinNCC.Controls.Add(this.lbNCC);
            this.grbThongTinNCC.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbThongTinNCC.Location = new System.Drawing.Point(16, 370);
            this.grbThongTinNCC.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grbThongTinNCC.Name = "grbThongTinNCC";
            this.grbThongTinNCC.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grbThongTinNCC.Size = new System.Drawing.Size(1029, 266);
            this.grbThongTinNCC.TabIndex = 28;
            this.grbThongTinNCC.TabStop = false;
            this.grbThongTinNCC.Text = "Thông tin nhà cung cấp";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnHienThiNCC);
            this.groupBox3.Controls.Add(this.btnXoaNCC);
            this.groupBox3.Controls.Add(this.btnSuaNCC);
            this.groupBox3.Controls.Add(this.btnThemNCC);
            this.groupBox3.Location = new System.Drawing.Point(5, 34);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox3.Size = new System.Drawing.Size(102, 148);
            this.groupBox3.TabIndex = 39;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Thao tác";
            // 
            // btnNhapTP
            // 
            this.btnNhapTP.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNhapTP.Image = ((System.Drawing.Image)(resources.GetObject("btnNhapTP.Image")));
            this.btnNhapTP.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNhapTP.Location = new System.Drawing.Point(343, 17);
            this.btnNhapTP.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnNhapTP.Name = "btnNhapTP";
            this.btnNhapTP.Size = new System.Drawing.Size(146, 46);
            this.btnNhapTP.TabIndex = 7;
            this.btnNhapTP.Text = "Nhập thực phẩm ";
            this.btnNhapTP.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNhapTP.UseVisualStyleBackColor = true;
            this.btnNhapTP.Click += new System.EventHandler(this.btnNhapTP_Click);
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimKiem.Image = ((System.Drawing.Image)(resources.GetObject("btnTimKiem.Image")));
            this.btnTimKiem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTimKiem.Location = new System.Drawing.Point(160, 17);
            this.btnTimKiem.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(128, 46);
            this.btnTimKiem.TabIndex = 6;
            this.btnTimKiem.Text = "Tìm Kiếm";
            this.btnTimKiem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnNhapTP);
            this.groupBox1.Controls.Add(this.btnTimKiem);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(229, 10);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(596, 68);
            this.groupBox1.TabIndex = 27;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thao tác ";
            // 
            // Form_QuanLyDonDatHangNCC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(128)))), ((int)(((byte)(132)))));
            this.ClientSize = new System.Drawing.Size(1061, 633);
            this.Controls.Add(this.grbThongTinPN);
            this.Controls.Add(this.grbThongTinNCC);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form_QuanLyDonDatHangNCC";
            this.Text = "Form_QuanLyDonDatHangNCC";
            this.Load += new System.EventHandler(this.Form_QuanLyDonDatHangNCC_Load);
            this.grbDSPhieuNhap.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.View_DSPN)).EndInit();
            this.grbThongTinPN.ResumeLayout(false);
            this.grbThongTinPN.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.grbDSNCC.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.View_DSNCC)).EndInit();
            this.grbThongTinNCC.ResumeLayout(false);
            this.grbThongTinNCC.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpNgayNhap;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnHienThiPN;
        private System.Windows.Forms.Button btnSuaPN;
        private System.Windows.Forms.Button btnTaoMoiPN;
        private System.Windows.Forms.ComboBox cboMaNV;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMaPhieuNhap;
        private System.Windows.Forms.ComboBox cboMaNCC1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboSĐT;
        private System.Windows.Forms.Label lbSĐT;
        private System.Windows.Forms.ComboBox cboDiaChi;
        private System.Windows.Forms.GroupBox grbDSPhieuNhap;
        private System.Windows.Forms.DataGridView View_DSPN;
        private System.Windows.Forms.Label lbMaNCC;
        private System.Windows.Forms.GroupBox grbThongTinPN;
        private System.Windows.Forms.ComboBox cboMaNCC;
        private System.Windows.Forms.Label lbMaPhieuNhap;
        private System.Windows.Forms.Label lbNgayNhap;
        private System.Windows.Forms.Button btnHienThiNCC;
        private System.Windows.Forms.Button btnSuaNCC;
        private System.Windows.Forms.Button btnXoaNCC;
        private System.Windows.Forms.Button btnThemNCC;
        private System.Windows.Forms.GroupBox grbDSNCC;
        private System.Windows.Forms.DataGridView View_DSNCC;
        private System.Windows.Forms.Label lbDiachi;
        private System.Windows.Forms.ComboBox cboNCC;
        private System.Windows.Forms.Label lbNCC;
        private System.Windows.Forms.GroupBox grbThongTinNCC;
        private System.Windows.Forms.Button btnNhapTP;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
    }
}