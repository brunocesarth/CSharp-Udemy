using System;
using System.Globalization;

namespace Codigo_015 {
    class Program {
        static void Main(string[] args) {

            Retangulo retangulo = new Retangulo();

            Console.WriteLine("Entre a largura e altura do retângulo: ");
            retangulo.Largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            retangulo.Altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double area = retangulo.Area();
            double perimetro = retangulo.Perimetro();
            double diagonal = retangulo.Diagonal();

            Console.WriteLine("Área = " + area.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Perímetro = " + perimetro.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Diagonal = " + diagonal.ToString("F2", CultureInfo.InvariantCulture));

        }
    }
}
