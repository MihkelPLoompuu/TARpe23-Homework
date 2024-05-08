namespace Ul1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string x = Console.ReadLine();
            string y = Console.ReadLine();
            double tulemus = x * (y / 100);

            Console.WriteLine($"{y}% arvust {x} on {tulemus}");
        }
    }
}