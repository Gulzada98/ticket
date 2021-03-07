using System.Text;
using System.Collections.Generic;

namespace OnlineSharp
{
    class TicketList : ISaveToFile
    {
        private List<Ticket> tickets = new List<Ticket>();
        public void Add(Ticket ticket) => tickets.Add(ticket);
        public StringBuilder GetString()
        {
            StringBuilder builder = new StringBuilder();
            foreach (Ticket elem in tickets)
            {
                builder.Append(elem.ToFile());
                builder.Append("\r\n");
            }
            return builder;
        }
    }
}
