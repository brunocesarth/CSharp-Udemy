using System.Globalization;

namespace Codigo_027 {
    class Produto {

        private string _nome;
        private double _preco;
        private int _quantidade;

        public Produto() {
        }

        public Produto(string nome, double preco, int quantidade) {
            _nome = nome;
            _preco = preco;
            _quantidade = quantidade;
        }

        public string Nome {
            get {
                return _nome;
            }
            set {
                if (value != null && value.Length > 1) {
                    _nome = value;
                }
            }
        }

        public double Preco {
            get {
                return _preco;
            }
        }

        public int Quantidade {
            get {
                return _quantidade;
            }
        }

        public double ValorTotalEmEstoque() {
            return _preco * _quantidade;
        }

        public void AdicionarProduto(int quantidade) {
            _quantidade += quantidade;
        }

        public void RemoverProduto(int quantidade) {
            _quantidade -= quantidade;
        }

        public override string ToString() {
            return _nome
                + ", $"
                + _preco.ToString("F2", CultureInfo.InvariantCulture)
                + ", "
                + _quantidade
                + " unidades, Total: $"
                + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
