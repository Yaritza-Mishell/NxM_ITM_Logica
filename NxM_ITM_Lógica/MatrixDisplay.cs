using System;

namespace MatrixGame
{
    public static class MatrixDisplay
    {
        public static void DisplayMatrix(int[,] matrix, int rows, int cols, int currentRow, int currentCol, int baseNumber)
        {
            Console.WriteLine("Use las flechas para moverse. Presione ESC para salir.\n");
            Console.WriteLine($"Número Base: {baseNumber}\n");

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    if (i == currentRow && j == currentCol)
                    {
                        Console.ForegroundColor = ConsoleColor.Green; // Destaca la posición actual
                        Console.Write(matrix[i, j] + "\t");
                        Console.ResetColor();
                    }
                    else
                    {
                        Console.Write(matrix[i, j] + "\t");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
