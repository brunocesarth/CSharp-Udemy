using System;
using Codigo_108.Services;

namespace Codigo_108
{
    class Program
    {
        delegate double BinaryNumericOperation(double n1, double n2);

        static void Main(string[] args)
        {
            double a = 10;
            double b = 12;

            BinaryNumericOperation op = CalculationService.Sum;

            double result = op(a, b);
            //double result = op.Invoke(a, b);
            Console.WriteLine(result);
        }
    }
}
