// 47. Задайте двумерный массив размером m×n,
//заполненный случайными вещественными числами.

int ReadData(string line)
{
    Console.Write(line);
    int number = int.Parse(Console.ReadLine() ?? "0");
    return number;
}
// Универсальный метод генерации и заполнение двумерного массива
double[,] Fill2DArray(int countRow, int countColumn, int topBorder, int downBorder)
{
    System.Random rand = new System.Random();
    double[,] array2D = new double[countRow, countColumn];
    //   0 1 2 3
    // 0 x
    // 1       y
    // 2
    for (int i = 0; i < countRow; i++)
    {
        for (int j = 0; j < countColumn; j++)
        {
            array2D[i, j] = Math.Round(rand.NextDouble() * (topBorder - downBorder) + downBorder, 1);
        }
    }
    return array2D;
}
// // Печать двумерного массива
// void Print2DArray(double[,] matr)
// {
//     for (int i = 0; i < matr.GetLength(0); i++)
//     {
//         for (int j = 0; j < matr.GetLength(1); j++)
//         {
//             Console.Write($"{matr[i, j]} ");
//         }
//         Console.WriteLine();
//     }
// }
ConsoleColor[] col = new ConsoleColor[]{ConsoleColor.Blue,ConsoleColor.Cyan,
                                        ConsoleColor.DarkBlue,ConsoleColor.DarkCyan,ConsoleColor.DarkGray,
                                        ConsoleColor.DarkGreen,ConsoleColor.DarkMagenta,ConsoleColor.DarkRed,
                                        ConsoleColor.DarkYellow,ConsoleColor.Gray,ConsoleColor.Green,
                                        ConsoleColor.Magenta,ConsoleColor.Red,ConsoleColor.White,
                                        ConsoleColor.Yellow};



// Печать двумерного массива цветом
void Print2DArrayColored(double[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.ForegroundColor = col[new System.Random().Next(0, 15)];
            Console.Write($"{matr[i, j]} ,\t");
            Console.ResetColor();
        }
        Console.WriteLine();
    }
}

int row = ReadData("Введите количество строк ");
int column = ReadData("Введите количество столбцов ");

double[,] arr2D = Fill2DArray(row, column, -99, 99);
//Print2DArray(arr2D);
Print2DArrayColored(arr2D);