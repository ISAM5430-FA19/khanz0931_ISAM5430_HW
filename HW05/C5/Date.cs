using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C5
{
    class Date
    {
        public int Month { get; set; }
        public int Day { get; set; }
        public int Year { get; set; }

        public Date()
        {
            Month = 10;
            Day = 10;
            Year = 2019;
        }

        public string DisplayDate()
        {
            return Month + "/" + Day + "/" + Year;
        }

    }
}
