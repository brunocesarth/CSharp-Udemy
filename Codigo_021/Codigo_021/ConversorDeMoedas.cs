namespace Codigo_021 {
    class ConversorDeMoedas {
        public static double iof = 6.0;

        public static double Calcular(double cotacao, double valor) {
            double total = cotacao * valor;
            return total  + ((total  * iof) / 100.00);
        }
    }
}
