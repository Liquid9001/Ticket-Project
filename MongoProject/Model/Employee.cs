using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;

namespace MongoProject.Model
{
    public class Employee
    {
        public ObjectId Id { get; set; }
        public string username { get; set; }
        public string password { get; set; }
        public bool isServiceDesk { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailAddress { get; set; }
        public string PhoneNumber { get; set; }
        public string Location { get; set; }
        public string Salt { get; set; }

        public Employee()
        {
         
        }
        public Employee(string username, string password, bool isServiceDesk, string FirstName, string LastName, string EmailAddress, string PhoneNumber, string Location, string Salt)
        {
            this.username = username;
            this.password = password;
            this.isServiceDesk = isServiceDesk;
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.EmailAddress = EmailAddress;
            this.PhoneNumber = PhoneNumber;
            this.Location = Location;
            this.Salt = Salt;
        }
    }
}
