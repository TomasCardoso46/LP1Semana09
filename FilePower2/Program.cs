using System;
using System.IO;

namespace FilePower1
{
    class Program
    {
        static void Main(string[] args)
        {
           
            if (args.Length == 0)
            {
                Console.WriteLine("Por favor, forneça o nome do arquivo como argumento.");
                return;
            }

            string fileName = args[0]; 

            Console.WriteLine("Digite as strings (pressione Enter após cada uma):");

            
            using (StreamWriter writer = new StreamWriter(fileName))
            {
                while (true)
                {
                    string input = Console.ReadLine(); 
                    if (input == "") 
                        break;
                    else
                        writer.WriteLine(input); 
                }
            }

            Console.WriteLine("Strings foram salvas no arquivo com sucesso.");
        }
    }
}
