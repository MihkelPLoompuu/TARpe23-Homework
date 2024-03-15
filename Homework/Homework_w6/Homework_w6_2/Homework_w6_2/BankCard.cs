using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_w6_2
{
    internal class BankCard
    {
        public int accountBalance; //amount of money
        public string cardType; // maestro or Visa
        public string cardNumber; // max is 8
        public void Card()
        {
            Random random = new Random();// enter a random nauber 900 - 10000
            int min = 900;
            int max = 10000;
            int Balanc = random.Next(min, max + 1);
            accountBalance = Balanc;
            string CarType = "Visa";
            cardType = CarType;
            Console.WriteLine($"Your {CarType} account has {Balanc}$");
        }
        public void increaseBalance()
        {
            Console.WriteLine($"Account balance is {accountBalance}$");
            Random random = new Random();
            int min = 100;
            int max = 10000;
            int In = random.Next(min, max + 1);
            int A = accountBalance + In;
            Console.WriteLine($"Your account balance is now {A}$");
            accountBalance = A;
        }
        public void DecreaseBalance()
        {
            Console.WriteLine($"Account balance is {accountBalance}$");
            Random random = new Random();
            int min = 10;
            int max = 10000;
            int In = random.Next(min, max + 1);
            int B = accountBalance - In;
            Console.WriteLine($"{B}$");
            if (B < 0)
            {
                Console.WriteLine("Cannot do this operation,insufficient funds");
            }
        }
        public void SetCardNumber(string number)
        {
            if (number.Length == 8)
            {
                cardNumber = number;
                Console.WriteLine($"Card number is : {cardNumber}");
            }
            else if (number.Length == 0) 
            {
                
            }
            else
            {
                Console.WriteLine("Invalid value, the length has to be 8!");
            }
        }
        public BankCard()
        {
            Card();
            increaseBalance();
            DecreaseBalance();
            SetCardNumber("");
        }
    }
}
