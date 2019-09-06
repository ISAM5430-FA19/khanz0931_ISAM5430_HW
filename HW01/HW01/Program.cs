using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW01
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, sum, difference, product, quotient;
            char operation;

            Console.WriteLine("Enter the first number:");
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the second number");
            num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the operator (+, -, *, /):");
            operation = Convert.ToChar(Console.ReadLine());

            if (operation == '+')
            {
                sum = num1 + num2;
                Console.WriteLine($"{num1} + {num2} = {sum}\nThe sum of {num1} and {num2} is {sum}");
            }

            if (operation == '-')
            {
                difference = num1 - num2;
                Console.WriteLine($"{num1} - {num2} = {difference}\nThe difference of {num1} and {num2} is {difference}");
            }

            if (operation == '*')
            {
                product = num1 * num2;
                Console.WriteLine($"{num1} * {num2} = {product}\nThe product of {num1} and {num2} is {product}\n");
            }

            if (operation == '/')
            {
                quotient = num1 + num2;
                Console.WriteLine($"{num1} / {num2} = {quotient}\nThe quotient of {num1} and {num2} is {quotient}");
            }
        }
    }
}
