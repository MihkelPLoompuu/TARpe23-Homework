using Homework_w9_ex1;
using Microsoft.VisualStudio.TestPlatform.CommunicationUtilities;

namespace TestVAT
{
    [TestClass]
    public class UnitTest1
    {
        private VAT vatCalculator;

        [TestMethod]
        public void TestMethod1()
        {
            vatCalculator = new VAT();
        }
        public void Test_setVAT() 
        {
            Assert.AreEqual(0, vatCalculator.vat);
        }
        public void Test_FineVATAndCalculater_WithVAT()
        {
            double price = 100;
            vatCalculator.FineVATAndCalculater(price);
            Assert.AreEqual(20, vatCalculator.VATFROMPrice);
        }
        public void Test_FineVATAndCalculater_WithoutVAT()
        {
            double price = 100;
            vatCalculator.FineVATAndCalculater(price);
            Assert.AreEqual(120, vatCalculator.VATFROMPrice);
        }
        public void Test_FindPriceBasedOnTax()
        {
            double num = 20;
            vatCalculator.FindPriceBasedOnTax(num);
            Assert.AreEqual(100,20); 
        }
        public void Test_FindVATFromPrice()
        {
            double price = 20;
            vatCalculator.FineVATAndCalculater(price);
            Assert.AreEqual(4, vatCalculator.VATFROMPrice);
        }

        public void Test_Vat_DefaultValue()
        {
            Assert.AreEqual(0.20, vatCalculator.vat);
        }
        public void Test_FindVATFromPrice1()
        {
            vatCalculator.FineVATAndCalculater(20);
            Assert.AreEqual(4, vatCalculator.VATFROMPrice);
        }
    }
}