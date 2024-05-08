            namespace Homework_w5
    {
        internal class Program
        {
            static void Main(string[] args)
            {
                Sugu("");
                Aasta("");
                Kuu("");
                Päev(0);
                Haigla("");
                Mitmes(0);
                Console.WriteLine("We Enter your info now and prind your ID");
                Isikukood();
            }

            static void Sugu(string sugu)
            {
                bool stat = true;
                while (stat)
                {
                    try
                    {
                        Console.WriteLine("Enter your personal information");
                        Console.Write("Enter sugu: ");
                        sugu = Console.ReadLine();
                        stat = false;
                        if (sugu == "Male" || sugu == "male")
                        {
                            Console.WriteLine("Id first nr : 5");
                        }
                        else if (sugu == "Female" || sugu == "female")
                        {
                            Console.WriteLine("Id first nr : 4");
                        }
                    }
                    catch (FormatException e)
                    {
                        Console.WriteLine(e.Message);
                    }
                }
            }
            static void Aasta(string aasta)
            {
                bool stat = true;
                while (stat)
                {
                    try
                    {
                        Console.Write("sünni aasta: ");
                        aasta = Console.ReadLine();
                        var result = aasta.Substring(aasta.Length - 2);
                        Console.WriteLine($"ID next Nr is : {result}");
                        stat = false;
                    }
                    catch (ArgumentOutOfRangeException e)
                    {
                        Console.WriteLine(e.Message);
                    }
                }

            }
            static void Haigla(string haigla)
            {
                bool stat = true;
                while (stat)
                {
                    try
                    {
                        Console.Write("Place of bitrth :");
                        haigla = Console.ReadLine();
                        stat = false;
                        if (haigla == "Pärnu" || haigla == "Narva")
                        {
                            Console.WriteLine("Id next nr is :42");
                        }
                        else if (haigla == "Tallinn" || haigla == "Tartu")
                        {
                            Console.WriteLine("Id next nr is : 32");
                        }
                    }
                    catch (FormatException e)
                    {
                        Console.WriteLine(e.Message);
                    }
                }
            }
            static void Mitmes(int mitmes)
            {
                bool stat = true;
                while (stat)
                {
                    try
                    {
                        Console.Write("mitmes laps: ");
                        mitmes = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine($"Birth nr : {mitmes}");
                        stat = false;
                    }
                    catch (FormatException e)
                    {
                        Console.WriteLine(e.Message);
                    }
                }
            }
            static void Päev(int kuupäev)
            {
                bool stat = true;
                while (stat)
                {
                    try
                    {
                        Console.Write("päev: ");
                        kuupäev = Convert.ToInt32(Console.ReadLine());
                        stat = false;
                    }
                    catch (FormatException e)
                    {
                        Console.WriteLine(e.Message);
                    }
                }

            }
            static void Kuu(string kuu)
            {
                bool stat = true;
                while (stat)
                {
                    try
                    {
                        Console.Write("sünni Kuu: ");
                        kuu = Console.ReadLine();
                        stat = false;
                        if (kuu == "Jaanuar" || kuu == "Jan")
                        {
                            Console.WriteLine(" Id number is : 01");
                        }
                        if (kuu == "Veebruar" || kuu == "Veb")
                        {
                            Console.WriteLine("Id number is : 02");
                        }
                        if (kuu == "Märts")
                        {
                            Console.WriteLine("Id number is : 03");
                        }
                        if (kuu == "April" || kuu == "april")
                        {
                            Console.WriteLine("Id number is : 04");
                        }
                        if (kuu == "Mai" || kuu == "mai")
                        {
                            Console.WriteLine("Id number is : 05");
                        }
                        if (kuu == "Juuni" || kuu == "Jun")
                        {
                            Console.WriteLine("Id number is : 06");
                        }
                        if (kuu == "Juuli" || kuu == "Jul")
                        {
                            Console.WriteLine("Id number is : 07");
                        }
                        if (kuu == "August" || kuu == "Aug")
                        {
                            Console.WriteLine("Id number is : 08");
                        }
                        if (kuu == "September" || kuu == "Sep")
                        {
                            Console.WriteLine("Id number is : 09");
                        }
                        if (kuu == "oktoober" || kuu == "Okt")
                        {
                            Console.WriteLine("Id number is : 10");
                        }
                        if (kuu == "November" || kuu == "Nov")
                        {
                            Console.WriteLine("Id number is : 11");
                        }
                        if (kuu == "Detsember" || kuu == "Dets")
                        {
                            Console.WriteLine("Id number is : 12");
                        }
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e.Message);
                    }
                }
            }
            static void Isikukood()
            {
                try
                {
                    Console.Write("Enter  sugu Id nr: ");
                    int sugu = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Enter  aasta first Id next nr: ");
                    int aasta = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Enter aasta second Id next nr: ");
                    int aasta1 = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Enter kuu firest Id next nr: ");
                    int kuu = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Enter  kuu next Id next nr: ");
                    int kuu1 = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Enter kuupäeva first nr: ");
                    int päev = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Enter kuupäeva second nr: ");
                    int paev = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Enter your Hospital first nr: ");
                    int haigla = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Enter your Hospital second nr: ");
                    int haigla1 = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Enter your mitmes nr: ");
                    int mitmes = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("siin on su Id:");
                    Console.Write(sugu);
                    Console.Write(aasta);
                    Console.Write(aasta1);
                    Console.Write(kuu);
                    Console.Write(kuu1);
                    Console.Write(päev);
                    Console.Write(paev);
                    Console.Write(haigla);
                    Console.Write(haigla1);
                    Console.Write(mitmes);
                    int check = 1 * sugu + 2 * aasta + 3 * aasta1 + 4 * kuu + 5 * kuu1 + 6 * päev + 7 * paev + 8 * haigla + 9 * haigla1 + 1 * mitmes;
                    int M = check / 11;
                    if (M > 10)
                    {
                        Console.WriteLine(M = 9);
                    }
                    Console.WriteLine(M);

                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
        }
    }