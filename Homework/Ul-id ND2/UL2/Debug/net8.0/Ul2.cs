using System.Collections;
using System.Collections.Generic;
using static System.Net.Mime.MediaTypeNames;
using System.Diagnostics;

namespace Ul2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string inputFile = "test.txt";
            string outputFile = "A.txt";
            string m = "revers number";
            List<string> list = new List<string>();
            using (StreamReader reader = new StreamReader("C:\\Users\\mihke\\OneDrive\\Desktop\\Ul2\\Ul2\\bin\\Debug\\net8.0\\test.txt"))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {                    
                    list.Add(line);                    
                    Console.WriteLine(line);                    

                }
            }
            list.Reverse();
            using (StreamWriter writer = new StreamWriter("C:\\Users\\mihke\\OneDrive\\Desktop\\Ul2\\Ul2\\bin\\Debug\\net8.0\\A.txt", true))
            {
                Console.WriteLine(m);
                for (int i = 0; i < list.Count; i++)
                {                    
                    int linenumber = 1+i;
                    string line = null;                     
                    writer.Write($"{linenumber}: {line}");
                    linenumber++;
                    writer.WriteLine(list[i]);                    
                }                                            
            }
        }
        
    }
}
