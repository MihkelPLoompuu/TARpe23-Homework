namespace UL4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int Books;
            do
            {
                Console.Write("Enter books (max is 5): ");
                Books = Convert.ToInt32(Console.ReadLine());
            } while (Books <= 0 || Books > 5);

            Console.Write("Enter days : ");
            int Days = int.Parse(Console.ReadLine());

            double lateFee = CalculateLateFee(Days, Books);
            Console.WriteLine($"The late fee is: ${lateFee}");

            if (Days > 30)
            {
                CheckMembershipStatus();
            }
        }

        static double CalculateLateFee(int Days, int Books)
        {
            int daysOverdue = Math.Max(0, Days - 21);
            double pricePerDay = daysOverdue <= 8 ? 0.5 : 0.8; 
            return Books * daysOverdue * pricePerDay;
        }

        static void CheckMembershipStatus()
        {
            Console.WriteLine("Membership cancelled");
        }
    }
}

