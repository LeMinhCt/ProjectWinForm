﻿
namespace DaXuaBa
{
    partial class frmQuanLyMayBay
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
            this.gbxDSMayBay = new System.Windows.Forms.GroupBox();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.dtgvMayBay = new System.Windows.Forms.DataGridView();
            this.gbxTTMayBay = new System.Windows.Forms.GroupBox();
            this.txtSoLuongGhe = new System.Windows.Forms.TextBox();
            this.txtTenMayBay = new System.Windows.Forms.TextBox();
            this.txtMaMayBay = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.gbxThaoTac = new System.Windows.Forms.GroupBox();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.gbxDSMayBay.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvMayBay)).BeginInit();
            this.gbxTTMayBay.SuspendLayout();
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
            this.label1.Location = new System.Drawing.Point(470, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(330, 44);
            this.label1.TabIndex = 0;
            this.label1.Text = "QUẢN LÝ MÁY BAY";
            // 
            // gbxDSMayBay
            // 
            this.gbxDSMayBay.Controls.Add(this.btnTimKiem);
            this.gbxDSMayBay.Controls.Add(this.txtTimKiem);
            this.gbxDSMayBay.Controls.Add(this.dtgvMayBay);
            this.gbxDSMayBay.Location = new System.Drawing.Point(397, 59);
            this.gbxDSMayBay.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbxDSMayBay.Name = "gbxDSMayBay";
            this.gbxDSMayBay.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbxDSMayBay.Size = new System.Drawing.Size(853, 602);
            this.gbxDSMayBay.TabIndex = 5;
            this.gbxDSMayBay.TabStop = false;
            this.gbxDSMayBay.Text = "Danh sách máy bay";
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
            // dtgvMayBay
            // 
            this.dtgvMayBay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvMayBay.Location = new System.Drawing.Point(5, 63);
            this.dtgvMayBay.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtgvMayBay.Name = "dtgvMayBay";
            this.dtgvMayBay.RowHeadersWidth = 82;
            this.dtgvMayBay.RowTemplate.Height = 24;
            this.dtgvMayBay.Size = new System.Drawing.Size(843, 533);
            this.dtgvMayBay.TabIndex = 8;
            this.dtgvMayBay.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvMayBay_CellClick);
            // 
            // gbxTTMayBay
            // 
            this.gbxTTMayBay.Controls.Add(this.txtSoLuongGhe);
            this.gbxTTMayBay.Controls.Add(this.txtTenMayBay);
            this.gbxTTMayBay.Controls.Add(this.txtMaMayBay);
            this.gbxTTMayBay.Controls.Add(this.label18);
            this.gbxTTMayBay.Controls.Add(this.label20);
            this.gbxTTMayBay.Controls.Add(this.label19);
            this.gbxTTMayBay.Location = new System.Drawing.Point(12, 59);
            this.gbxTTMayBay.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbxTTMayBay.Name = "gbxTTMayBay";
            this.gbxTTMayBay.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbxTTMayBay.Size = new System.Drawing.Size(380, 203);
            this.gbxTTMayBay.TabIndex = 4;
            this.gbxTTMayBay.TabStop = false;
            this.gbxTTMayBay.Text = "Thông tin máy bay";
            // 
            // txtSoLuongGhe
            // 
            this.txtSoLuongGhe.Location = new System.Drawing.Point(141, 86);
            this.txtSoLuongGhe.Margin = new System.Windows.Forms.Padding(4);
            this.txtSoLuongGhe.Name = "txtSoLuongGhe";
            this.txtSoLuongGhe.Size = new System.Drawing.Size(232, 22);
            this.txtSoLuongGhe.TabIndex = 2;
            // 
            // txtTenMayBay
            // 
            this.txtTenMayBay.Location = new System.Drawing.Point(141, 52);
            this.txtTenMayBay.Margin = new System.Windows.Forms.Padding(4);
            this.txtTenMayBay.Name = "txtTenMayBay";
            this.txtTenMayBay.Size = new System.Drawing.Size(232, 22);
            this.txtTenMayBay.TabIndex = 1;
            // 
            // txtMaMayBay
            // 
            this.txtMaMayBay.Location = new System.Drawing.Point(141, 22);
            this.txtMaMayBay.Margin = new System.Windows.Forms.Padding(4);
            this.txtMaMayBay.Name = "txtMaMayBay";
            this.txtMaMayBay.Size = new System.Drawing.Size(232, 22);
            this.txtMaMayBay.TabIndex = 47;
            this.txtMaMayBay.TabStop = false;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(7, 91);
            this.label18.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(92, 17);
            this.label18.TabIndex = 44;
            this.label18.Text = "Số lượng ghế";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(7, 27);
            this.label20.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(88, 17);
            this.label20.TabIndex = 45;
            this.label20.Text = "Mã máy bay ";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(7, 59);
            this.label19.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(90, 17);
            this.label19.TabIndex = 46;
            this.label19.Text = "Tên máy bay";
            // 
            // gbxThaoTac
            // 
            this.gbxThaoTac.Controls.Add(this.btnXoa);
            this.gbxThaoTac.Controls.Add(this.btnSua);
            this.gbxThaoTac.Controls.Add(this.btnThem);
            this.gbxThaoTac.Location = new System.Drawing.Point(12, 270);
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
            // frmQuanLyMayBay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1262, 673);
            this.Controls.Add(this.gbxThaoTac);
            this.Controls.Add(this.gbxDSMayBay);
            this.Controls.Add(this.gbxTTMayBay);
            this.Controls.Add(this.panel1);
            this.Name = "frmQuanLyMayBay";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản Lý Máy Bay";
            this.Load += new System.EventHandler(this.frmQuanLyMayBay_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.gbxDSMayBay.ResumeLayout(false);
            this.gbxDSMayBay.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvMayBay)).EndInit();
            this.gbxTTMayBay.ResumeLayout(false);
            this.gbxTTMayBay.PerformLayout();
            this.gbxThaoTac.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbxDSMayBay;
        private System.Windows.Forms.DataGridView dtgvMayBay;
        private System.Windows.Forms.GroupBox gbxTTMayBay;
        private System.Windows.Forms.TextBox txtSoLuongGhe;
        private System.Windows.Forms.TextBox txtTenMayBay;
        private System.Windows.Forms.TextBox txtMaMayBay;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.GroupBox gbxThaoTac;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.Button btnThoat;
    }
}