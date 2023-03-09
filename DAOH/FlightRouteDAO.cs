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
    public class FlightRouteDAO : Method
    {
        SqlConnection conn = new SqlConnection(Properties.Settings.Default.connStr);

        public DataTable GetDataFlightRoute()
        {
            string query = ("SELECT idFlightRoutes, AirportToGo.idAirport AS idAirportToGo, AirportToGo.nameAirport AS nameAirportToGo," +
                   "AirportToCome.idAirport AS idAirportToCome, AirportToCome.nameAirport AS nameAirportToCome " +
                   "FROM FlightRoutes " +
                   "INNER JOIN Airports AS AirportToGo " +
                   "ON AirportToGo.idAirport = FlightRoutes.idAirportToGo " +
                   "INNER JOIN Airports AS AirportToCome " +
                   "ON AirportToCome.idAirport = FlightRoutes.idAirportToCome " +
                   "ORDER BY idFlightRoutes");
            DataTable dtData = ThucThi(query);
            return dtData;
        }

        public DataTable GetOfIdFlightRoute(string str)
        {
            string query = String.Format("SELECT idFlightRoutes, AirportToGo.idAirport AS idAirportToGo, AirportToGo.nameAirport AS nameAirportToGo," +
                   "AirportToCome.idAirport AS idAirportToCome, AirportToCome.nameAirport AS nameAirportToCome " +
                   "FROM FlightRoutes " +
                   "INNER JOIN Airports AS AirportToGo " +
                   "ON AirportToGo.idAirport = FlightRoutes.idAirportToGo " +
                   "INNER JOIN Airports AS AirportToCome " +
                   "ON AirportToCome.idAirport = FlightRoutes.idAirportToCome " +
                   "WHERE idFlightRoutes = '{0}'", str);
            DataTable dtData = ThucThi(query);
            return dtData;
        }

            public DataTable GetOfIdAirport(string idToGo, string idToCome)
        {
            string query = String.Format("SELECT * FROM dbo.FlightRoutes\r\n" +
                "WHERE idAirportToGo = '{0}' AND idAirportToCome = '{1}'", idToGo, idToCome);
            DataTable dtData = ThucThi(query);
            return dtData;
        }

        public bool InsertFlightRoute(FlightRouteDTO dto)
        {
            try
            {              
                string query = String.Format("INSERT INTO FlightRoutes (idFlightRoutes, idAirportToGo, idAirportToCome) VALUES ('{0}', '{1}', '{2}')", dto.IdFlightRoutes, dto.IdAirportToGo, dto.IdAirportToCome);
                int result = ThucThiNon(query);
                return result > 0;
            }
            catch
            {
                return false;
            }
        }

        public bool UpdateFlightRoute(FlightRouteDTO dto)
        {
            try
            {
                string query = String.Format("UPDATE FlightRoutes SET idAirportToGo = '{1}', idAirportToCome = '{2}' WHERE idFlightRoutes = '{0}'", dto.IdAirportToGo, dto.IdAirportToCome, dto.IdFlightRoutes);
                int result = ThucThiNon(query);
                return result > 0;
            }
            catch
            {
                return false;
            }
        }        

        public bool DeleteFlightRoute(FlightRouteDTO dto)
        {
            try
            {             
                string query = string.Format("DELETE FROM FlightRoutes WHERE idFlightRoutes = '" + dto.IdFlightRoutes  + "'");
            int result = ThucThiNon(query);
            return result > 0;
        }
        catch
        {
            return false;
        }
    }
    }
}

