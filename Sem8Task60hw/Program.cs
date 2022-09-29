// 60: Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, добавляя 
// индексы каждого элемента.Массив размером 2 x 2 x 2
//-----------------------------------------------------------------------

// Заполняем массив случайными числами
int[,,] Fill3DArray(int rows, int columns, int depth)
{
    int[,,] array = new int[rows, columns, depth];
    List<int> num = Enumerable.Range(10, 99).ToList();
    Random rnd = new Random();
    int index = 0;
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            for (int k = 0; k < depth; k++)
            {
                index = rnd.Next(num.Count);
                array[i, j, k] = num[index];
                num.RemoveAt(index);
            }
        }
    }
    return array;
}

// Печать 3D массива с индексом
void Print3DArr(int[,,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            for (int k = 0; k < arr.GetLength(2); k++)
            {
                Console.Write($"{arr[i, j, k]}({i},{j},{k})\t");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
}
int[,,] array3D=Fill3DArray(2,2,2);
Print3DArr(array3D);