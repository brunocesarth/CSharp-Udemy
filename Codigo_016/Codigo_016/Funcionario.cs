using System;
using System.Globalization;

namespace Codigo_016 {
    class Funcionario {
        public string Nome;
        public double SalarioBruto;
        public double Imposto;

        public double SalarioLiquido() {
            double salarioLiquido = SalarioBruto - Imposto;
            return salarioLiquido;
        }

        public void AumentarSalario(double porcentagem) {
            SalarioBruto += (SalarioBruto * (porcentagem / 100.00));
        }

        public override string ToString() {
            return Nome
                + ", $"
                + SalarioLiquido().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
