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
    public partial class frmQuanLyTuyenBay : Form
    {
        SqlConnection conn = new SqlConnection(Properties.Settings.Default.connStr);
        FlightRouteBUS flightroutebus = new FlightRouteBUS();
        AirportBUS airportbus = new AirportBUS();
        
        public frmQuanLyTuyenBay()
        {
            InitializeComponent();
        }
        
        private void dtgvTuyenBay_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
                return;
            DataGridViewRow row = dtgvTuyenBay.Rows[e.RowIndex];
            txtMaTuyenBay.Text = row.Cells[0].Value.ToString();
            cboSanBayDi.Text = row.Cells[2].Value.ToString();
            cboSanBayDen.Text = row.Cells[4].Value.ToString();
        }

        private void frmQuanLyTuyenBay_Load(object sender, EventArgs e)
        {
            DataTable dtData = flightroutebus.GetDataFlightRoute();
            dtgvTuyenBay.DataSource = dtData;
            dtgvTuyenBay.Columns[0].HeaderText = "Mã tuyến bay";
            dtgvTuyenBay.Columns[1].HeaderText = "Mã sân bay đi";
            dtgvTuyenBay.Columns[2].HeaderText = "Tên sân bay đi";
            dtgvTuyenBay.Columns[3].HeaderText = "Mã sân bay đến";
            dtgvTuyenBay.Columns[4].HeaderText = "Tên sân bay đến";
            dtgvTuyenBay.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgvTuyenBay.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;

            DataTable dtSanBayDen = airportbus.GetDataAirport();
            DataTable dtSanBayDi = airportbus.GetDataAirport();

            cboSanBayDi.DataSource = dtSanBayDen;
            cboSanBayDi.DisplayMember = "nameAirport";
            cboSanBayDi.ValueMember = "idAirport";

            cboSanBayDen.DataSource = dtSanBayDi;
            cboSanBayDen.DisplayMember = "nameAirport";
            cboSanBayDen.ValueMember = "idAirport";
          
            cboSanBayDen.Focus();
        }              

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Parent.Dispose();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (cboSanBayDen.Text != "" && cboSanBayDi.Text != "")
            {
                if (cboSanBayDi.Text == cboSanBayDen.Text)
                {
                    MessageBox.Show("Sân bay đến và sân bay đi phải khác nhau!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                try
                {
                    FlightRouteDTO dto = new FlightRouteDTO(txtMaTuyenBay.Text, cboSanBayDi.SelectedValue.ToString(), cboSanBayDen.SelectedValue.ToString());
                    if (flightroutebus.InsertFlightRoute(dto))
                        MessageBox.Show("Thêm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                        MessageBox.Show("Thêm không thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                catch
                {
                    MessageBox.Show("Thêm không thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    dtgvTuyenBay.DataSource = flightroutebus.GetDataFlightRoute();
                }
            }
            else
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (txtMaTuyenBay.Text != "")
            {
                if (cboSanBayDen.Text != "" && cboSanBayDi.Text != "")
                {
                    if (cboSanBayDi.Text == cboSanBayDen.Text)
                    {
                        MessageBox.Show("Sân bay đến và sân bay đi phải khác nhau!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    try
                    {
                        FlightRouteDTO dto = new FlightRouteDTO(txtMaTuyenBay.Text, cboSanBayDi.SelectedValue.ToString(), cboSanBayDen.SelectedValue.ToString());
                        if (flightroutebus.UpdateFlightRoute(dto))
                            MessageBox.Show("Sửa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        else
                            MessageBox.Show("Sửa không thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    catch
                    {
                        MessageBox.Show("Sửa không thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        dtgvTuyenBay.DataSource = flightroutebus.GetDataFlightRoute();
                    }
                }
                else
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một hàng trong danh sách!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (txtMaTuyenBay.Text != "")
            {
                try
                {
                    FlightRouteDTO dto = new FlightRouteDTO(txtMaTuyenBay.Text, cboSanBayDi.SelectedValue.ToString(), cboSanBayDen.SelectedValue.ToString());
                    if (flightroutebus.DeleteFlightRoute(dto))
                        MessageBox.Show("Xóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                        MessageBox.Show("Xóa không thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                catch
                {
                    MessageBox.Show("Xóa không thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    dtgvTuyenBay.DataSource = flightroutebus.GetDataFlightRoute(); ;
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một hàng trong danh sách!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
