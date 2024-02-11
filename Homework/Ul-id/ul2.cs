namespace Ul_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter 3 strings:");
            var list1 = new List<string>();
            list1.Add("Raddish");
            list1.Add("Horse");
            list1.Add("Cabbage");
            foreach (string a in list1)
                Console.WriteLine(a);
            list1.Sort();

            Console.WriteLine();
            Console.WriteLine("Results in a sorterd list are:");
            foreach (string a in list1)
                Console.WriteLine(a);
        }
    }
}
