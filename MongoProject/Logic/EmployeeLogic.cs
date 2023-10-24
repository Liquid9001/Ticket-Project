using DAL;
using MongoProject.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace MongoProject.Logic
{
    public class EmployeeLogic
    {
        DAO dao = new DAO();
        public Employee ValidateUser(Employee employee)
        {
            
            try
            {
                Employee staffvalidate = dao.GetEmployeeUsername(employee.username.ToString());
                if (staffvalidate.password == HashPassword(employee.password))
                {
                    return staffvalidate;
                }
                return null;
            }
            catch
            {
                return null;
            }

        }

        string HashPassword(string passcode)
        {
            SHA256 sha256 = SHA256.Create();
            var passwordInBytes = Encoding.Default.GetBytes(passcode);
<<<<<<< HEAD
            var hashedPassword = sha256.ComputeHash(passwordInBytes);
            return Convert.ToHexString(hashedPassword);
        }

        public void AddEmployee(Employee employee)
        {
            employee.password = HashPassword(employee.password);
            dao.AddEmployee(employee);
=======
            var hassedPassword = sha256.ComputeHash(passwordInBytes);
            return Convert.ToHexString(hassedPassword);
>>>>>>> Louise
        }
    }
}
