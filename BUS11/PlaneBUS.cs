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
    public class PlaneBUS : Method
    {
        PlaneDAO planeDAO = new PlaneDAO();
        public DataTable GetDataPlane()
        {
            return planeDAO.GetDataPlane();
        }
        public bool InsertPlane(PlaneDTO dto)
        {
            return planeDAO.InsertPlane(dto);
        }
        public bool UpdatePlane(PlaneDTO dto)
        {
            return planeDAO.UpdatePlane(dto);
        }
        public bool DeletePlane(PlaneDTO dto)
        {
            return planeDAO.DeletePlane(dto);
        }
    }
}
