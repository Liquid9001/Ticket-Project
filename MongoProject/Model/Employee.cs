using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MongoProject.Model
{
    public class Employee
    {
        int employee_id;
        string firstName;
        string lastName;
        string username;
        string password;
        string email;
        string phoneNumber;
        string location;
        bool isServiceDesk;

        public int Employee_id { get => employee_id; set => employee_id = value; }
        public string FirstName { get => firstName; set => firstName = value; }
        public string LastName { get => lastName; set => lastName = value; }
        public string Username { get => username; set => username = value; }
        public string Password { get => password; set => password = value; }
        public string Email { get => email; set => email = value; }
        public string PhoneNumber { get => phoneNumber; set => phoneNumber = value; }
        public string Location { get => location; set => location = value; }
        public bool IsServiceDesk { get => isServiceDesk; set => isServiceDesk = value; }
    }
}
