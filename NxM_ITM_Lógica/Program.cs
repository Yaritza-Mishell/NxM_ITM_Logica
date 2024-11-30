using System;

namespace MatrixGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese las dimensiones de la matriz:");
            Console.Write("Número de filas (N): ");
            int rows = int.Parse(Console.ReadLine());
            Console.Write("Número de columnas (M): ");
            int cols = int.Parse(Console.ReadLine());

            int[,] matrix = MatrixGenerator.GenerateMatrix(rows, cols);
            GameLogic.PlayGame(matrix, rows, cols);
        }
    }
}
