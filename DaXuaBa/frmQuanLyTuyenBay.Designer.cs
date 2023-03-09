
namespace DaXuaBa
{
    partial class frmQuanLyTuyenBay
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
            this.label1 = new System.Windows.Forms.Label();
            this.gbxDSTuyenBay = new System.Windows.Forms.GroupBox();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.dtgvTuyenBay = new System.Windows.Forms.DataGridView();
            this.gbxTTTuyenBay = new System.Windows.Forms.GroupBox();
            this.cboSanBayDen = new System.Windows.Forms.ComboBox();
            this.cboSanBayDi = new System.Windows.Forms.ComboBox();
            this.label20 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.txtMaTuyenBay = new System.Windows.Forms.TextBox();
            this.gbxThaoTac = new System.Windows.Forms.GroupBox();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.gbxDSTuyenBay.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvTuyenBay)).BeginInit();
            this.gbxTTTuyenBay.SuspendLayout();
            this.gbxThaoTac.SuspendLayout();
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
            this.panel1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("#9Slide03 Roboto Slab", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(447, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(367, 44);
            this.label1.TabIndex = 0;
            this.label1.Text = "QUẢN LÝ TUYẾN BAY";
            // 
            // gbxDSTuyenBay
            // 
            this.gbxDSTuyenBay.Controls.Add(this.btnTimKiem);
            this.gbxDSTuyenBay.Controls.Add(this.txtTimKiem);
            this.gbxDSTuyenBay.Controls.Add(this.dtgvTuyenBay);
            this.gbxDSTuyenBay.Location = new System.Drawing.Point(397, 59);
            this.gbxDSTuyenBay.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbxDSTuyenBay.Name = "gbxDSTuyenBay";
            this.gbxDSTuyenBay.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbxDSTuyenBay.Size = new System.Drawing.Size(853, 602);
            this.gbxDSTuyenBay.TabIndex = 5;
            this.gbxDSTuyenBay.TabStop = false;
            this.gbxDSTuyenBay.Text = "Danh sách tuyến bay";
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Location = new System.Drawing.Point(700, 35);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(85, 23);
            this.btnTimKiem.TabIndex = 11;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Location = new System.Drawing.Point(450, 35);
            this.txtTimKiem.Margin = new System.Windows.Forms.Padding(4);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(207, 22);
            this.txtTimKiem.TabIndex = 9;
            // 
            // dtgvTuyenBay
            // 
            this.dtgvTuyenBay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvTuyenBay.Location = new System.Drawing.Point(5, 63);
            this.dtgvTuyenBay.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtgvTuyenBay.Name = "dtgvTuyenBay";
            this.dtgvTuyenBay.RowHeadersWidth = 82;
            this.dtgvTuyenBay.RowTemplate.Height = 24;
            this.dtgvTuyenBay.Size = new System.Drawing.Size(843, 533);
            this.dtgvTuyenBay.TabIndex = 8;
            this.dtgvTuyenBay.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvTuyenBay_CellClick);
            // 
            // gbxTTTuyenBay
            // 
            this.gbxTTTuyenBay.Controls.Add(this.cboSanBayDen);
            this.gbxTTTuyenBay.Controls.Add(this.cboSanBayDi);
            this.gbxTTTuyenBay.Controls.Add(this.label20);
            this.gbxTTTuyenBay.Controls.Add(this.label18);
            this.gbxTTTuyenBay.Controls.Add(this.label19);
            this.gbxTTTuyenBay.Controls.Add(this.txtMaTuyenBay);
            this.gbxTTTuyenBay.Location = new System.Drawing.Point(12, 59);
            this.gbxTTTuyenBay.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbxTTTuyenBay.Name = "gbxTTTuyenBay";
            this.gbxTTTuyenBay.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbxTTTuyenBay.Size = new System.Drawing.Size(380, 243);
            this.gbxTTTuyenBay.TabIndex = 4;
            this.gbxTTTuyenBay.TabStop = false;
            this.gbxTTTuyenBay.Text = "Thông tin tuyến bay";
            // 
            // cboSanBayDen
            // 
            this.cboSanBayDen.FormattingEnabled = true;
            this.cboSanBayDen.Location = new System.Drawing.Point(159, 144);
            this.cboSanBayDen.Name = "cboSanBayDen";
            this.cboSanBayDen.Size = new System.Drawing.Size(200, 24);
            this.cboSanBayDen.TabIndex = 21;
            // 
            // cboSanBayDi
            // 
            this.cboSanBayDi.FormattingEnabled = true;
            this.cboSanBayDi.Location = new System.Drawing.Point(159, 99);
            this.cboSanBayDi.Name = "cboSanBayDi";
            this.cboSanBayDi.Size = new System.Drawing.Size(200, 24);
            this.cboSanBayDi.TabIndex = 20;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(28, 57);
            this.label20.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(97, 17);
            this.label20.TabIndex = 15;
            this.label20.Text = "Mã tuyến bay ";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(28, 147);
            this.label18.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(88, 17);
            this.label18.TabIndex = 13;
            this.label18.Text = "Sân bay đến";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(41, 102);
            this.label19.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(75, 17);
            this.label19.TabIndex = 16;
            this.label19.Text = "Sân bay đi";
            // 
            // txtMaTuyenBay
            // 
            this.txtMaTuyenBay.Location = new System.Drawing.Point(159, 52);
            this.txtMaTuyenBay.Margin = new System.Windows.Forms.Padding(4);
            this.txtMaTuyenBay.Name = "txtMaTuyenBay";
            this.txtMaTuyenBay.Size = new System.Drawing.Size(200, 22);
            this.txtMaTuyenBay.TabIndex = 17;
            this.txtMaTuyenBay.TabStop = false;
            // 
            // gbxThaoTac
            // 
            this.gbxThaoTac.Controls.Add(this.btnXoa);
            this.gbxThaoTac.Controls.Add(this.btnSua);
            this.gbxThaoTac.Controls.Add(this.btnThem);
            this.gbxThaoTac.Location = new System.Drawing.Point(12, 310);
            this.gbxThaoTac.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbxThaoTac.Name = "gbxThaoTac";
            this.gbxThaoTac.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbxThaoTac.Size = new System.Drawing.Size(380, 161);
            this.gbxThaoTac.TabIndex = 76;
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
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(139, 42);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 40);
            this.btnSua.TabIndex = 15;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.BackgroundImage = global::DaXuaBa.Properties.Resources.them1;
            this.btnThem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnThem.Location = new System.Drawing.Point(36, 42);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 60);
            this.btnThem.TabIndex = 14;
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
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
            // frmQuanLyTuyenBay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1262, 673);
            this.Controls.Add(this.gbxThaoTac);
            this.Controls.Add(this.gbxDSTuyenBay);
            this.Controls.Add(this.gbxTTTuyenBay);
            this.Controls.Add(this.panel1);
            this.Name = "frmQuanLyTuyenBay";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản Lý Tuyến Bay";
            this.Load += new System.EventHandler(this.frmQuanLyTuyenBay_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.gbxDSTuyenBay.ResumeLayout(false);
            this.gbxDSTuyenBay.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvTuyenBay)).EndInit();
            this.gbxTTTuyenBay.ResumeLayout(false);
            this.gbxTTTuyenBay.PerformLayout();
            this.gbxThaoTac.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbxDSTuyenBay;
        private System.Windows.Forms.DataGridView dtgvTuyenBay;
        private System.Windows.Forms.GroupBox gbxTTTuyenBay;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox txtMaTuyenBay;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.GroupBox gbxThaoTac;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.ComboBox cboSanBayDen;
        private System.Windows.Forms.ComboBox cboSanBayDi;
    }
}