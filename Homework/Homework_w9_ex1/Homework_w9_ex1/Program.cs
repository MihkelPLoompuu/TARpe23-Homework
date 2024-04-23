namespace Homework_w9_ex1
{
    internal class Program
    {
        static void Main(string[] args)
        {       
            VAT vat = new VAT();
            vat.Vat(20);
            vat.FineVATAndCalculater(20);
            vat.FindPriceBasedOnTax(4);
            vat.VATRATECHeack();
        }
    }
}
