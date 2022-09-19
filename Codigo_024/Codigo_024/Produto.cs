using System.Globalization;

namespace Codigo_024 {
    class Produto {

        public string Nome;
        public double Preco;
        public int Quantidade;

        public Produto() {}

        public Produto(string nome, double preco) {
            Nome = nome;
            Preco = preco;
        }

        public double ValorTotalEmEstoque() {
            return Preco * Quantidade;
        }

        public void AdicionarProduto(int quantidade) {
            Quantidade += quantidade;
        }

        public void RemoverProduto(int quantidade) {
            Quantidade -= quantidade;
        }

        public override string ToString() {
            return Nome
                + ", $"
                + Preco.ToString("F2", CultureInfo.InvariantCulture)
                + ", " 
                + Quantidade
                + " unidades, total: $"
                + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
