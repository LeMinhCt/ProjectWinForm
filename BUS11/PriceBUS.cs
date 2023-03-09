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
    public class PriceBUS : Method
    {
        PriceDAO priceDAO = new PriceDAO();
        public DataTable GetDataPrice()
        {
            return priceDAO.GetDataPrice();
        }

        //public object GetPriceByIdFlightAndIdTicketClass(int price)
        //{
        //    return priceDAO.GetPriceByIdFlightAndIdTicketClass(price);
        //}
    }
}
