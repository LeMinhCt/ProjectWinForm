using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DAO
{
    public class TicketClassDAO : Method
    {
        SqlConnection conn = new SqlConnection(Properties.Settings.Default.connStr);

        public DataTable GetDataTicketClass(string temp)
        {
            return DanhSach(temp);
        }

        public void InsertTicketClass(TicketClassDTO dto)
        {
            try
            {
                conn.Open();
                string sqlStr = String.Format("INSERT INTO TicketClasses (idTicketClass, nameTicketClass) VALUES ('{0}', '{1}')", dto.IdTicketClass, dto.NameTicketClass);
                SqlCommand cmd = new SqlCommand(sqlStr, conn);

                if (cmd.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("Thêm thành công");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Thêm thất bại" + ex);
            }
            finally
            {
                conn.Close();
            }
        }

        public void UpdateTicketClass(TicketClassDTO dto)
        {
            try
            {
                conn.Open();
                string sqlStr = string.Format("UPDATE TicketClasses set nameTicketClass = '{1}' where idTicketClass = '{0}'", dto.IdTicketClass, dto.NameTicketClass);
                SqlCommand cmd = new SqlCommand(sqlStr, conn);
                if (cmd.ExecuteNonQuery() > 0)

                    MessageBox.Show("Sửa thành công");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Sửa thất bại" + ex);
            }
            finally
            {
                conn.Close();
            }
        }

        public void DeleteTicketClass(TicketClassDTO dto)
        {
            try
            {
                conn.Open();
                string sqlStr = string.Format("DELETE FROM TicketClasses WHERE idTicketClass = '" + dto.IdTicketClass + "'");
                SqlCommand cmd = new SqlCommand(sqlStr, conn);
                if (cmd.ExecuteNonQuery() > 0)

                    MessageBox.Show("Xóa thành công");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Xóa thất bại" + ex);
            }
            finally
            {
                conn.Close();
            }
        }

    }
}
