using System.Globalization;

namespace Codigo_029 {
    class Conta {
        public static double taxa = 5;

        public string Nome {
            get; set;
        }

        public int NumeroConta {
            get; set;
        }

        public double Saldo {
            get; set;
        }

        public Conta(string nome, int numeroConta, double saldo) {
            Nome = nome;
            NumeroConta = numeroConta;
            Saldo = saldo;
        }

        public void Deposito(double valor) {
            Saldo += valor;
        }

        public void Saque(double valor) {
            Saldo = ((Saldo - valor) - taxa);
        }

        public override string ToString() {
            return "Conta "
                + NumeroConta
                + ", Titular: "
                + Nome
                + ", Saldo: $"
                + Saldo.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
