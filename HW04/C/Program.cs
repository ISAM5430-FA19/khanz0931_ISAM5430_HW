using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C
{
    class Program
    {
        static void Main(string[] args)
        {
            int countLetter = 0, countVowel = 0, countConsonant = 0, countSyllable = 0;
            char letter, prevLetter= '\0';
            bool increaseOrder = false, musicalLetter = false;

            while (true)
            {
                Console.WriteLine("Enter a letter: ");
                var keyInfo = Console.ReadKey();
                letter = char.ToUpperInvariant(keyInfo.KeyChar);
                Console.WriteLine();

                if (!char.IsLetter(letter))
                {
                    break;
                }

                countLetter++;

                if (letter > prevLetter)
                {
                    increaseOrder = true;
                }

                else
                {
                    increaseOrder = false;
                }

                if (letter == 'C' || letter == 'D' || letter == 'E' || letter == 'F' || letter == 'G' || letter == 'A' || letter == 'B')
                {
                    musicalLetter = true;
                }

                else
                {
                    musicalLetter = false;
                }

                prevLetter = letter;

                if (letter == 'A' || letter == 'E' || letter == 'I' || letter == 'O' || letter == 'U' || letter == 'Y')
                {
                    countVowel++;
                    countSyllable++;
                }

                else
                {
                    countConsonant++;
                }
            }

            Console.WriteLine();
            Console.WriteLine($"Number of letters: {countLetter}");
            Console.WriteLine($"Number of vowels: {countVowel}");
            Console.WriteLine($"Number of consonants: {countConsonant}");
            Console.WriteLine($"Number of syllables: {countSyllable}");
            Console.WriteLine($"Increasing order? {increaseOrder}");
            Console.WriteLine($"Playable on musical instrument? {musicalLetter}");
        }
    }
}
