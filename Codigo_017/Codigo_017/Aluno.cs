using System.Globalization;

namespace Codigo_017 {
    class Aluno {
        public string Nome;
        public double Nota1, Nota2, Nota3;

        public double NotaFinal() {
            return Nota1 + Nota2 + Nota3;
        }
        public string Status() {
            if (NotaFinal() >= 60.00) {
                return "APROVADO";
            } else {
                return "REPROVADO";
            }
        }

        public string NotaFaltante() {
            double NotaFaltante = 60.00 - NotaFinal();
            return NotaFaltante.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
