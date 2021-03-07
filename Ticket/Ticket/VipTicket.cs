using System;
using System.Collections.Generic;
using System.Text;

namespace OnlineSharp
{
    class VipTicket : Ticket
    {
        public double Markup { get; set; }
        public VipTicket(string last, string name)
        {
            LastName = last;
            Name = name;
            Price = 30000.0;
            Markup = 0;
        }
        public override string ToFile() => $"{Number};{LastName};{Name};{Price};{Markup};";
    }
}
