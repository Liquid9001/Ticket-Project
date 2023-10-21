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
      /*  public Employee ValidateUser(Employee employee)
        {
            
            try
            {
                Employee staffvalidate = _staffDAO.GetStaffByUsername(em.username);
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

        }*/

        string HashPassword(string passcode)
        {
            SHA256 sha256 = SHA256.Create();
            var passwordInBytes = Encoding.Default.GetBytes(passcode);
            var hassedPassword = sha256.ComputeHash(passwordInBytes);
            return Convert.ToHexString(hassedPassword);
        }
    }
}
