namespace Homework_w7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Regular regular= new Regular();
            regular.TurnOn();
            regular.DoIroning("Linen");
            regular.UseSteam();
            regular.DoIroning(210);
            regular.UseSteam();
            regular.DoIroning("Cotton");
            regular.Descale();
            regular.DoIroning("HAHAHAHAHAH");
            regular.TurnOff();
            Premium premium = new Premium();
            premium.TurnOn();
            premium.DoIroning("Linen");
            premium.UseSteam();
            premium.DoIroning(130);
            premium.UseSteam();
            premium.DoIroning("underwear");
            premium.TurnOff();
            Linen linen = new Linen();
            linen.TurnOn();
            linen.DoIroning("Cotton");
            linen.UseSteam();
            linen.DoIroning(110);
            linen.UseSteam();
            linen.DoIroning("Silk");
            linen.Descale();
            linen.TurnOff();
        }
    }
}
