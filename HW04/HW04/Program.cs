using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW04
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0, product = 0;
            
            Console.WriteLine("Two-number permutations:");

            for (int i = 1; i <= 5; i++)
            {
                for (int j = 1; j <= 5; j++)
                {
                    if (i != j)
                    {
                        Console.WriteLine(i + ", " + j);
                    }
                }
            }

            Console.WriteLine();
            Console.WriteLine("One-number permutations:");

            for (int i = 1; i <= 5; i++)
            {
                Console.Write(i + ", ");
            }

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Three-number permutations:");

            for (int i = 1; i <= 5; i++)
            {
                for (int j = 1; j <= 5; j++)
                {
                    if (i != j)
                    {
                        for (int k = 1; k <= 5; k++)
                        {
                            Console.WriteLine(i + ", " + j + ", " + k);
                        }
                    }
                }
            }

            Console.WriteLine();
            Console.WriteLine("Sum of products of permutations:");

            for (int i = 1; i <= 5; i++)
            {
                for (int j = 1; j <= 5; j++)
                {
                    if (i != j)
                    {
                        product = i * j;
                        sum = sum + product;
                    }
                }
            }

            Console.WriteLine($"Sum of product of two-number permutations: {sum}");
            product = 0;
            sum = 0;

            for (int i = 1; i <= 5; i++)
            {
                for (int j = 1; j <= 5; j++)
                {
                    if (i != j)
                    {
                        for (int k = 1; k <= 5; k++)
                        {
                            if (j != k && i != k)
                            {
                                product = i * j * k;
                                sum = sum + product;
                            }
                        }
                    }
                }
            }

            Console.WriteLine($"Sum of product of three-number permutations: {sum}");
            Console.WriteLine();
            Console.WriteLine("Two-number combinations:");

            for (int i = 1; i <= 5; i++)
            {
                for (int j = 1 + i; j <= 5; j++)
                {
                    Console.WriteLine(i + ", " + j);
                }
            }

            Console.WriteLine();
            Console.WriteLine("Three-number combinations:");

            for (int i = 1; i <= 5; i++)
            {
                for (int j = 1 + i; j <= 5; j++)
                {
                    for (int k = 1 + j; k <= 5; k++)
                    {
                        Console.WriteLine(i + ", " + j + ", " + k);
                    }
                }
            }

            Console.WriteLine();
            Console.WriteLine("Four-number combinations:");

            
            for (int i = 1; i <= 5; i++)
            {
                for (int j = 1 + i; j <= 5; j++)
                {
                    for (int k = 1 + j; k <= 5; k++)
                    {
                        for (int l = 1 + k; l <= 5; l++)
                        {
                            Console.WriteLine(i + ", " + j + ", " + k + ", " + l);
                        }
                    }
                }
            }
            
            Console.WriteLine();
            Console.WriteLine("Five-number combinations:");

            
            for (int i = 1; i <= 5; i++)
            {
                for (int j = 1 + i; j <= 5; j++)
                {
                    for (int k = 1 + j; k <= 5; k++)
                    {
                        for (int l = 1 + k; l <= 5; l++)
                        {
                            for (int m = 1 + l; m <= 5; m++)
                            {
                                Console.WriteLine(i + ", " + j + ", " + k + ", " + l + ", " + m);
                            }
                        }
                    }
                }
            }
            
            Console.WriteLine();
            Console.WriteLine("Sum of products of combinations:");
            product = 0;
            sum = 0;

            for (int i = 1; i <= 5; i++)
            {
                for (int j = 1 + i; j <= 5; j++)
                {
                    product = i * j;
                    sum = sum + product;
                }
            }

            Console.WriteLine($"Sum of product of two-number combination: {sum}");
            product = 0;
            sum = 0;

            for (int i = 1; i <= 5; i++)
            {
                for (int j = 1 + i; j <= 5; j++)
                {
                    for (int k = 1 + j; k <= 5; k++)
                    {
                        product = i * j * k;
                        sum = sum + product;
                    }
                }
            }

            Console.WriteLine($"Sum of product of three-number combination: {sum}");
            product = 0;
            sum = 0;

            for (int i = 1; i <= 5; i++)
            {
                for (int j = 1 + i; j <= 5; j++)
                {
                    for (int k = 1 + j; k <= 5; k++)
                    {
                        for (int l = 1 + k; l <= 5; l++)
                        {
                            product = i * j * k * l;
                            sum = sum + product;
                        }
                    }
                }
            }
            
            Console.WriteLine($"Sum of product of four-number combination: {sum}");
            product = 0;
            sum = 0;
            
            for (int i = 1; i <= 5; i++)
            {
                for (int j = 1 + i; j <= 5; j++)
                {
                    for (int k = 1 + j; k <= 5; k++)
                    {
                        for (int l = 1 + k; l <= 5; l++)
                        {
                            for (int m = 1 + l; m <= 5; m++)
                            {
                                product = i * j * k * l * m;
                                sum = sum + product;
                            }
                        }
                    }
                }
            }

            Console.WriteLine($"Sum of product of five-number combination: {sum}");
        }
    }
}
