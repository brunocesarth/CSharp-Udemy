using System.Globalization;

namespace Codigo_043 {
    class Funcionario {
        public int Id { get; private set; }
        public string Nome { get; set; }
        public double Salario { get; private set; }

        public Funcionario(int id, string nome, double salario) {
            Id = id;
            Nome = nome;
            Salario = salario;
        }

        public Funcionario(int id) {
            Id = id;
        }

        public void AumentaSalario(double porcentagem) {
            Salario += Salario * porcentagem;
        }

        public override string ToString() {
            return Id + ", " + Nome + ", " + Salario.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
