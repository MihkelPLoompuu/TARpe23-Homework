namespace ul_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("lIST OF 4 RANDOM NUMBERS IS:");
            Random random = new Random();            
            Console.WriteLine(random.Next(110, 200));
            Console.WriteLine(random.Next(110, 200));
            Console.WriteLine(random.Next(110, 200));
            Console.WriteLine(random.Next(110, 200));
            int sum = random.Next();            
            Console.WriteLine("Sum of all items is:" + sum);
        }
    }
}
