using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant
{
    internal class findInfoTableWithList
    {
        public string note { get; set; }
        public int numInList { get; set; }
        public int numInOrd { get; set; }
        public findInfoTableWithList(string note, int numInList, int numInOrd) 
        {
            this.note = note;
            this.numInList = numInList;
            this.numInOrd = numInOrd;
        }
    }
}
