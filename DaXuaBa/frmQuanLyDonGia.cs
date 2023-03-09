using BUS;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DaXuaBa
{
    public partial class frmQuanLyDonGia : Form
    {
        SqlConnection conn = new SqlConnection(Properties.Settings.Default.connStr);
        PriceBUS pricebus = new PriceBUS();
        
        public frmQuanLyDonGia()
        {
            InitializeComponent();
        }        

        private void frmQuanLyDonGia_Load(object sender, EventArgs e)
        {
            DataTable dtMayBay = pricebus.GetDataPrice();
            dtgvDonGia.DataSource = dtMayBay;
            dtgvDonGia.Columns[0].HeaderText = "Mã tuyến bay";
            dtgvDonGia.Columns[1].HeaderText = "Tên hạng vé";
            dtgvDonGia.Columns[2].HeaderText = "Đơn giá";
            dtgvDonGia.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgvDonGia.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Parent.Dispose();
        }
    }
}
