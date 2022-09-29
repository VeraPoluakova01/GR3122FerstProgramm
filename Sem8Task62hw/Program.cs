//62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07 
//--------------------------------------------------------------------

// Метод генерации и заполнения двумерного массива спирально
static int[,] Fill2DArraySpiral(int rows, int cols)
{
    int[,] array2D = new int[rows, cols];

    int row = 0; int col = 0; // Счётчики по массиву
    int dX = 1; int dY = 0; // Изменения счётчиков row и col на каждом шаге
    int steps = cols; // Количество шагов до поворота
    int dirChangeCount = 0; // Количество осуществлённых поворотов

    for (int i = 0; i < rows * cols; i++)
    {
        // Заполняем текущий элемент массива, уменьшаем счётчик шагов
        array2D[row, col] = i + 1;
        steps--;

        // Если шагов в текущем направлении не осталось - меняем направление
        if (steps == 0)
        {
            int buf = dX;
            dX = -dY;
            dY = buf;
            steps = Math.Abs(dY) * rows + Math.Abs(dX) * cols - (dirChangeCount / 2 + 1); // Вычисляем количество предстоящих шагов
            dirChangeCount++;
        }
        row += dY;
        col += dX;
    }
    return array2D;
}
// Печать двумерного массива
static void Print2DArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i, j]} \t");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}
int[,] spirale=Fill2DArraySpiral(5,5);
Print2DArray(spirale);
