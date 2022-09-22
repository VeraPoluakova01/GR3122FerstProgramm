//  52. Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.

int ReadData(string line)
{
    // Выводим сообщение
    Console.WriteLine(line);
    // Считываем число
    int number = int.Parse(Console.ReadLine() ?? "0");
    // Возвращаем значение
    return number;
}

// Печать двумерного массива
void Print2DArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write(matr[i, j] + "\t");
        }
        Console.WriteLine();
    }
}

// Универсальный метод генерации и заполнение двумерного массива
int[,] Fill2DArray(int countRow, int countColumn, int topBorder, int downBorder)
{
    System.Random rand = new System.Random();
    int[,] array2D = new int[countRow, countColumn];
    for (int i = 0; i < countRow; i++)
    {
        for (int j = 0; j < countColumn; j++)
        {
            array2D[i, j] = rand.Next(topBorder, downBorder + 1);
        }
    }
    return array2D;
}

// вывод массив одномерного массива double
void Print1DArray(double[] array)
{
    Console.WriteLine("[{0}]", string.Join(", ", array));
}

double[] Count(int[,] arr2D)
{
    double[] arr = new double[arr2D.GetLength(1)];
    for (int i = 0; i < arr2D.GetLength(0); i++) 
    {
        for (int j = 0; j < arr2D.GetLength(1); j++) 
        {
            arr[j] = arr[j] + arr2D[i, j];
        }
    }
    for (int k = 0; k < arr.GetLength(0); k++)
    {
        arr[k] =arr[k] / ((double)arr2D.GetLength(0));
    }
    return arr;
}
int row = ReadData("Введите количество строк ");
int column = ReadData("Введите количество столбцов ");
int[,] arr2D = Fill2DArray(row, column, 0, 99);
Print2DArray(arr2D);
double[] res=Count(arr2D);
Print1DArray(res);