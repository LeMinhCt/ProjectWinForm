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
    public class AirportBUS : Method
    {
        AirportDAO airportDAO = new AirportDAO();
        public DataTable GetDataAirport()
        {
            return airportDAO.GetDataAirport();
        }

        public bool InsertAirport(AirportDTO dto)
        {
            return airportDAO.InsertAirport(dto);
        }

        public bool UpdateAirport(AirportDTO dto)
        {
            return airportDAO.UpdateAirport(dto);
        }
        public bool DeleteAirport(AirportDTO dto)
        {
            return airportDAO.DeleteAirport(dto);
        }
    }
}
