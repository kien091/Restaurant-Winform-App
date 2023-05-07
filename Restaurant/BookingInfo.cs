using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant
{
    internal class BookingInfo
    {
        public string NumPerson { get; set; }
        public string Time { get; set; }
        public string Table { get; set; }
        public BookingInfo(string person, string time, string table)
        {
            NumPerson = person;
            Time = time;
            Table = table;
        }
    }
}
