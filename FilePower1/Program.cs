using System;
using System.Collections.Generic;
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
            Queue<string> stringsQueue = new Queue<string>();

            Console.WriteLine("Digite as strings (pressione Enter após cada uma):");

           
            while (true)
            {
                string input = Console.ReadLine();
                if (input == "") 
                    break;
                else
                    stringsQueue.Enqueue(input); 
            }

            
            WriteToFile(fileName, stringsQueue);

            Console.WriteLine("Strings foram salvas no arquivo com sucesso.");
        }

        static void WriteToFile(string fileName, Queue<string> stringsQueue)
        {
            try
            {
                using (StreamWriter writer = new StreamWriter(fileName))
                {
                    foreach (string str in stringsQueue)
                    {
                        writer.WriteLine(str);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ocorreu um erro ao escrever no arquivo: {ex.Message}");
            }
        }
    }
}
