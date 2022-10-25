using System;
using System.Globalization;
using System.Collections.Generic;
using Codigo_071.Entities;

namespace Codigo_071
{
    class Program
    {
        static void Main(string[] args)
        {
            List<TaxPayer> taxPayers = new List<TaxPayer>();

            Console.Write("Enter the number of tax payer: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Tax payer #{i} data:");
                Console.Write("Individual or company(i/c)? ");
                char ch = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Annual Income: ");
                double annualIncome = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                if (ch == 'i' || ch == 'I')
                {
                    Console.Write("Health expenditure: ");
                    double healthExpenditure = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    taxPayers.Add(new Personnel(name, annualIncome, healthExpenditure));
                }
                else
                {
                    Console.Write("Number of employees: ");
                    int numberEmployees = int.Parse(Console.ReadLine());
                    taxPayers.Add(new Corporate(name, annualIncome, numberEmployees));
                }
            }

            double totalTaxes = 0.0;
            Console.WriteLine();
            Console.WriteLine("TAXES PAID:");
            foreach (TaxPayer taxPayer in taxPayers)
            {
                Console.WriteLine(taxPayer.Name
                    + ": $"
                    + taxPayer.Taxes().ToString("F2", CultureInfo.InvariantCulture));
                totalTaxes += taxPayer.Taxes();
            }

            Console.WriteLine();
            Console.WriteLine("TOTAL TAXES: $" + totalTaxes.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
