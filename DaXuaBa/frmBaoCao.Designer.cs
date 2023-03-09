
namespace DaXuaBa
{
    partial class frmBaoCao
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cboIDStaff = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnViewRP2 = new System.Windows.Forms.Button();
            this.dtgvReport2 = new System.Windows.Forms.DataGridView();
            this.gbxDSChuyenBay = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMonth = new System.Windows.Forms.TextBox();
            this.dtgvReport1 = new System.Windows.Forms.DataGridView();
            this.txtYear = new System.Windows.Forms.TextBox();
            this.btnViewRP1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.btnThoat = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvReport2)).BeginInit();
            this.gbxDSChuyenBay.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvReport1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cboIDStaff);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.btnViewRP2);
            this.groupBox1.Controls.Add(this.dtgvReport2);
            this.groupBox1.Location = new System.Drawing.Point(639, 75);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(613, 585);
            this.groupBox1.TabIndex = 135;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Doanh thu theo nhân viên";
            // 
            // cboIDStaff
            // 
            this.cboIDStaff.FormattingEnabled = true;
            this.cboIDStaff.Location = new System.Drawing.Point(195, 38);
            this.cboIDStaff.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cboIDStaff.Name = "cboIDStaff";
            this.cboIDStaff.Size = new System.Drawing.Size(217, 24);
            this.cboIDStaff.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(92, 43);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 17);
            this.label3.TabIndex = 128;
            this.label3.Text = "Mã nhân viên";
            // 
            // btnViewRP2
            // 
            this.btnViewRP2.AutoSize = true;
            this.btnViewRP2.Location = new System.Drawing.Point(424, 36);
            this.btnViewRP2.Margin = new System.Windows.Forms.Padding(4);
            this.btnViewRP2.Name = "btnViewRP2";
            this.btnViewRP2.Size = new System.Drawing.Size(135, 33);
            this.btnViewRP2.TabIndex = 4;
            this.btnViewRP2.Text = "Xem báo cáo";
            this.btnViewRP2.UseVisualStyleBackColor = true;
            // 
            // dtgvReport2
            // 
            this.dtgvReport2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvReport2.Location = new System.Drawing.Point(13, 80);
            this.dtgvReport2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtgvReport2.Name = "dtgvReport2";
            this.dtgvReport2.RowHeadersWidth = 82;
            this.dtgvReport2.RowTemplate.Height = 24;
            this.dtgvReport2.Size = new System.Drawing.Size(587, 492);
            this.dtgvReport2.TabIndex = 47;
            // 
            // gbxDSChuyenBay
            // 
            this.gbxDSChuyenBay.Controls.Add(this.label2);
            this.gbxDSChuyenBay.Controls.Add(this.label1);
            this.gbxDSChuyenBay.Controls.Add(this.txtMonth);
            this.gbxDSChuyenBay.Controls.Add(this.dtgvReport1);
            this.gbxDSChuyenBay.Controls.Add(this.txtYear);
            this.gbxDSChuyenBay.Controls.Add(this.btnViewRP1);
            this.gbxDSChuyenBay.Location = new System.Drawing.Point(12, 75);
            this.gbxDSChuyenBay.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbxDSChuyenBay.Name = "gbxDSChuyenBay";
            this.gbxDSChuyenBay.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbxDSChuyenBay.Size = new System.Drawing.Size(613, 585);
            this.gbxDSChuyenBay.TabIndex = 134;
            this.gbxDSChuyenBay.TabStop = false;
            this.gbxDSChuyenBay.Text = "Doanh thu theo chuyến bay";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(252, 43);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 17);
            this.label2.TabIndex = 126;
            this.label2.Text = "Năm";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(64, 43);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 17);
            this.label1.TabIndex = 125;
            this.label1.Text = "Tháng";
            // 
            // txtMonth
            // 
            this.txtMonth.Location = new System.Drawing.Point(119, 37);
            this.txtMonth.Margin = new System.Windows.Forms.Padding(4);
            this.txtMonth.Name = "txtMonth";
            this.txtMonth.Size = new System.Drawing.Size(121, 22);
            this.txtMonth.TabIndex = 0;
            // 
            // dtgvReport1
            // 
            this.dtgvReport1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvReport1.Location = new System.Drawing.Point(13, 80);
            this.dtgvReport1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtgvReport1.Name = "dtgvReport1";
            this.dtgvReport1.RowHeadersWidth = 82;
            this.dtgvReport1.RowTemplate.Height = 24;
            this.dtgvReport1.Size = new System.Drawing.Size(587, 492);
            this.dtgvReport1.TabIndex = 47;
            // 
            // txtYear
            // 
            this.txtYear.Location = new System.Drawing.Point(295, 37);
            this.txtYear.Margin = new System.Windows.Forms.Padding(4);
            this.txtYear.Name = "txtYear";
            this.txtYear.Size = new System.Drawing.Size(121, 22);
            this.txtYear.TabIndex = 1;
            // 
            // btnViewRP1
            // 
            this.btnViewRP1.AutoSize = true;
            this.btnViewRP1.Location = new System.Drawing.Point(463, 34);
            this.btnViewRP1.Margin = new System.Windows.Forms.Padding(4);
            this.btnViewRP1.Name = "btnViewRP1";
            this.btnViewRP1.Size = new System.Drawing.Size(135, 33);
            this.btnViewRP1.TabIndex = 2;
            this.btnViewRP1.Text = "Xem báo cáo";
            this.btnViewRP1.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Peru;
            this.panel1.Controls.Add(this.btnThoat);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1262, 52);
            this.panel1.TabIndex = 136;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("#9Slide03 Roboto Slab", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(450, 3);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(372, 44);
            this.label4.TabIndex = 0;
            this.label4.Text = "BÁO CÁO DOANH THU";
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
            // 
            // frmBaoCao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1262, 673);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gbxDSChuyenBay);
            this.Name = "frmBaoCao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Báo Cáo";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvReport2)).EndInit();
            this.gbxDSChuyenBay.ResumeLayout(false);
            this.gbxDSChuyenBay.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvReport1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cboIDStaff;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnViewRP2;
        private System.Windows.Forms.DataGridView dtgvReport2;
        private System.Windows.Forms.GroupBox gbxDSChuyenBay;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMonth;
        private System.Windows.Forms.DataGridView dtgvReport1;
        private System.Windows.Forms.TextBox txtYear;
        private System.Windows.Forms.Button btnViewRP1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnThoat;
    }
}