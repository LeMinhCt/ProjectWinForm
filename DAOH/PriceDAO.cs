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
    public class PriceDAO : Method
    {
        SqlConnection conn = new SqlConnection(Properties.Settings.Default.connStr);

        public DataTable GetDataPrice()
        {
            string query = " SELECT * FROM Prices";
            DataTable dtData = ThucThi(query);
            return dtData;
        }

        //public object GetPriceByIdFlightAndIdTicketClass(int price)
        //{       
        //    try
        //    {
        //        conn.Open();
        //        string query = " select" + price + "= unitPrice" +
        //            "FROM dbo.Flights" +
        //            "INNER JOIN dbo.Prices" +
        //            "ON Prices.idFlightRoutes = Flights.idFlightRoutes" +
        //            "WHERE idFlights = @idFlight AND idTicketClass = @idTicketClass" +
        //            "return" + price;
        //        string sqlStr = string.Format(query);                              
        //         SqlDataAdapter adapter = new SqlDataAdapter(sqlStr, conn);
        //         DataTable dtData = new DataTable();
        //         adapter.Fill(dtData);
        //    return dtData;
        //    }
        //    catch (Exception exc)
        //    {
        //        MessageBox.Show(exc.Message);
        //    }
        //    finally
        //    {
        //        conn.Close();
        //    }
        //    return null;
        //}
    }
}