using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C2
{
    class Program
    {
        static void Main(string[] args)
        {
            string nameToll, nameLanes;
            Motorway motorway = new Motorway();

            nameToll = motorway.NameAndToll();
            Console.WriteLine(nameToll);

            Console.WriteLine();

            nameLanes = motorway.NameAndLane();
            Console.WriteLine(nameLanes);
        }
    }
}
