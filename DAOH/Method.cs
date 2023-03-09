using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DAO
{
    public class Method
    {
        SqlConnection conn = new SqlConnection(Properties.Settings.Default.connStr);
        public DataTable DanhSach(string query)
        {
            try
            {
                conn.Open();               
                string sqlStr = string.Format(query);
                SqlDataAdapter adapter = new SqlDataAdapter(sqlStr, conn);
                DataTable dtData = new DataTable();
                adapter.Fill(dtData);
                return dtData;
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
            finally
            {
                conn.Close();
            }
            return null;
        }

        public DataTable ThucThi(string query)
        {
            DataTable data = new DataTable();
            try
            {
                conn.Open();
                SqlCommand command = new SqlCommand(query, conn);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(data);
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
            finally
            {
                conn.Close();
            }
            return data;
        }

        public int ThucThiNon(string query)
        {
            int data = 0;
            try
            {
                conn.Open();
                SqlCommand command = new SqlCommand(query, conn);
                data = command.ExecuteNonQuery();
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
            finally
            {
                conn.Close();
            }
            return data;
        }
    }
}

