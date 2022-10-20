using System;
using Codigo_063.Entities;


namespace Codigo_063
{
    class Program
    {
        static void Main(string[] args)
        {
            BusinessAccount account = new BusinessAccount(8010, "Bob Brown", 100.0, 500.0);
            Console.WriteLine(account.Balance);

            //account.Balance = 200.00;
        }
    }
}
