using System.Globalization;

namespace Codigo_029 {
    class Conta {
        public static double taxa = 5;

        public string Nome {
            get; set;
        }

        public int NumeroConta {
            get; private set;
        } //Private set, porque não pode ser alterado após a criação

        public double Saldo {
            get; private set;
        } //Private set, porque não pode ser alterado após a criação

        public Conta(string nome, int numeroConta) {
            Nome = nome;
            NumeroConta = numeroConta;
        }

        public Conta(string nome, int numeroConta, double depositoInicial) : this(nome, numeroConta) {
            Deposito(depositoInicial);
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
