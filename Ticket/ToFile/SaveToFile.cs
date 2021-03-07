using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace OnlineSharp
{
    class SaveToFile
    {
        public void WriteToFile(ISaveToFile saveToFile, string fileName)
        {
            using (StreamWriter file = new StreamWriter(fileName, false, Encoding.Unicode))
            {
                file.Write(saveToFile.GetString());
            }
        }
    }
}
