namespace Homework_w5
{
    internal class Program
    {
       public static void Main(string[] args)
        {
            Console.WriteLine("Info");
            Sugu();
            Aasta();
            Kuu();
            Päev();
            Haigla();
            Mitmes();
            CheckNr();
            Isikukood();
        }
       public static void Isikukood()
        {            
            Console.WriteLine($"isikukood on {Sugu}{Aasta}{Kuu}{Päev}{Haigla}{Mitmes}{CheckNr}");
            Console.WriteLine($"Birthdate is: {Päev}.{Kuu}.{Aasta}");
        }
       public static void Sugu() 
        {
            bool stat = true;
            while ( stat )
            {
                try
                {
                    Console.Write("Enter sugu: ");// sugu 3-mees ja 2-naine
                    int sugu = Convert.ToInt32(Console.ReadLine());
                    stat = false;
                    if (sugu == 3)
                    {
                        Console.WriteLine("Sex : Male");
                    }
                    else if (sugu == 2)
                    {
                        Console.WriteLine("Sex : Female");
                    }
                }
                catch  (FormatException e)
                {
                    Console.WriteLine(e.Message);
                }

            }

        }
       public static void Aasta() 
        { bool stat = true;
            while ( stat )
            {
                try
                {
                    Console.Write("sünni aasta: ");// aasta 1945 kirjuta ainult kaks viimast arvu.
                    int aasta = Convert.ToInt32(Console.ReadLine());
                    stat = false;
                }
                catch (FormatException e)
                {
                    Console.WriteLine (e.Message);
                }
            }

        }
       public static void Haigla()
        {
            bool stat = true;
            while( stat)
            {
                try
                {
                    Console.Write("haigla: ");// 42- pärnu 32- Tallinn
                    int haigla = Convert.ToInt32(Console.ReadLine());
                    Console.Write($"Place of bitrth :");
                    stat = false;
                    if (haigla == 42)
                    {
                        Console.WriteLine("Pärnu haiglas");
                    }
                    else if (haigla == 32)
                    {
                        Console.WriteLine("Tallinna haiglas");
                    }
                }
                catch (FormatException e) 
                {
                    Console.WriteLine (e.Message);
                }
            }
        } 
       public static void Mitmes() 
        {
            bool stat = true;
            while(stat)
            {
                try
                {
                    Console.Write("mitmes laps: ");
                    int mitmes = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine($"Birth nr : {mitmes}");
                    stat = false;
                }
                catch (FormatException e)
                {
                    Console.WriteLine (e.Message);
                }
            }
        }
       public static void CheckNr() 
        {
            bool stat = true;
            while (stat)
            {
                try
                {
                    Console.Write("KontrollNr: ");
                    int CheckNr = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine($"CheckNr : {CheckNr}");
                    stat = false;
                }
                catch (FormatException e) 
                {
                    Console.WriteLine (e.Message);
                }
            }
        }
       public static void Päev() 
        {
            bool stat = true;
            while (stat)
            {
                try
                {
                    Console.Write("päev: ");
                    int päev = Convert.ToInt32(Console.ReadLine());
                    stat = false;
                }
                catch (FormatException e)
                {
                    Console.WriteLine(e.Message);
                }
            }
            
        } 
       public static void Kuu()
        {
            bool stat = true;
            while (stat)
            {
                try
                {
                    Console.Write("sünni Kuu: ");
                    int Kuu = Convert.ToInt32(Console.ReadLine());
                    stat = false;
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
        }
    }
}