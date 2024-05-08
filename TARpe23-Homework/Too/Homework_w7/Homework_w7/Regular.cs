using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_w7
{   
    internal class Regular : Iirons
    {
        public int temp;
        public string Program;
        public virtual void Descale()
        {
            Console.WriteLine("Machine has been used 3 times and needs cleaning");
            Console.WriteLine("Machine is cleaned");
        }
        public virtual void DoIroning(string program)
        {
            /*200°C - 230 °C: Linen program 
             * 150°C - 199 °C: Cotton program 
             * 120°C - 149 °C: Silk program 
             * 90°C - 119 °C: Synthetics program*/
            Program = program;
            Random random = new Random();
            int min = 90;
            int max = 119;
            int A = random.Next(min, max);
            Random rando = new Random();
            int mi = 120;
            int ma = 149;
            int B = rando.Next(mi, ma);
            Random rand = new Random();
            int m = 150;
            int a = 199;
            int C = rand.Next(m, a);
            Random ran = new Random();
            int s = 200;
            int f = 230;
            int D = ran.Next(s, f);
            if (program == "Synthetics") 
            {
                Console.WriteLine($"{program} is ironing with {A} degrees ironing with steam");
            }
            else if (program == "Silk")
            {
                Console.WriteLine($"{program} is ironing with {B} degrees ironing with steam");
            }
            else if (program == "Cotton")
            {
                Console.WriteLine($"{program} is ironing with {C} degrees ironing with steam");
            }
            else if (program == "Linen")
            {
                Console.WriteLine($"{program} is ironing with {D} degrees");
            }
            else 
            {
                Console.WriteLine("We do not have a program for Ironing that stuff");
            }
        }
        public virtual void DoIroning(int A)
        { /*200°C - 230 °C: Linen program 
           * 150°C - 199 °C: Cotton program 
           * 120°C - 149 °C: Silk program 
           * 90°C - 119 °C: Synthetics program*/
            temp = A;
            if (A > 90 && A < 119)
            { Console.WriteLine($"{A} is ironing with Synthetics program"); }
            else if (A > 120 && A < 149)
            { Console.WriteLine($"{A} is ironing with Silk program"); }
            else if (A > 150 && A < 199)
            { Console.WriteLine($"{A} is ironing with Cotton program"); }
            else if (A > 200 && A < 230)
            { Console.WriteLine($"{A} is ironing with Linen program"); }
            else if (A > 230)
            { Console.WriteLine("max temp is 230"); }
        }

        public virtual void TurnOff()
        {
                Console.WriteLine("Machine turn off");            
        }

        public virtual void TurnOn()
        {
            Console.WriteLine("Machine turn on");
        }

        public virtual void UseSteam()
        {
            if (temp < 199 && temp > 120)
            {
                Console.WriteLine("Steam is on.");
            }
            else if (Program == "Linen")
            {
                Console.WriteLine("Steam is already on.");
            }
        }
    }
}
