using System;
using System.Globalization;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using Codigo_117.Entities;

namespace Codigo_117
{
    class Program
    {
        static void Print<T>(string message, IEnumerable<T> collection)
        {
            Console.WriteLine(message);
            foreach (T obj in collection)
            {
                Console.WriteLine(obj);
            }
            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            Console.Write("Enter full file path: ");
            string path = Console.ReadLine();
            Console.Write("Enter salary: ");
            double sal = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            List<Employee> list = new List<Employee>();
            try
            {
                using StreamReader sr = File.OpenText(path);
                while (!sr.EndOfStream)
                {
                    string[] vet = sr.ReadLine().Split(',');
                    string nome = vet[0];
                    string email = vet[1];
                    double salary = double.Parse(vet[2], CultureInfo.InvariantCulture);
                    list.Add(new Employee(nome, email, salary));
                }

                var r = from e in list
                        where e.Salary > sal
                        select e.Email;
                Print("Email of people whose salary is more than 2000.00: ", r);

                var r1 = (from e in list
                          where e.Name[0] == 'M'
                          select e.Salary).Sum();
                Console.WriteLine("Sum of salary of people whose name starts with 'M': " + r1.ToString("F2", CultureInfo.InvariantCulture));
            }
            catch (IOException e)
            {
                Console.WriteLine("An error occurred");
                Console.WriteLine(e.Message);
            }
        }
    }
}
