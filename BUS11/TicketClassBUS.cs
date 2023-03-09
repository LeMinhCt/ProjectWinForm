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
    public class TicketClassBUS : Method
    {
        TicketClassDAO ticketclassDAO = new TicketClassDAO();
        public void GetDataTicketClass(string temp)
        {
            ticketclassDAO.GetDataTicketClass(temp);
        }

        public void InsertTicketClass(TicketClassDTO dto)
        {
            ticketclassDAO.InsertTicketClass(dto);
        }

        public void UpdateTicketClass(TicketClassDTO dto)
        {
            ticketclassDAO.UpdateTicketClass(dto);
        }
        public void DeleteTicketClass(TicketClassDTO dto)
        {
            ticketclassDAO.DeleteTicketClass(dto);
        }
    }
}
