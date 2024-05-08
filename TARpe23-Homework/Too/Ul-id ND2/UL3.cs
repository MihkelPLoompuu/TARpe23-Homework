using System.ComponentModel;

namespace UL3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the square: ");
            int S = Convert.ToInt32(Console.ReadLine());

            WriteSquareOfNumbers(S);
        }

        static void WriteSquareOfNumbers(int number)
        {           
            string mm = new string((char)(number + '0'), number);

            using (StreamWriter writer = new StreamWriter("text.txt"))
            {
                for (int i = 0; i < number; i++)
                {
                    writer.WriteLine(mm);
                }
            }

            Console.WriteLine($"{number} on selles failis text.txt");
        }
    }

}

           
        
