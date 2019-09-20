using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B4
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] side = new int[3];
            
            for (int i = 0; i <= 2; i++)
            {
                Console.WriteLine("Enter a side of the triangle:");
                side[i] = int.Parse(Console.ReadLine());

                if (side[i] <= 0)
                {
                    Console.WriteLine("You have entered an invalid number. App terminating.");
                    break;
                }
            }

            if (side[0] + side[1] > side[2])
            {
                if (side[1] + side[2] > side[0])
                {
                    if (side[0] + side[2] > side[1])
                    {
                        Console.WriteLine("The triangle is valid.");
                    }

                    else
                    {
                        Console.WriteLine("The triangle is not valid.");
                    }
                }

                else
                {
                    Console.WriteLine("The triangle is not valid.");
                }
            }

            else
            {
                Console.WriteLine("The triangle is not valid.");
            }
        }
    }
}
