namespace HomeWork_ul_4
{
    internal class Program
    {
        static void Main(string[] args)
        {           
            PrintCharacters();            
            static void PrintCharacters()
            {
                string characters = "*******";
                for (int i =characters.Length - 1; i >=0; i--)
                {
                    for (int j = 0; j <= i; j++)
                    {
                        Console.Write(characters[j]);
                    }
                    Console.WriteLine();
                }
            }
        }
    }
}