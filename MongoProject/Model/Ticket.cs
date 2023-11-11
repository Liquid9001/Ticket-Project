using MongoDB.Bson;
using System;
using System.Collections.Generic;
using MongoDB.Bson.Serialization.Attributes;

namespace MongoProject.Model
{
    public class Ticket
    {
        public ObjectId Id { get; set; }
        public string Title { get; set; }
        public TicketType TypeOfIncident { get; set; }
        public string Description { get; set; }
        public TicketStatus Status { get; set; }
        public ObjectId EmployeeID { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime Deadline { get; set; }
        public TicketPriority Priority { get; set; }

        public Ticket(string title, TicketType typeOfIncident, string description, TicketStatus status, ObjectId employeeID, DateTime createdAt, DateTime deadline, TicketPriority priority)
        {
            Title = title;
            TypeOfIncident = typeOfIncident;
            Description = description;
            Status = status;
            EmployeeID = employeeID;
            CreatedAt = createdAt;
            Deadline = deadline;
            Priority = priority;
        }
    }
}
