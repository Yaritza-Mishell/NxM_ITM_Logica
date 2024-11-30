using System;

namespace MatrixGame
{
    public static class GameLogic
    {
        public static void PlayGame(int[,] matrix, int rows, int cols)
        {
            int baseNumber = 0;
            int currentRow = 0;
            int currentCol = 0;

            while (true)
            {
                Console.Clear();
                MatrixDisplay.DisplayMatrix(matrix, rows, cols, currentRow, currentCol, baseNumber);

                ConsoleKey key = Console.ReadKey(true).Key;

                // Detecta la tecla presionada y ajusta la posición
                if (key == ConsoleKey.UpArrow && currentRow > 0)
                {
                    currentRow--;
                }
                else if (key == ConsoleKey.DownArrow && currentRow < rows - 1)
                {
                    currentRow++;
                }
                else if (key == ConsoleKey.LeftArrow && currentCol > 0)
                {
                    currentCol--;
                }
                else if (key == ConsoleKey.RightArrow && currentCol < cols - 1)
                {
                    currentCol++;
                }
                else if (key == ConsoleKey.Escape)
                {
                    Console.WriteLine("\nJuego terminado. Presiona cualquier tecla para salir.");
                    Console.ReadKey();
                    break;
                }

                // Suma el valor de la celda actual al número base
                baseNumber += matrix[currentRow, currentCol];
                matrix[currentRow, currentCol] = 0; // Marca la celda como visitada
            }
        }
    }
}
