
namespace DaXuaBa
{
    partial class frmQuanLySanBay
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
            this.gbxDSSanBay = new System.Windows.Forms.GroupBox();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.dtgvSanBay = new System.Windows.Forms.DataGridView();
            this.gbxTTSanBay = new System.Windows.Forms.GroupBox();
            this.txtMaSanBay = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.txtTenThanhPho = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.txtTenSanBay = new System.Windows.Forms.TextBox();
            this.gbxThaoTac = new System.Windows.Forms.GroupBox();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.gbxDSSanBay.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvSanBay)).BeginInit();
            this.gbxTTSanBay.SuspendLayout();
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
            this.label1.Location = new System.Drawing.Point(470, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(321, 44);
            this.label1.TabIndex = 0;
            this.label1.Text = "QUẢN LÝ SÂN BAY";
            // 
            // gbxDSSanBay
            // 
            this.gbxDSSanBay.Controls.Add(this.btnTimKiem);
            this.gbxDSSanBay.Controls.Add(this.txtTimKiem);
            this.gbxDSSanBay.Controls.Add(this.dtgvSanBay);
            this.gbxDSSanBay.Location = new System.Drawing.Point(397, 65);
            this.gbxDSSanBay.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbxDSSanBay.Name = "gbxDSSanBay";
            this.gbxDSSanBay.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbxDSSanBay.Size = new System.Drawing.Size(853, 602);
            this.gbxDSSanBay.TabIndex = 5;
            this.gbxDSSanBay.TabStop = false;
            this.gbxDSSanBay.Text = "Danh sách sân bay";
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
            // dtgvSanBay
            // 
            this.dtgvSanBay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvSanBay.Location = new System.Drawing.Point(5, 63);
            this.dtgvSanBay.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtgvSanBay.Name = "dtgvSanBay";
            this.dtgvSanBay.RowHeadersWidth = 82;
            this.dtgvSanBay.RowTemplate.Height = 24;
            this.dtgvSanBay.Size = new System.Drawing.Size(843, 533);
            this.dtgvSanBay.TabIndex = 8;
            this.dtgvSanBay.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvSanBay_CellClick);
            // 
            // gbxTTSanBay
            // 
            this.gbxTTSanBay.Controls.Add(this.txtMaSanBay);
            this.gbxTTSanBay.Controls.Add(this.label18);
            this.gbxTTSanBay.Controls.Add(this.txtTenThanhPho);
            this.gbxTTSanBay.Controls.Add(this.label20);
            this.gbxTTSanBay.Controls.Add(this.label19);
            this.gbxTTSanBay.Controls.Add(this.txtTenSanBay);
            this.gbxTTSanBay.Location = new System.Drawing.Point(12, 59);
            this.gbxTTSanBay.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbxTTSanBay.Name = "gbxTTSanBay";
            this.gbxTTSanBay.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbxTTSanBay.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.gbxTTSanBay.Size = new System.Drawing.Size(380, 204);
            this.gbxTTSanBay.TabIndex = 4;
            this.gbxTTSanBay.TabStop = false;
            this.gbxTTSanBay.Text = "Thông tin sân bay";
            // 
            // txtMaSanBay
            // 
            this.txtMaSanBay.Location = new System.Drawing.Point(145, 25);
            this.txtMaSanBay.Margin = new System.Windows.Forms.Padding(4);
            this.txtMaSanBay.Name = "txtMaSanBay";
            this.txtMaSanBay.Size = new System.Drawing.Size(220, 22);
            this.txtMaSanBay.TabIndex = 47;
            this.txtMaSanBay.TabStop = false;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(11, 94);
            this.label18.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(101, 17);
            this.label18.TabIndex = 43;
            this.label18.Text = "Tên thành phố";
            // 
            // txtTenThanhPho
            // 
            this.txtTenThanhPho.Location = new System.Drawing.Point(145, 89);
            this.txtTenThanhPho.Margin = new System.Windows.Forms.Padding(4);
            this.txtTenThanhPho.Name = "txtTenThanhPho";
            this.txtTenThanhPho.Size = new System.Drawing.Size(220, 22);
            this.txtTenThanhPho.TabIndex = 2;
            this.txtTenThanhPho.Tag = "2";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(30, 30);
            this.label20.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(81, 17);
            this.label20.TabIndex = 45;
            this.label20.Text = "Mã sân bay";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(24, 62);
            this.label19.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(87, 17);
            this.label19.TabIndex = 46;
            this.label19.Text = "Tên sân bay";
            // 
            // txtTenSanBay
            // 
            this.txtTenSanBay.Location = new System.Drawing.Point(145, 57);
            this.txtTenSanBay.Margin = new System.Windows.Forms.Padding(4);
            this.txtTenSanBay.Name = "txtTenSanBay";
            this.txtTenSanBay.Size = new System.Drawing.Size(220, 22);
            this.txtTenSanBay.TabIndex = 1;
            this.txtTenSanBay.Tag = "";
            // 
            // gbxThaoTac
            // 
            this.gbxThaoTac.Controls.Add(this.btnXoa);
            this.gbxThaoTac.Controls.Add(this.btnSua);
            this.gbxThaoTac.Controls.Add(this.btnThem);
            this.gbxThaoTac.Location = new System.Drawing.Point(12, 271);
            this.gbxThaoTac.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbxThaoTac.Name = "gbxThaoTac";
            this.gbxThaoTac.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbxThaoTac.Size = new System.Drawing.Size(380, 101);
            this.gbxThaoTac.TabIndex = 75;
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
            this.btnThem.Location = new System.Drawing.Point(36, 42);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 40);
            this.btnThem.TabIndex = 14;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // frmQuanLySanBay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1262, 673);
            this.Controls.Add(this.gbxThaoTac);
            this.Controls.Add(this.gbxDSSanBay);
            this.Controls.Add(this.gbxTTSanBay);
            this.Controls.Add(this.panel1);
            this.Name = "frmQuanLySanBay";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản Lý Sân Bay";
            this.Load += new System.EventHandler(this.frmQuanLySanBay_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.gbxDSSanBay.ResumeLayout(false);
            this.gbxDSSanBay.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvSanBay)).EndInit();
            this.gbxTTSanBay.ResumeLayout(false);
            this.gbxTTSanBay.PerformLayout();
            this.gbxThaoTac.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbxDSSanBay;
        private System.Windows.Forms.DataGridView dtgvSanBay;
        private System.Windows.Forms.GroupBox gbxTTSanBay;
        private System.Windows.Forms.TextBox txtMaSanBay;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox txtTenThanhPho;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox txtTenSanBay;
        private System.Windows.Forms.GroupBox gbxThaoTac;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.Button btnThoat;
    }
}