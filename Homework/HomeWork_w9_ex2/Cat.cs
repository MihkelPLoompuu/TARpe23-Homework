using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_w9_ex2
{
    public class Cat
    {
        public bool CatIsPlaying(bool isSummer, int temp)
        {            
            if (isSummer == true)
            {
                Console.WriteLine("Summer");
            }
            else if (isSummer == false) 
            {
                Console.WriteLine("Wintre");
            }
            if (temp > 25 && temp < 45 && isSummer == true)
            {
                Console.WriteLine("Summer");
                isSummer = true;
            }
            else if (temp >= 25 && temp < 35 && isSummer == false)
            {
                Console.WriteLine("Winter");
            }
            else if (temp > 0 && temp < 25) 
            {
                Console.WriteLine("temp must be at least 25");
            } 
            return false;
        }
    }
}
