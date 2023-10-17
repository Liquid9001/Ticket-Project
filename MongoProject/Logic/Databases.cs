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

        public void AddEmployee()
        {
            
        }

        public List<Employee> GetEmployees()
        {
            return dao.GetEmployees();
        }

        public List<Ticket> GetTickets()
        {
            return dao.GetTickets();
        }
    }
}
