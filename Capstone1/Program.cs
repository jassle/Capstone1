using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capstone1
{
    class Program
    {
        // Pig Latin Translator
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Igpay Atinlay Translator!!");
            bool repeat = true;
            while (repeat)
            {
                {

                    Console.WriteLine("Please enter a word you want to translate?");
                    string input = Console.ReadLine();
                    string piglatin = ToPigLatin(input);

                    repeat = Continue("Would you like to translate another word?");
                    
                }
            }
            Console.WriteLine("oodbyegay");

        }
        static string ToPigLatin(string input)
        {
            input = input.ToLower();
            char[] vowArray = { 'a', 'e', 'i', 'o', 'u' };
            int firstvowel;
            firstvowel = input.IndexOfAny(vowArray);
            if (firstvowel < 0)
            {
                Console.WriteLine("Not translatable");
                return input;
            }
            string firstletters;
            string restofword;
            firstletters = input.Substring(0, firstvowel);
            restofword = input.Substring(firstvowel);

            

            if (firstvowel != 0)
            {
                Console.WriteLine($"{restofword}{firstletters}{"ay"}");
            }
            else
                Console.WriteLine($"{input}{"way"}");
            return input;
        }
        public static bool Continue(string Message)
        {
            while (true)
            {
                Console.WriteLine(Message);
                string input = Console.ReadLine().ToUpper();
                if (input == "N")
                {
                    return false;
                }
                else if (input == "Y")
                {
                    return true;
                }
                else
                {
                    Console.WriteLine("Invalid input, try again");
                }
            }
        }    
        
    }
}
