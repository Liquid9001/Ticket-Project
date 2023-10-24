using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MongoProject.Model
{
    public enum TicketStatus
    {
        Open,
        Closed,
        InProgress,
        Resolved
    }
    public enum TicketPriority
    {
        Low,
        Normal,
        High
    }
    public enum TicketType
    {
        Software,
        Hardware,
        Service
    }

   
}
