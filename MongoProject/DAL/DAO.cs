using MongoDB.Bson;
using MongoDB.Driver;
using System.Collections.Generic;
using Model;
using MongoDB.Bson.Serialization;
using MongoProject.Model;
using Logic;

namespace DAL
{
    public class DAO
    {
        private MongoClient client;
        private IMongoDatabase db;

        public DAO()
        {
            client = new MongoClient("mongodb+srv://projecttickets:wFK6NeiHfAKvHAiB@cluster0.tpy88by.mongodb.net/");
            db = client.GetDatabase("TicketProject");

        }

        public List<Employee> GetAllEmployees()
        {
            IMongoCollection<Employee> collection = db.GetCollection<Employee>("Employees");
            FilterDefinition<Employee> filter = Builders<Employee>.Filter.Empty;
            List<Employee> employees = collection.Find(filter).ToList();
            return employees;
        }

        public List<Ticket> GetAllTickets()
        {
            IMongoCollection<Ticket> collection = db.GetCollection<Ticket>("Tickets");
            FilterDefinition<Ticket> filter = Builders<Ticket>.Filter.Empty;
            List<Ticket> tickets = collection.Find(filter).ToList();
            return tickets;
        }

        public void AddEmployee(Employee employee)
        {
            IMongoCollection<Employee> collection = db.GetCollection<Employee>("Employees");

            collection.InsertOne(employee);
        }

        public void AddTicket(Ticket ticket)
        {
            IMongoCollection<Ticket> collection = db.GetCollection<Ticket>("Tickets");

            collection.InsertOne(ticket);
        }

<<<<<<< HEAD
=======
        /*public void AddEmployee(Employee employee)
        {
            IMongoCollection<Employee> collection = db.GetCollection<Employee>("Employees");
            
            collection.InsertOne(employee);
        }

        public void AddTicket(Ticket ticket)
        {
            IMongoCollection<Ticket> collection = db.GetCollection<Ticket>("Tickets");

            collection.InsertOne(ticket);
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
        }*/
>>>>>>> 12ae9c38d5a101dbb2496bef38310199414d9aff
        public Employee GetEmployeeUsername(string username) 
        {
            IMongoCollection<Employee> collection = db.GetCollection<Employee>("Employees");
            FilterDefinition<Employee> filter = Builders<Employee>.Filter.Eq("username", username);
            Employee employee = collection.Find(filter).First();
            return employee;
        }
    }


}
