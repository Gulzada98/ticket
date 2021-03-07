using System;
using System.Collections.Generic;
using System.Text;

namespace OnlineSharp
{
    class Controller
    {
        // Описание делегата для отправки сообщений.
        public delegate void SaveStateHandler(ISaveToFile list, string filename);
        // Описание события использующее делегат.
        public event SaveStateHandler Save;

        private TicketList tickets;
        private TrainList trains;
        public Controller()
        {
            tickets = new TicketList();
            trains = new TrainList();
        }
        public void AddTicket(Ticket ticket)
        {
            tickets.Add(ticket);
            Save?.Invoke(tickets, "ticket.txt");
        }
        public void AddTrain(Train train)
        {
            trains.Add(train);
            Save?.Invoke(trains, "trains.txt");
        }
    }
}
