using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C1
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 20;

            // Task 1 start
            while  (num > 0)
            {
                Console.Write($"{num} ");
                num--;
            }
            // Task 1 end

            Console.WriteLine(" ");
            
            // Task 2 start
            int i = 1;

            while (i <= 10)
            {
                if (i % 2 == 0)
                {
                    Console.Write($"{i} ");
                    i++;
                }

                else
                {
                    i++;
                }
            }
            // Task 2 end

            Console.WriteLine("");
            
            // Task 3 start
            int tens = 1;

            while(tens <= 100)
            {
                if (tens % 10 == 0)
                {
                    Console.Write($"{tens} ");
                    tens++;
                }

                else
                {
                    tens++;
                }
            }
            // Task 3 end

            Console.WriteLine(" ");

            // Task 4 start
            int posOdd = 1;

            while (posOdd <= 20)
            {
                if (posOdd % 3 !=  0 && posOdd % 2 != 0)
                {
                    Console.Write($"{posOdd} ");
                    posOdd++;
                }

                else
                {
                    posOdd++;
                }
            }
            // Task 4 end

            Console.WriteLine("");

            // Task 5 start
            int squares = 1;

            while (squares < 10 && squares >= 0)
            {
                int squared = squares * squares;

                if (squared >= 10)
                {
                    Console.Write($"{squared} ");
                    squares++;
                }

                else
                {
                    squares++;
                }
            }
            // Task 5 end

            Console.WriteLine("");

            // Task 6 start
            int integer = 0;

            while (integer >= 0 && integer <= 99)
            {
                if (integer % 3 == 0 || integer % 5 == 0)
                {
                    integer++;
                }

                else
                {
                    Console.Write($"{integer} ");
                    integer++;
                }
            }
            // Task 6 end

            Console.WriteLine(" ");

            // Task 7 start
            char alphabet = 'a';

            while (alphabet >= 'a' && alphabet <= 'z')
            {
                Console.Write($"{alphabet} ");
                alphabet++;
            }
            //Task 7 end

            Console.WriteLine(" ");
        }
    }
}
