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
    public class PlaneDAO : Method
    {
        public DataTable GetDataPlane()
        {
            string query = " SELECT * FROM Planes";
            DataTable dtData = ThucThi(query);
            return dtData;
        }

        public bool InsertPlane(PlaneDTO dto)
        {
            try
            {
                string query = String.Format("INSERT INTO Planes(idPlane, namePlane, seatsPlane) VALUES('{0}', '{1}', '{2}')", dto.IdPlane , dto.NamePlane, dto.SeatsPlane);
                int result = ThucThiNon(query);
                return result > 0;
            }
            catch
            {
                return false;
            }
        }

        public bool UpdatePlane(PlaneDTO dto)
        {
            try
            {
                string query = string.Format("UPDATE Planes set namePlane = '{1}', seatsPlane = '{2}' where idPlane = '{0}'", dto.IdPlane, dto.NamePlane, dto.SeatsPlane);
                int result = ThucThiNon(query);
                return result > 0;
            }
            catch
            {
                return false;
            }            
        }

        public bool DeletePlane(PlaneDTO dto)
        {
            try
            {              
                string query = string.Format("DELETE FROM Planes WHERE idPlane = '" + dto.IdPlane + "'");
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
