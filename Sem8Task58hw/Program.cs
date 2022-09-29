// // 58: Задайте две матрицы. Напишите программу, которая будет 
// находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

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


int[,] MultMatrx(int[,] arr1, int[,] arr2)
{
    int[,] arr = new int[arr1.GetLength(0),arr2.GetLength(1)];

    for (int i = 0; i < arr1.GetLength(0); i++)
    {
        for (int j = 0; j < arr2.GetLength(1); j++)
        {
            for (int k = 0; k < arr2.GetLength(0); k++)
            {
                arr[i, j] += arr1[i, k] * arr2[k, j] ;
            }
        }

    }
    return arr;
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
    Console.WriteLine();
    
}

int[,] arrayFirst = new int[2, 2];
Fill2DArray(arrayFirst, 0, 15);
int[,] arraySecond = new int[2, 2];
Fill2DArray(arraySecond, 0, 15);
int[,] matrixMult=MultMatrx(arrayFirst, arraySecond);
Print2DArray(arrayFirst);
Print2DArray(arraySecond);
Print2DArray(matrixMult);

