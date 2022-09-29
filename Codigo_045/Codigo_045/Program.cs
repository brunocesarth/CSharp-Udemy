using System;

namespace Codigo_045 {
    class Program {
        static void Main(string[] args) {
            int n = int.Parse(Console.ReadLine());
            int[,] mat = new int[n, n];

            for (int i = 0; i < n; i++) {
                string[] s = Console.ReadLine().Split(' ');
                for (int j = 0; j < n; j++) {
                    mat[i, j] = int.Parse(s[j]);
                }
            }

            Console.WriteLine("Main diagonal:");
            for (int i = 0; i < n; i++) {
                Console.WriteLine(mat[i,i] + " ");
            }

            Console.WriteLine();
            int contaNegativos = 0;
            for (int i = 0; i < n; i++) {
                for (int j = 0; j < n; j++) {
                    if (mat[i,j] < 0) {
                        contaNegativos++;
                    }
                }
            }
            Console.WriteLine("Negative numbers: " + contaNegativos);
        }
    }
}
