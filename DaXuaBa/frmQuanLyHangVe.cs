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
    public partial class frmQuanLyHangVe : Form
    {
        SqlConnection conn = new SqlConnection(Properties.Settings.Default.connStr);
        TicketClassBUS TicketClassBUS = new TicketClassBUS();
        string temp = "TicketClasses";
        public frmQuanLyHangVe()
        {
            InitializeComponent();
        }

        private void dtgvHangVe_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = new DataGridViewRow();
            row = dtgvHangVe.Rows[e.RowIndex];
            txtMaHangVe.Text = Convert.ToString(row.Cells["idTicketClass"].Value);
            txtTenHangVe.Text = Convert.ToString(row.Cells["nameTicketClass"].Value);
        }

        private void frmQuanLyHangVe_Load(object sender, EventArgs e)
        {
            TicketClassBUS.GetDataTicketClass(temp);
            dtgvHangVe.DataSource = TicketClassBUS.DanhSach(temp);
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtMaHangVe.Text != "" && txtTenHangVe.Text != "")
            {
                TicketClassDTO ticketClassBUS = new TicketClassDTO(txtMaHangVe.Text, txtTenHangVe.Text);
                TicketClassBUS.InsertTicketClass(ticketClassBUS);
                dtgvHangVe.DataSource = TicketClassBUS.DanhSach(temp);
            }
            else
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin");
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (txtMaHangVe.Text != "" && txtTenHangVe.Text != "")
            {
                TicketClassDTO ticketClassBUS = new TicketClassDTO(txtMaHangVe.Text, txtTenHangVe.Text);
                TicketClassBUS.UpdateTicketClass(ticketClassBUS);
                dtgvHangVe.DataSource = TicketClassBUS.DanhSach(temp);
            }
            else
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            TicketClassDTO ticketClassBUS = new TicketClassDTO(txtMaHangVe.Text, txtTenHangVe.Text);
            TicketClassBUS.DeleteTicketClass(ticketClassBUS);
            dtgvHangVe.DataSource = TicketClassBUS.DanhSach(temp);
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Parent.Dispose();
        }
    }
}
