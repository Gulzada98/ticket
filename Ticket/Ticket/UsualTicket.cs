using System.Text;

namespace OnlineSharp
{
    class UsualTicket : Ticket
    {
        public UsualTicket(string last, string name)
        {
            LastName = last;
            Name = name;
            Price = 30000.0;
        }
        public override string ToFile() => $"{Number}; {LastName}; {Name}; {Price};";
    }
}
