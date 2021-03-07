using System;
using System.Collections.Generic;
using System.Text;

namespace OnlineSharp
{
    class Train
    {
        public Train(string number, DateTime departure, DateTime arrival, string info)
        {
            Number = number;
            Departure = departure;
            Arrival = arrival;
            Info = info;
        }
        public string Number { get; set; }
        public DateTime Departure { get; set; }
        public DateTime Arrival { get; set; }
        public string Info { get; set; }
        public string ToFile() => $"{Number}; {Departure}; {Arrival}; {Info};";
    }
}
