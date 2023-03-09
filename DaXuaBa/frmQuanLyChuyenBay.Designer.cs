
namespace DaXuaBa
{
    partial class frmQuanLyChuyenBay
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnThoat = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.gbxThemHangVeChoChuyenBay = new System.Windows.Forms.GroupBox();
            this.btnXoaHV = new System.Windows.Forms.Button();
            this.btnSuaHV = new System.Windows.Forms.Button();
            this.btnThemHV = new System.Windows.Forms.Button();
            this.dtgvHangVe = new System.Windows.Forms.DataGridView();
            this.cboMaHangVe = new System.Windows.Forms.ComboBox();
            this.txtTongSoGhe = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.gbxThaoTac = new System.Windows.Forms.GroupBox();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.gbxDSChuyenBay = new System.Windows.Forms.GroupBox();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.dtgvChuyenBay = new System.Windows.Forms.DataGridView();
            this.gbxTTChuyenBay = new System.Windows.Forms.GroupBox();
            this.dtpkThoiGianHaCanh = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpkThoiGianKhoiHanh = new System.Windows.Forms.DateTimePicker();
            this.txtMaChuyenBay = new System.Windows.Forms.TextBox();
            this.cboMaMayBay = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cboSanBayDen = new System.Windows.Forms.ComboBox();
            this.cboSanBayDi = new System.Windows.Forms.ComboBox();
            this.cboMaTuyenBay = new System.Windows.Forms.ComboBox();
            this.label24 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.gbxThemHangVeChoChuyenBay.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvHangVe)).BeginInit();
            this.gbxThaoTac.SuspendLayout();
            this.gbxDSChuyenBay.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvChuyenBay)).BeginInit();
            this.gbxTTChuyenBay.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Peru;
            this.panel1.Controls.Add(this.btnThoat);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1262, 52);
            this.panel1.TabIndex = 1;
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.Color.Peru;
            this.btnThoat.BackgroundImage = global::DaXuaBa.Properties.Resources.btnCancel;
            this.btnThoat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnThoat.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnThoat.FlatAppearance.BorderSize = 0;
            this.btnThoat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThoat.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.ForeColor = System.Drawing.Color.White;
            this.btnThoat.Location = new System.Drawing.Point(1200, 6);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(4);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(45, 40);
            this.btnThoat.TabIndex = 15;
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("#9Slide03 Roboto Slab", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(455, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(392, 44);
            this.label1.TabIndex = 0;
            this.label1.Text = "QUẢN LÝ CHUYẾN BAY";
            // 
            // gbxThemHangVeChoChuyenBay
            // 
            this.gbxThemHangVeChoChuyenBay.Controls.Add(this.btnXoaHV);
            this.gbxThemHangVeChoChuyenBay.Controls.Add(this.btnSuaHV);
            this.gbxThemHangVeChoChuyenBay.Controls.Add(this.btnThemHV);
            this.gbxThemHangVeChoChuyenBay.Controls.Add(this.dtgvHangVe);
            this.gbxThemHangVeChoChuyenBay.Controls.Add(this.cboMaHangVe);
            this.gbxThemHangVeChoChuyenBay.Controls.Add(this.txtTongSoGhe);
            this.gbxThemHangVeChoChuyenBay.Controls.Add(this.label4);
            this.gbxThemHangVeChoChuyenBay.Controls.Add(this.label3);
            this.gbxThemHangVeChoChuyenBay.Location = new System.Drawing.Point(402, 482);
            this.gbxThemHangVeChoChuyenBay.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbxThemHangVeChoChuyenBay.Name = "gbxThemHangVeChoChuyenBay";
            this.gbxThemHangVeChoChuyenBay.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbxThemHangVeChoChuyenBay.Size = new System.Drawing.Size(847, 181);
            this.gbxThemHangVeChoChuyenBay.TabIndex = 75;
            this.gbxThemHangVeChoChuyenBay.TabStop = false;
            this.gbxThemHangVeChoChuyenBay.Text = "Thêm hạng vé cho chuyến bay";
            // 
            // btnXoaHV
            // 
            this.btnXoaHV.Location = new System.Drawing.Point(341, 99);
            this.btnXoaHV.Name = "btnXoaHV";
            this.btnXoaHV.Size = new System.Drawing.Size(75, 40);
            this.btnXoaHV.TabIndex = 19;
            this.btnXoaHV.Text = "Xóa";
            this.btnXoaHV.UseVisualStyleBackColor = true;
            // 
            // btnSuaHV
            // 
            this.btnSuaHV.Location = new System.Drawing.Point(234, 99);
            this.btnSuaHV.Name = "btnSuaHV";
            this.btnSuaHV.Size = new System.Drawing.Size(75, 40);
            this.btnSuaHV.TabIndex = 18;
            this.btnSuaHV.Text = "Sửa";
            this.btnSuaHV.UseVisualStyleBackColor = true;
            // 
            // btnThemHV
            // 
            this.btnThemHV.Location = new System.Drawing.Point(131, 99);
            this.btnThemHV.Name = "btnThemHV";
            this.btnThemHV.Size = new System.Drawing.Size(75, 40);
            this.btnThemHV.TabIndex = 17;
            this.btnThemHV.Text = "Thêm";
            this.btnThemHV.UseVisualStyleBackColor = true;
            // 
            // dtgvHangVe
            // 
            this.dtgvHangVe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvHangVe.Location = new System.Drawing.Point(431, 20);
            this.dtgvHangVe.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtgvHangVe.Name = "dtgvHangVe";
            this.dtgvHangVe.RowHeadersWidth = 82;
            this.dtgvHangVe.RowTemplate.Height = 24;
            this.dtgvHangVe.Size = new System.Drawing.Size(408, 153);
            this.dtgvHangVe.TabIndex = 47;
            // 
            // cboMaHangVe
            // 
            this.cboMaHangVe.FormattingEnabled = true;
            this.cboMaHangVe.Location = new System.Drawing.Point(159, 22);
            this.cboMaHangVe.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cboMaHangVe.Name = "cboMaHangVe";
            this.cboMaHangVe.Size = new System.Drawing.Size(257, 24);
            this.cboMaHangVe.TabIndex = 36;
            // 
            // txtTongSoGhe
            // 
            this.txtTongSoGhe.Location = new System.Drawing.Point(159, 55);
            this.txtTongSoGhe.Margin = new System.Windows.Forms.Padding(4);
            this.txtTongSoGhe.Name = "txtTongSoGhe";
            this.txtTongSoGhe.Size = new System.Drawing.Size(257, 22);
            this.txtTongSoGhe.TabIndex = 29;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 60);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(135, 17);
            this.label4.TabIndex = 31;
            this.label4.Text = "Số ghế của hạng vé";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 30);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 17);
            this.label3.TabIndex = 26;
            this.label3.Text = "Hạng vé";
            // 
            // gbxThaoTac
            // 
            this.gbxThaoTac.Controls.Add(this.btnXoa);
            this.gbxThaoTac.Controls.Add(this.btnSua);
            this.gbxThaoTac.Controls.Add(this.btnThem);
            this.gbxThaoTac.Location = new System.Drawing.Point(10, 561);
            this.gbxThaoTac.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbxThaoTac.Name = "gbxThaoTac";
            this.gbxThaoTac.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbxThaoTac.Size = new System.Drawing.Size(380, 101);
            this.gbxThaoTac.TabIndex = 74;
            this.gbxThaoTac.TabStop = false;
            this.gbxThaoTac.Text = "Thao tác";
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(246, 42);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 40);
            this.btnXoa.TabIndex = 16;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(139, 42);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 40);
            this.btnSua.TabIndex = 15;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(36, 42);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 40);
            this.btnThem.TabIndex = 14;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            // 
            // gbxDSChuyenBay
            // 
            this.gbxDSChuyenBay.Controls.Add(this.btnTimKiem);
            this.gbxDSChuyenBay.Controls.Add(this.txtTimKiem);
            this.gbxDSChuyenBay.Controls.Add(this.dtgvChuyenBay);
            this.gbxDSChuyenBay.Location = new System.Drawing.Point(395, 61);
            this.gbxDSChuyenBay.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbxDSChuyenBay.Name = "gbxDSChuyenBay";
            this.gbxDSChuyenBay.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbxDSChuyenBay.Size = new System.Drawing.Size(853, 414);
            this.gbxDSChuyenBay.TabIndex = 73;
            this.gbxDSChuyenBay.TabStop = false;
            this.gbxDSChuyenBay.Text = "Danh sách chuyến bay";
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Location = new System.Drawing.Point(700, 35);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(85, 23);
            this.btnTimKiem.TabIndex = 49;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Location = new System.Drawing.Point(450, 35);
            this.txtTimKiem.Margin = new System.Windows.Forms.Padding(4);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(207, 22);
            this.txtTimKiem.TabIndex = 48;
            // 
            // dtgvChuyenBay
            // 
            this.dtgvChuyenBay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvChuyenBay.Location = new System.Drawing.Point(5, 63);
            this.dtgvChuyenBay.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtgvChuyenBay.Name = "dtgvChuyenBay";
            this.dtgvChuyenBay.RowHeadersWidth = 82;
            this.dtgvChuyenBay.RowTemplate.Height = 24;
            this.dtgvChuyenBay.Size = new System.Drawing.Size(843, 343);
            this.dtgvChuyenBay.TabIndex = 47;
            // 
            // gbxTTChuyenBay
            // 
            this.gbxTTChuyenBay.Controls.Add(this.dtpkThoiGianHaCanh);
            this.gbxTTChuyenBay.Controls.Add(this.label2);
            this.gbxTTChuyenBay.Controls.Add(this.dtpkThoiGianKhoiHanh);
            this.gbxTTChuyenBay.Controls.Add(this.txtMaChuyenBay);
            this.gbxTTChuyenBay.Controls.Add(this.cboMaMayBay);
            this.gbxTTChuyenBay.Controls.Add(this.label15);
            this.gbxTTChuyenBay.Controls.Add(this.label14);
            this.gbxTTChuyenBay.Controls.Add(this.label27);
            this.gbxTTChuyenBay.Controls.Add(this.label8);
            this.gbxTTChuyenBay.Controls.Add(this.cboSanBayDen);
            this.gbxTTChuyenBay.Controls.Add(this.cboSanBayDi);
            this.gbxTTChuyenBay.Controls.Add(this.cboMaTuyenBay);
            this.gbxTTChuyenBay.Controls.Add(this.label24);
            this.gbxTTChuyenBay.Controls.Add(this.label25);
            this.gbxTTChuyenBay.Location = new System.Drawing.Point(10, 61);
            this.gbxTTChuyenBay.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbxTTChuyenBay.Name = "gbxTTChuyenBay";
            this.gbxTTChuyenBay.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbxTTChuyenBay.Size = new System.Drawing.Size(380, 495);
            this.gbxTTChuyenBay.TabIndex = 72;
            this.gbxTTChuyenBay.TabStop = false;
            this.gbxTTChuyenBay.Text = "Thông tin chuyến bay";
            // 
            // dtpkThoiGianHaCanh
            // 
            this.dtpkThoiGianHaCanh.CustomFormat = "dd/MM/yyyy - h:mm:ss tt ";
            this.dtpkThoiGianHaCanh.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpkThoiGianHaCanh.Location = new System.Drawing.Point(155, 246);
            this.dtpkThoiGianHaCanh.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtpkThoiGianHaCanh.Name = "dtpkThoiGianHaCanh";
            this.dtpkThoiGianHaCanh.Size = new System.Drawing.Size(217, 22);
            this.dtpkThoiGianHaCanh.TabIndex = 39;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 250);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 17);
            this.label2.TabIndex = 38;
            this.label2.Text = "Thời gian hạ cánh";
            // 
            // dtpkThoiGianKhoiHanh
            // 
            this.dtpkThoiGianKhoiHanh.CustomFormat = "dd/MM/yyyy - h:mm:ss tt ";
            this.dtpkThoiGianKhoiHanh.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpkThoiGianKhoiHanh.Location = new System.Drawing.Point(155, 209);
            this.dtpkThoiGianKhoiHanh.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtpkThoiGianKhoiHanh.Name = "dtpkThoiGianKhoiHanh";
            this.dtpkThoiGianKhoiHanh.Size = new System.Drawing.Size(217, 22);
            this.dtpkThoiGianKhoiHanh.TabIndex = 37;
            // 
            // txtMaChuyenBay
            // 
            this.txtMaChuyenBay.Location = new System.Drawing.Point(155, 25);
            this.txtMaChuyenBay.Margin = new System.Windows.Forms.Padding(4);
            this.txtMaChuyenBay.Name = "txtMaChuyenBay";
            this.txtMaChuyenBay.ReadOnly = true;
            this.txtMaChuyenBay.Size = new System.Drawing.Size(217, 22);
            this.txtMaChuyenBay.TabIndex = 33;
            // 
            // cboMaMayBay
            // 
            this.cboMaMayBay.FormattingEnabled = true;
            this.cboMaMayBay.Location = new System.Drawing.Point(155, 172);
            this.cboMaMayBay.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cboMaMayBay.Name = "cboMaMayBay";
            this.cboMaMayBay.Size = new System.Drawing.Size(217, 24);
            this.cboMaMayBay.TabIndex = 36;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(7, 142);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(88, 17);
            this.label15.TabIndex = 26;
            this.label15.Text = "Sân bay đến";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(7, 105);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(75, 17);
            this.label14.TabIndex = 26;
            this.label14.Text = "Sân bay đi";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(7, 68);
            this.label27.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(93, 17);
            this.label27.TabIndex = 26;
            this.label27.Text = "Mã tuyến bay";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(7, 31);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(104, 17);
            this.label8.TabIndex = 26;
            this.label8.Text = "Mã chuyến bay";
            // 
            // cboSanBayDen
            // 
            this.cboSanBayDen.FormattingEnabled = true;
            this.cboSanBayDen.Location = new System.Drawing.Point(155, 135);
            this.cboSanBayDen.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cboSanBayDen.Name = "cboSanBayDen";
            this.cboSanBayDen.Size = new System.Drawing.Size(217, 24);
            this.cboSanBayDen.TabIndex = 36;
            // 
            // cboSanBayDi
            // 
            this.cboSanBayDi.FormattingEnabled = true;
            this.cboSanBayDi.Location = new System.Drawing.Point(155, 98);
            this.cboSanBayDi.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cboSanBayDi.Name = "cboSanBayDi";
            this.cboSanBayDi.Size = new System.Drawing.Size(217, 24);
            this.cboSanBayDi.TabIndex = 36;
            // 
            // cboMaTuyenBay
            // 
            this.cboMaTuyenBay.FormattingEnabled = true;
            this.cboMaTuyenBay.Location = new System.Drawing.Point(155, 62);
            this.cboMaTuyenBay.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cboMaTuyenBay.Name = "cboMaTuyenBay";
            this.cboMaTuyenBay.Size = new System.Drawing.Size(217, 24);
            this.cboMaTuyenBay.TabIndex = 36;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(8, 178);
            this.label24.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(84, 17);
            this.label24.TabIndex = 30;
            this.label24.Text = "Mã máy bay";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(8, 215);
            this.label25.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(133, 17);
            this.label25.TabIndex = 31;
            this.label25.Text = "Thời gian khởi hành";
            // 
            // frmQuanLyChuyenBay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1262, 673);
            this.Controls.Add(this.gbxThemHangVeChoChuyenBay);
            this.Controls.Add(this.gbxThaoTac);
            this.Controls.Add(this.gbxDSChuyenBay);
            this.Controls.Add(this.gbxTTChuyenBay);
            this.Controls.Add(this.panel1);
            this.Name = "frmQuanLyChuyenBay";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản Lý Chuyến Bay";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.gbxThemHangVeChoChuyenBay.ResumeLayout(false);
            this.gbxThemHangVeChoChuyenBay.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvHangVe)).EndInit();
            this.gbxThaoTac.ResumeLayout(false);
            this.gbxDSChuyenBay.ResumeLayout(false);
            this.gbxDSChuyenBay.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvChuyenBay)).EndInit();
            this.gbxTTChuyenBay.ResumeLayout(false);
            this.gbxTTChuyenBay.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbxThemHangVeChoChuyenBay;
        private System.Windows.Forms.DataGridView dtgvHangVe;
        private System.Windows.Forms.ComboBox cboMaHangVe;
        private System.Windows.Forms.TextBox txtTongSoGhe;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox gbxThaoTac;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.GroupBox gbxDSChuyenBay;
        private System.Windows.Forms.DataGridView dtgvChuyenBay;
        private System.Windows.Forms.GroupBox gbxTTChuyenBay;
        private System.Windows.Forms.DateTimePicker dtpkThoiGianHaCanh;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpkThoiGianKhoiHanh;
        private System.Windows.Forms.TextBox txtMaChuyenBay;
        private System.Windows.Forms.ComboBox cboMaMayBay;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cboSanBayDen;
        private System.Windows.Forms.ComboBox cboSanBayDi;
        private System.Windows.Forms.ComboBox cboMaTuyenBay;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Button btnXoaHV;
        private System.Windows.Forms.Button btnSuaHV;
        private System.Windows.Forms.Button btnThemHV;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.Button btnThoat;
    }
}