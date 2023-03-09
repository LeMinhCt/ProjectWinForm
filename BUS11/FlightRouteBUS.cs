using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class FlightRouteBUS : Method
    {
        FlightRouteDAO flightRouteDAO = new FlightRouteDAO();
        public DataTable GetDataFlightRoute()
        {
            return flightRouteDAO.GetDataFlightRoute();
        }

        public DataTable GetOfIdFlightRoute(string str)
        {
            return flightRouteDAO.GetOfIdFlightRoute(str);
        }

        public DataTable GetOfIdAirport(string idToGo, string idToCome)
        {
            return flightRouteDAO.GetOfIdAirport(idToGo, idToCome);
        }
        public bool InsertFlightRoute(FlightRouteDTO dto)
        {
            return flightRouteDAO.InsertFlightRoute(dto);
        }

        public bool UpdateFlightRoute(FlightRouteDTO dto)
        {
            return flightRouteDAO.UpdateFlightRoute(dto);
        }
        public bool DeleteFlightRoute(FlightRouteDTO dto)
        {
            return flightRouteDAO.DeleteFlightRoute(dto);
        }
    }
}
