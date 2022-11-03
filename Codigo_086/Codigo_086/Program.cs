using System;
using System.Globalization;
using System.Collections.Concurrent;
using Codigo_086.Entities;

namespace Codigo_086
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter contract data");
            Console.Write("Number: ");
            int number = int.Parse(Console.ReadLine());
            Console.Write("Date (dd/MM/yyyy): ");
            DateTime date = DateTime.Parse(Console.ReadLine());
            Console.Write("Contract value: ");
            double value = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Contract contract = new Contract(number, date, value);
            Console.Write("Enter number of installments: ");
            int installments = int.Parse(Console.ReadLine());
            

            Console.WriteLine("Installments: ");
        }
    }
}
