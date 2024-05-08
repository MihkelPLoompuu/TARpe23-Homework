using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_w9_ex1
{
    public class VAT
    {

        public double vat;
        public double VATFROMPrice;
        public void Vat(double rate) 
        {
            vat = rate / 100;
        }
        public void FineVATAndCalculater(double price)
        {
            Vat(20);
            VATFROMPrice = (price * vat);
            Console.WriteLine($"Vat from prce is: {VATFROMPrice}$");
            bool M = true;
            bool H = true;
            while (H)
            {
                Console.WriteLine("Kas hindas on juba käibemaks või ei (yes or no)");
                string S = Console.ReadLine();
                if (S == "yes")
                {
                    Console.WriteLine("Okey");
                }
                else if (S == "no")
                {
                    Console.WriteLine("Okey");
                }
                while (M)
                {
                    Console.WriteLine("Kas sa tahad koos käibemaksuga või ilma käibemaksuta kui ilma siis (-), kui koos siis (+) ja " +
                        "kui tahad lihtsalt hind siis (=)");
                    string K = Console.ReadLine();
                    if (K == "+" && S == "no")
                    {
                        M = true;
                        break;
                    }
                    else if (K == "-" && S == "yes")
                    {
                        M = false;
                    }
                    else if (K == "=" && S == "yes") // ei saanud tööle nii et ta ei pritiks Price with VATi samal ajal kui lihtsalt hinda.
                    {
                        Console.WriteLine($"lihtsalt hind on {price}$");
                        break;
                    }
                }
                if (M == true)
                {
                    double PriceWithVAT = (price + VATFROMPrice);
                    Console.WriteLine($"Price with VAT {PriceWithVAT}$");
                }
                else if (M == false)
                {
                    double PriceWIthoutVAT = (price - VATFROMPrice);
                    Console.WriteLine($"Price without VAT {PriceWIthoutVAT}$");
                }
                break;
            }
        }
           
        public void FindPriceBasedOnTax(double num) 
        {
            Console.Write($"Vat is {num} and price is ");
            double Price = ((num * 100) / 20);
            Console.WriteLine($" {Price}");
        }
        public void VATRATECHeack()
        {
            if (vat == 0.20)
            {
                Console.WriteLine("VAT rate is correct");
            }
            else 
            {
                Console.WriteLine("VAT rate is wrong!");
            }
        }
    }
}
