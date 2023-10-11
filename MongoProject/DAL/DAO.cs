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
               // {"EmployeeID", ticket.AssignedEmployee.Employee_id },
                {"CreatedAt", ticket.Ticket_created },
                {"Deadline", ticket.Ticket_deadline },
                {"TicketPriority", (int)ticket.TicketPriority }
            };
            collection.InsertOne(document);
        }


    }


}
