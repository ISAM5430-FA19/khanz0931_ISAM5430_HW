using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B3
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal gpaRaw;
            int gpaNew;
            char gradeLetter,  plusMinus;

            do
            {
                Console.WriteLine("Enter a GPA between 0.0 and 4.0:");
                gpaRaw = Convert.ToDecimal(Console.ReadLine());

                if (gpaRaw > 4 || gpaRaw < 0)
                {
                    Console.WriteLine("\nInvalid GPA. Please try again.\n");
                }
            }

            while (gpaRaw > 4 || gpaRaw < 0);

            gpaNew = (int) ((3 * gpaRaw) + 0.5m);
            
            if (gpaNew >= 11 && gpaNew <=12)
            {
                gradeLetter = 'A';
            }

            else if (gpaNew <= 10 && gpaNew >= 8)
            {
                gradeLetter = 'B';
            }

            else if (gpaNew <= 7 && gpaNew >= 5)
            {
                gradeLetter = 'C';
            }

            else if (gpaNew == 4 || gpaNew == 3)
            {
                gradeLetter = 'D';
            }

            else
            {
                gradeLetter = 'F';
            }

            if (gpaNew == 10 || gpaNew == 7 || gpaNew == 4)
            {
                plusMinus = '+';
            }

            else if (gpaNew == 11 || gpaNew == 8 || gpaNew == 5)
            {
                plusMinus = '-';
            }

            else
            {
                plusMinus = ' ';
            }

            Console.WriteLine($"Your letter grade is: {gradeLetter}{plusMinus}");
            
        }
    }
}
