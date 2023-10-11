using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MongoProject.Model
{
    public class Ticket
    {
        int ticket_id;
        string ticket_name;
        TicketType ticketType;
        string ticket_description;
        TicketStatus ticketStatus;
        TicketPriority ticketPriority;
        DateTime ticket_created;
        DateTime ticket_deadline;
        DateTime ticket_resolved;
        DateTime ticket_closed;
        Employee assignedEmployee;
        List<string> comments;

        public Ticket(string ticket_name, string ticket_description, DateTime ticket_created, DateTime ticket_deadline, DateTime ticket_resolved, DateTime ticket_closed, Employee employee, List<string> comments, TicketType ticketType, TicketStatus ticketStatus, TicketPriority ticketPriority)
        {
            Ticket_name = ticket_name;
            Ticket_description = ticket_description;
            Ticket_created = ticket_created;
            Ticket_deadline = ticket_deadline;
            Ticket_resolved = ticket_resolved;
            Ticket_closed = ticket_closed;
            AssignedEmployee = employee;
            Comments = comments;
            TicketType = ticketType;
            TicketStatus = ticketStatus;
            TicketPriority = ticketPriority;
        }

        public int Ticket_id { get => ticket_id; }
        public string Ticket_name { get => ticket_name; set => ticket_name = value; }
        public string Ticket_description { get => ticket_description; set => ticket_description = value; }
        public DateTime Ticket_created { get => ticket_created; set => ticket_created = value; }
        public DateTime Ticket_deadline { get => ticket_deadline; set => ticket_deadline = value; }
        public DateTime Ticket_resolved { get => ticket_resolved; set => ticket_resolved = value; }
        public DateTime Ticket_closed { get => ticket_closed; set => ticket_closed = value; }
        public Employee AssignedEmployee { get => assignedEmployee; set => assignedEmployee = value; }
        public List<string> Comments { get => comments; set => comments = value; }
        public TicketType TicketType { get => ticketType; set => ticketType = value; }
        public TicketStatus TicketStatus { get => ticketStatus; set => ticketStatus = value; }
        public TicketPriority TicketPriority { get => ticketPriority; set => ticketPriority = value; }
    }
}
