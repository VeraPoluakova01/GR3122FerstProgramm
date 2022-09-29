// 56: Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить строку 
// с наименьшей суммой элементов.
//----------------------------------------------------------------------
void PrintResult(string line)
{
    Console.WriteLine(line);
}
void Print2DArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i, j]} ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

// Заполняем массив случайными числами
void Fill2DArray(int[,] matr, int min, int max)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = new Random().Next(min, max + 1);
        }
    }
}
int FindMinRow(int[,] array)
{
    int outIndexRow = -1;
    int min = int.MaxValue;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sum = sum + array[i, j];
        }
        if (min > sum)
        {
            min = sum;
            outIndexRow = i;
        }
    }
    return outIndexRow;
}

int[,] array2D = new int[4, 4];
Fill2DArray(array2D, 0, 15);
Print2DArray(array2D);
int index = FindMinRow(array2D);
PrintResult("Номер строки с минимальной суммой элементов: " + index);