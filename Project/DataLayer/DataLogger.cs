using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public static class DataLogger
    {
        public static void LogData(string data)
        {
            StreamWriter File = new StreamWriter("log.txt", true);

            File.WriteLine($"[{DateTime.Now}] {data}");
            File.Close();
        }
    }
}
