using System;

namespace Codigo_046 {
    class Program {
        static void Main(string[] args) {
            string[] vet = Console.ReadLine().Split(' ');
            int M = int.Parse(vet[0]);
            int N = int.Parse(vet[1]);
            int[,] mat = new int[M, N];

            for (int i = 0; i < M; i++) {
                vet = Console.ReadLine().Split(' ');
                for (int j = 0; j < N; j++) {
                    mat[i, j] = int.Parse(vet[j]);
                }
            }

            int x = int.Parse(Console.ReadLine());
            for (int i = 0; i < M; i++) {
                for (int j = 0; j < N; j++) {
                    if (x == mat[i, j]) {
                        Console.WriteLine("Position " + i + "," + j);
                        if (j > 0) {
                            Console.WriteLine("Left: " + mat[i, j - 1]);
                        }
                        if (i > 0) {
                            Console.WriteLine("Up: " + mat[i - 1, j]);
                        }
                        if (j < N - 1) {
                            Console.WriteLine("Right: " + mat[i, j + 1]);
                        }
                        if (i < M - 1) {
                            Console.WriteLine("Down: " + mat[i + 1, j]);
                        }
                    }
                }
            }
        }
    }
}
