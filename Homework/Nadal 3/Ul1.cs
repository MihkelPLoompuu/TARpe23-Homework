using System.ComponentModel.DataAnnotations;

namespace UL1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IniteilAmount();
        }
        static void IniteilAmount() 
        {
            Console.Write("Enter you Number :");
            double Laen = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter how many years you take :");
            int Year = Convert.ToInt32(Console.ReadLine());
            double Rate = 0.021;
            double result = Laen * Rate;
            double sum = Laen + result;
            Console.WriteLine("First Year :" + sum + "eurot");
            if (Year < 0 ) 
            {
                Console.WriteLine("viga pead vahemalt uhe aasta sisestama");
            }
            else if (Year > 1 )
            {                
                {
                    double i  = sum * Rate;
                    double res = sum + i;
                    Console.WriteLine("Second Year :" + res + "eurot");
                }                
            }             
        }
    }
}
