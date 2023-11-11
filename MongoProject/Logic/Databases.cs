using DAL;
using MongoProject.Model;
using System.Collections.Generic;

namespace Logic
{
    public class Databases
    {
        private DAO dao;
        public Databases()
        {
            dao = new DAO();
        }

        public void AddTicket(Ticket ticket)
        {
            dao.AddTicket(ticket);
        }

        public List<Employee> GetEmployees()
        {
            return dao.GetAllEmployees();
        }

        public List<Ticket> GetTickets()
        {
            return dao.GetAllTickets();
        }
    }
}
