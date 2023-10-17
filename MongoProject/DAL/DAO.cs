using MongoDB.Bson;
using MongoDB.Driver;
using System.Collections.Generic;
using Model;
using MongoDB.Bson.Serialization;
using MongoProject.Model;

namespace DAL
{
    public class DAO
    {
        private MongoClient client;
        private IMongoDatabase db;
        private IMongoCollection<BsonDocument> collection;

        public DAO()
        {
            client = new MongoClient("mongodb+srv://projecttickets:wFK6NeiHfAKvHAiB@cluster0.tpy88by.mongodb.net/");
            db = client.GetDatabase("TicketProject");

        }

        public List<Employee> GetEmployees()
        {
            List<Employee> employees = new List<Employee>();
            collection = db.GetCollection<BsonDocument>("Employees");
            var documents = collection.Find(new BsonDocument()).ToList();
            foreach (var document in documents)
            {
                Employee employee = new Employee(document["FirstName"].ToString(), document["LastName"].ToString(), document["username"].ToString(), document["password"].ToString(), document["EmailAddress"].ToString(), document["PhoneNumber"].ToString(), document["Location"].ToString(), document["isServiceDesk"].ToBoolean());
                employees.Add(employee);
            }
            return employees;
        }

        public List<Ticket> GetTickets()
        {
            List<Ticket> tickets = new List<Ticket>();
            collection = db.GetCollection<BsonDocument>("Tickets");
            var documents = collection.Find(new BsonDocument()).ToList();
            foreach (var document in documents)
            {
                Ticket ticket = new Ticket(document["Title"].ToString(), document["Description"].ToString(), document["CreatedAt"].ToUniversalTime(), document["Deadline"].ToUniversalTime(), document["EmployeeID"].ToString(), new List<string>(), (TicketType)document["TypeOfIncident"].ToInt32(), (TicketStatus)document["Status"].ToInt32(), (TicketPriority)document["TicketPriority"].ToInt32());
                tickets.Add(ticket);
            }
            return tickets;
        }

        public void AddEmployee(Employee employee)
        {
            collection = db.GetCollection<BsonDocument>("Employees");
            BsonDocument document = new BsonDocument
            {
                {"FirstName", employee.FirstName },
                {"LastName", employee.LastName },
                {"username", employee.Username },
                {"password", employee.Password },
                {"EmailAddress", employee.Email },
                {"PhoneNumber", employee.PhoneNumber },
                {"Location", employee.Location },
                {"isServiceDesk", employee.IsServiceDesk }
            };
            collection.InsertOne(document);
        }



        public void AddTicket(Ticket ticket)
        {
            collection = db.GetCollection<BsonDocument>("Tickets");
            BsonDocument document = new BsonDocument
            {
                {"Title", ticket.Ticket_name },
                {"TypeOfIncident", (int)ticket.TicketType },
                {"Description", ticket.Ticket_description },
                {"Status", (int)ticket.TicketStatus },
                {"EmployeeID", ticket.EmployeeID },
                {"CreatedAt", ticket.Ticket_created },
                {"Deadline", ticket.Ticket_deadline },
                {"TicketPriority", (int)ticket.TicketPriority }
            };
            collection.InsertOne(document);
        }
    }


}
