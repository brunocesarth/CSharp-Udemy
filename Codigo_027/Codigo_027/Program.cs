using System;

namespace Codigo_027 {
    class Program {
        static void Main(string[] args) {
            Produto p = new Produto("TV", 500.00, 10);

            p.Nome = "T";
            //p.Preco => Não funciona pq é somente leitura

            Console.WriteLine(p.Nome);
            Console.WriteLine(p.Preco);
        }
    }
}
