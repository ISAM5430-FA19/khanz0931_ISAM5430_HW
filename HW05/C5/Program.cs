using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C5
{
    class Program
    {
        static void Main(string[] args)
        {
            string date1;
            Date date = new Date();

            date1 = date.DisplayDate();

            Console.WriteLine($"Date: {date1}");
        }
    }
}
