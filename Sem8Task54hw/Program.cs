// 54: Задайте двумерный массив. Напишите программу, 
// которая упорядочит по убыванию элементы каждой строки 
// двумерного массива.
//------------------------------------------------------------------------
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

// упорядочиние массива
int[,] UpdateArr(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        List<int> Row = new List<int>();
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Row.Add(arr[i, j]);
        }
        Row.Sort();
        Row.Reverse();
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = Row[j];
        }

    }
    return arr;
}

int[,] array2D = new int[4, 4];
Fill2DArray(array2D, 0, 9);
Print2DArray(array2D);
int[,] sortArray2D = UpdateArr(array2D);
Print2DArray(sortArray2D);