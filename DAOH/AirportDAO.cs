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
    public class AirportDAO : Method
    {      
        public DataTable GetDataAirport()
        {
            string query = " SELECT * FROM Airports";
            DataTable dtData = ThucThi(query);
            return dtData;
        }

        public bool InsertAirport(AirportDTO dto)
        {           
            try
            {
                string query = String.Format("INSERT INTO Airports (idAirport, nameAirport, cityAirport) VALUES ('{0}', N'{1}', N'{2}')", dto.IdAirport, dto.NameAirport, dto.CityAirport);
                int result = ThucThiNon(query);
                return result > 0;
            }
            catch
            {
                return false;
            }
        }

        public bool UpdateAirport(AirportDTO dto)
        {
            try
            {              
                string query = String.Format("UPDATE Airports set nameAirport = N'{1}', cityAirport = N'{2}' where idAirport = '{0}'", dto.IdAirport, dto.NameAirport, dto.CityAirport);
                int result = ThucThiNon(query);
                return result > 0;
            }
            catch
            {
                return false;
            }
        }

        public bool DeleteAirport(AirportDTO dto)
        {
            try
            {
                string query = String.Format("DELETE FROM Airports WHERE idAirport = '" + dto.IdAirport + "'");
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

