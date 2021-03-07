using System;
using System.Collections.Generic;
using System.Text;

namespace OnlineSharp
{
    class TrainList : ISaveToFile
    {
        private List<Train> trains = new List<Train>();
        public void Add(Train train) => trains.Add(train);

        public StringBuilder GetString()
        {
            StringBuilder builder = new StringBuilder();
            foreach (Train elem in trains)
            {
                builder.Append(elem.ToFile());
                builder.Append("\r\n");
            }
            return builder;
        }
    }
}
