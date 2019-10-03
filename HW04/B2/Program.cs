using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Two-letter words:");
            Console.WriteLine("At least one vowel:");

            for (char a = 'A'; a <= 'H'; a++)
            {
                for (char b = 'A'; b <= 'H'; b++)
                {
                    if (a == 'A' || a == 'E' || b == 'A' || b == 'E')
                    {
                        Console.Write(a + "" + b + ", ");
                    }
                }
            }

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("At least one vowel and one consonant:");

            for (char a = 'A'; a <= 'H'; a++)
            {
                for (char b = 'A'; b <= 'H'; b++)
                {
                    if (a == 'A' || a == 'E' || b == 'A' || b == 'E')
                    {
                        if (a == 'B' || a == 'C' || a == 'D' || a == 'F' || a == 'G' || a == 'H' || b == 'B' || b == 'C' || b == 'D' || b == 'F' || b == 'G' || b == 'H')
                        {
                            Console.Write(a + "" + b + ", ");
                        }
                    }
                }
            }

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Begin with consonant and end with vowel:");

            for (char a = 'A'; a <= 'H'; a++)
            {
                for (char b = 'A'; b <= 'H'; b++)
                {
                    if (a == 'B' || a == 'C' || a == 'D' || a == 'F' || a == 'G' || a == 'H')
                    {
                        if (b == 'A' || b == 'E')
                        {
                            Console.Write(a + "" + b + ", ");
                        }
                    }
                }
            }


            // use bool for three-letter words: bool vowelA = a == 'A' || a == 'E'; (within for loops)
            // int vowels = (vowelA ? 1 : 0) + (vowelB ? 1 : 0) + (vowelC ? 1 : 0);
            // int consonants (!vowelA ? 1 : 0) + (!vowelB ? 1 : 0) + (!vowelC ? 1 : 0);
            // int vowels 2 == (vowelA ? 1 : 0) + (vowelB ? 1 : 0);
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Three-letter words:");
            Console.WriteLine("At least one vowel:");

            for (char a = 'A'; a <= 'H'; a++)
            {
                for (char b = 'A'; b <= 'H'; b++)
                {
                    for (char c = 'A'; c <= 'H'; c++)
                    {
                        if (a == 'A' || a == 'E' || b == 'A' || b == 'E' || c == 'A' || c == 'E')
                        {
                            Console.Write(a + "" + b + "" + c + ", ");
                        }
                    }
                }
            }

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Middle letter is vowel");

            for (char a = 'A'; a <= 'H'; a++)
            {
                for (char b = 'A'; b <= 'H'; b++)
                {
                    for (char c = 'A'; c <= 'H'; c++)
                    {
                        if (b == 'A' || b == 'E')
                        {
                            Console.Write(a + "" + b + "" + c + ", ");
                        }
                    }
                }
            }

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("At least one consonant and one vowel:");

            for (char a = 'A'; a <= 'H'; a++)
            {
                for (char b = 'A'; b <= 'H'; b++)
                {
                    for (char c = 'A'; c <= 'H'; c++)
                    {
                        if (a == 'A' || a == 'E' || b == 'A' || b == 'E' || c == 'A' || c == 'E')
                        {
                            if (a == 'B' || a == 'C' || a == 'D' || a == 'F' || a == 'G' || a == 'H' || b == 'B' || b == 'C' || b == 'D' || b == 'F' || b == 'G' || b == 'H'
                                || c == 'B' || c == 'C' || c == 'D' || c == 'F' || c == 'G' || c == 'H')
                            {
                                Console.Write(a + "" + b + "" + c + ", ");
                            }
                        }
                    }
                }
            }

            Console.WriteLine();
            Console.WriteLine("Middle letter is vowel, unique characters:");

            for (char a = 'A'; a <= 'H'; a++)
            {
                for (char b = 'A'; b <= 'H'; b++)
                {
                    for (char c = 'A'; c <= 'H'; c++)
                    {
                        if (b == 'A' || b == 'E')
                        {
                            if (a == b || b == c || a == c)
                            {
                                break;
                            }

                            else
                            {
                                Console.Write(a + "" + b + "" + c + ", ");
                            }
                        }
                    }
                }
            }

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Two-letter and three-letter words:");
            Console.WriteLine("At least one vowel:");

            for (char a = 'A'; a <= 'H'; a++)
            {
                for (char b = 'A'; b <= 'H'; b++)
                {
                    if (a == 'A' || a == 'E' || b == 'A' || b == 'E')
                    {
                        Console.Write(a + "" + b + ", ");
                    }

                    for (char c = 'A'; c <= 'H'; c++)
                    {
                        if (c == 'A' || c == 'E')
                        {
                                Console.Write(a + "" + b + "" + c + ", ");
                        }
                    }
                }
            }

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Begin with consonant, end with vowel:");

            for (char a = 'A'; a <= 'H'; a++)
            {
                for (char b = 'A'; b <= 'H'; b++)
                {
                    if (a == 'B' || a == 'C' || a == 'D' || a == 'F' || a == 'G' || a == 'H')
                    {
                        if (b == 'A' || b == 'E')
                        {
                                Console.Write(a + "" + b + ", ");
                        }

                        for (char c = 'A'; c <= 'H'; c++)
                        {
                            if (c == 'A' || c == 'E')
                            {
                                Console.Write(a + "" + b + "" + c + ", ");
                            }
                        }
                    }
                }
            }

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Middle letter is vowel, unique characters:");

            for (char a = 'A'; a <= 'H'; a++)
            {
                for (char b = 'A'; b <= 'H'; b++)
                {
                    for (char c = 'A'; c <= 'H'; c++)
                    {
                        if (b == 'A' || b == 'E')
                        {
                            if (a == b || b == c || a == c)
                            {
                                break;
                            }

                            else
                            {
                                Console.Write(a + "" + b + "" + c + ", ");
                            }
                        }
                    }
                }
            }
        }
    }
}
