using System;
using System.Collections.Generic;
using System.Text;

namespace OnlineSharp
{
    abstract class Ticket
    {
        private static int curentNumber;
        public Ticket()
        {
            this.Number = ++curentNumber;
        }
        public double Price { get; set; }
        public int Number { get; private set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public abstract string ToFile();
    }
}
