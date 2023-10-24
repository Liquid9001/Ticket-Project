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
        public Employee ValidateUser(Employee employeeInput)
        {
            
            try
            {
                Employee staffValidate = dao.GetEmployeeUsername(employeeInput.username.ToString());
                if (staffValidate.password.ToUpper() == HashPassword(employeeInput, staffValidate))
                {
                    return staffValidate;
                }
                return null;
            }
            catch
            {
                return null;
            }

        }

        string HashPassword(Employee employee)
        {
            SHA256 sha256 = SHA256.Create();
            var passwordInBytes = Encoding.Default.GetBytes((employee.password + employee.Salt));
            var hashedPassword = sha256.ComputeHash(passwordInBytes);
            return Convert.ToHexString(hashedPassword);
        }

        string HashPassword(Employee employeeInput, Employee staffValidate)
        {
            SHA256 sha256 = SHA256.Create();
            var passwordInBytes = Encoding.Default.GetBytes((employeeInput.password + staffValidate.Salt));
            var hashedPassword = sha256.ComputeHash(passwordInBytes);
            return Convert.ToHexString(hashedPassword);
        }

        public void AddEmployee(string username, string password, bool isServiceDesk, string firstName, string lastName, string emailAddress, string phoneNumber, string location)
        {
            Employee employee = new Employee(username, password, isServiceDesk, firstName, lastName, emailAddress, phoneNumber, location, CreateSalt());
            employee.password = HashPassword(employee);
            dao.AddEmployee(employee);
        }

        public string CreateSalt()
        {
            const int length = 10;
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            Random rnd = new Random();
            return new string(Enumerable.Repeat(chars, length)
            .Select(s => s[rnd.Next(s.Length)]).ToArray());
        }
    }
}
