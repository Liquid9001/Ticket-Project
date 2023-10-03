using DAL;
using Model;
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
            Employee employee = new Employee("Jantje", "Klaassen", "jklaassen", "password22123", "jantjeK@email.com", "0644447799", "HQ", false);
            dao.AddEmployee(employee);
        }
    }
}
