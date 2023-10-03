using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MongoProject.Model
{
    enum TicketStatus
    {
        Open,
        Closed,
        InProgress,
        Resolved
    }
    enum TicketPriority
    {
        Low,
        Medium,
        High
    }
    enum TicketType
    {
        Software,
        Hardware,
        Service
    }
}
