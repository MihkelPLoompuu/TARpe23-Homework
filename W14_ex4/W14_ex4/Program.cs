using System.Globalization;
using System.Net.Mail;

namespace W14_ex4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            manipulation("juhan.juurikas@company.eu");
            createMail("juhan mart juurikas", "Juhan juurikas Company");
        }
        static void manipulation(string mail) 
        {
            int maxLenght = 15;
            string ma = "juhan.juurikashruvhhre";
            if (maxLenght < ma.Length) 
            {
                ma = ma.Substring(0, maxLenght);
            }
            String[] spearator2 = {"." ,"@"};
            Int32 count2 = 3;
            String[] strlist2 = ma.Split(spearator2, count2,
               StringSplitOptions.RemoveEmptyEntries);

            Console.Write("Max Lenght Name : ");
            foreach (String e in strlist2)
            {
                Console.Write(e + " ");
            }
            Console.WriteLine();    
            Console.WriteLine("Mail: " + mail);
            String[] spearator = {".","@company.eu",};
            Int32 count1 = 3;
            String[] strlist1 = mail.Split(spearator, count1,
               StringSplitOptions.RemoveEmptyEntries);

            Console.Write("Name: ");
            foreach (String e in strlist1)
            {
                Console.Write(e.ToUpper() + " ");
            }
            Console.WriteLine();    
            String[] spearator1 = { "juhan.juurikas@", ".eu", };
            Int32 count = 3;
            String[] strlist = mail.Split(spearator1, count,
               StringSplitOptions.RemoveEmptyEntries);

            Console.Write("Domain: ");
            foreach (String k in strlist)
            {
                Console.Write(k + " ");
            }
            Console.WriteLine();  
        }
        static void createMail(string mail1 ,string mail) 
        {  
            //mail1        
            Console.Write("Name: ");
            Console.WriteLine(mail1);
            Console.Write("Mail: ");
            mail1 = "juhan mart ,juurikas";
            String[] spearator1 = {" "};
            Int32 count = 3;
            String[] strlist = mail1.Split(spearator1, count,
               StringSplitOptions.RemoveEmptyEntries);
            foreach (String e in strlist)
            {
                Console.Write(e.Replace(',','.'));
            }
            Console.WriteLine("@Company.eu");
            // mail
            Console.Write("Name: ");
            Console.WriteLine(mail);
            Console.Write("Mail: ");
            mail = ("Juhan .juurikas :Company");           
            String[] spearator = { " " };
            Int32 count1 = 3;
            String[] strlist1 = mail.Split(spearator, count1,
               StringSplitOptions.RemoveEmptyEntries);           
            foreach (String k in strlist1)
            {
                Console.Write(k.Replace(':','@'));
            }
            Console.WriteLine(".eu");
        }
    }
}
