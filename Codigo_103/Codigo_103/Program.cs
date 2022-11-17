using System;
using System.Collections.Generic;
using System.IO;

namespace Codigo_103
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> values = new Dictionary<string, int>();

            Console.Write("Enter file full path: ");
            string path = Console.ReadLine();

            try
            {
                using StreamReader sr = File.OpenText(path);
                while (!sr.EndOfStream)
                {
                    string[] line = sr.ReadLine().Split(",");
                    values.Add(line[0], int.Parse(line[1]));
                    Console.WriteLine(values);
                }
            }
            catch (IOException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
