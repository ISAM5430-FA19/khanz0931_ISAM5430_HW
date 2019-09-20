using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B1
{
    class Program
    {
        static void Main(string[] args)
        {
            int score, average, bestScore = 0, i = 0, sum = 0, count = 1;

            while (i >= 0)
            {
                Console.WriteLine("Enter a valid score:");
                score = int.Parse(Console.ReadLine());

                if (score > 100 || score < 0)
                {
                    Console.WriteLine("You have entered an invalid score. Displaying best score and average.");
                    break;
                }

                else if (score > bestScore)
                {
                    bestScore = score;
                }

                sum = sum + score;
                count++;
                i++;
  
            }

            average = sum / count;

            Console.WriteLine($"Best score: {bestScore}");
            Console.WriteLine($"The average score is: {average}");
        }
    }
}
