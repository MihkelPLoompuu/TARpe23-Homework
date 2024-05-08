namespace Ul4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int targetNumber = random.Next(1, 10);

            int guess = 10;
            while (guess != targetNumber)
            {
                Console.Write("Guess the number im thinking of: ");
                guess = int.Parse(Console.ReadLine());

                if (guess != targetNumber)
                    Console.WriteLine("That is not the number im thinking:");
                else
                    Console.WriteLine("Correct, you guessed my number: " + targetNumber);
            }
        }
    }
}