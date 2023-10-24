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

        public void AddEmployee(Employee employee)
        {
            dao.AddEmployee(employee);
        }

        public List<Employee> GetEmployees()
        {
            return dao.GetAllEmployees();
        }

        public List<Ticket> GetTickets()
        {
            return dao.GetTickets();
        }
    }
}
