using MongoDB.Bson;
using System;
using System.Collections.Generic;

namespace MongoProject.Model
{
    public class Ticket
    {
        public ObjectId Ticket_id { get; set; }
        public string Title { get; set; }
        public TicketType TypeOfIncident { get; set; }
        public string Description { get; set; }
        public TicketStatus Status { get; set; }
        public ObjectId EmployeeID { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime Deadline { get; set; }
        public List<Comment> Comments { get; set; }
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



    public class Comment
    {
        public string CommentText { get; set; }
        public CommentedBy CommentedBy { get; set; }
        public DateTime CommentDate { get; set; }
    }

    public class CommentedBy
    {
        public UserId UserID { get; set; }
    }

    public class UserId
    {
        public ObjectId Ref { get; set; }
        public ObjectId ID { get; set; }
    }
}
