using System;
using System.Collections.Generic;

namespace OnlineSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Controller controller = new Controller();
            SaveToFile saveTo = new SaveToFile();
            controller.Save += saveTo.WriteToFile;

            controller.AddTicket(new UsualTicket("Ivanov", "Ivan"));
            controller.AddTicket(new UsualTicket("Petrov", "Petr"));
            controller.AddTicket(new VipTicket("Sidorov", "Sidor"));

            controller.AddTrain(new Train("A-N №1", new DateTime(2020, 6, 10, 9, 30, 0), new DateTime(2020, 6, 11, 9, 30, 0), "Almaty - Nur-Sultan"));
            controller.AddTrain(new Train("N-A №2", new DateTime(2020, 6, 12, 9, 30, 0), new DateTime(2020, 6, 13, 9, 30, 0), "Nur-Sultan - Almaty"));
        }
    }
}