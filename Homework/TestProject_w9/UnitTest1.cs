namespace TestProject_w9
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            VAT calculator = new VAT();
            
            calculator.SetVATRate(20); 

            double price = 20;
            double vat = calculator.FindVAT(price);
            Console.WriteLine($"VAT for price {price}: {vat}");

            double priceWithoutTax = calculator.FindPrice(true, price);
            Console.WriteLine($"Price without tax: {priceWithoutTax}");

            double priceWithTax = calculator.FindPrice(false, price);
            Console.WriteLine($"Price with tax: {priceWithTax}");

            double fullPrice = calculator.FindPriceOnTax(4);
            Console.WriteLine($"Full price based on VAT: {fullPrice}");

            bool is20Percent = calculator.IsTaxPercent20();
            Console.WriteLine($"Is VAT rate 20%: {is20Percent}");
        }
    }
}