using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_w9
{
    public class VAT
    {
        public double VATRate = 0.20;


        public void VATrate(double rate)
        {
            VATRate = rate / 100.0;
        }


        public double FindVAT(double price)
        {
            return price * VATRate;
        }

        
        public double FindPrice(bool isWithTax, double amount)
        {
            if (isWithTax)
            {
             
                return amount / (1 + VATRate);
            }
            else
            {
              
                return amount * (1 + VATRate);
            }
        }
    }
}
