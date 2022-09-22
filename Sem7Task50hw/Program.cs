//  50. Напишите программу, которая на вход принимает позиции элемента
// в двумерном массиве, и возвращает значение этого элемента или же указание, 
// что такого элемента нет.

// Чтение данных из консоли
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
int FindElement(int x, int y, int[,] array)
{
    if (x < array.GetLength(0) && y < array.GetLength(1))
    {
        return array[x, y];
    }

    else

        return -1;
}

int row = ReadData("Введите количество строк ");
int column = ReadData("Введите количество столбцов ");
int[,] arr2D = Fill2DArray(row, column, 0, 99);
int x = ReadData("Введите номер строки эллемента: ");
int y = ReadData("Введите номер столбца : ");
int res = FindElement(x, y, arr2D);
Print2DArray(arr2D);
void PrintAnswer(int answer)
{
    if (answer == -1)
        Console.WriteLine("Заданной позиции не существуе в данном массиве ");

    else
        Console.WriteLine("искомый элемент  " + answer);
}
PrintAnswer(res);
