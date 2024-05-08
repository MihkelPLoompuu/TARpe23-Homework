using System;
using System.Transactions;

namespace UL1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your word:");
            String word = Console.ReadLine();            
            string result = Second(word);
            Console.WriteLine(result);
        }

        static string Second(string word)
        {
            if (word.Length < 2)
            {
                return "Too short word!";
            }

            string result = "";
            for (int i = 0; i < word.Length; i += 2)
            {
                result += word[i];
            }
            return result;
        }
    }
}
