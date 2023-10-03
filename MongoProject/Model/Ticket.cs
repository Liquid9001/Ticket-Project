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
        Employee ticket_assigned;
        List<string> comments;
    }
}
