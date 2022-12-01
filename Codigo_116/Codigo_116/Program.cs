using System;
using System.IO;
using System.Collections.Generic;
using Codigo_116.Entities;

namespace Codigo_116
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter full file path: ");
            string path = Console.ReadLine();

            List<Product> list = new List<Product>();

            using StreamReader sr = File.OpenText(path);
            while (!sr.EndOfStream)
            {
                sr.ReadLine().Split(',');
            }
        }
    }
}
