using System;

namespace Codigo_092
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintService printService = new PrintService();

            Console.Write("How many values? ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string x = Console.ReadLine();
                printService.AddValue(x);
            }

            //Dá erro em tempo de execução, e não de compilação.
            int a = (int)printService.First();
            int b = a + 2;
            Console.WriteLine(b);

            printService.Print();
            Console.WriteLine("First: " + printService.First());
        }
    }
}
