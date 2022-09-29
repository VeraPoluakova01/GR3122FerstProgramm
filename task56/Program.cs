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

// Печать результата
void PrintResult(string prefix, string data)
{
    Console.WriteLine(prefix + data);
}
//Вот код:
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

int FindMinRow(int[,] arr)
{
    int outIndexRow = -1;
    int min = int.MaxValue;
    int sum = 0;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++) { sum += arr[i, j]; }
        if (min > sum) { min = sum; outIndexRow = i; }
    }
    return outIndexRow;
}


int m = 3;
int n = 3;
int min = 1;
int max = 9;

int[,] matrix = new int[m, n];
int result = FindMinRow(matrix);
Fill2DArray(matrix, min, max);
Print2DArray(matrix);

PrintResult("Строка с наименьшей суммой: ", "№ " + result + " сверху вниз");