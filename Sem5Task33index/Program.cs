﻿// //33-indx Задайте массив. Напишите программу, которая
// определяет, присутствует ли заданное число в массиве
// и назодит его индекс
//-------------------------------------------------------------

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
// Заполняем массив
int[] GenArray(int arrLength, int start, int stop)
{
    int[] array = new int[arrLength];
    Random ren = new Random();

    for (int i = 0; i < arrLength; i++)
    {
        array[i] = ren.Next(start, stop + 1);
    }
    return array;
}

// печатаем массив
void PrintArray(int[] arr)
{
    Console.Write("[" + arr[0] + ", ");
    for (int i = 1; i < arr.Length - 1; i++)
    {
        Console.Write(arr[i] + ", ");
    }
    Console.Write(arr[arr.Length - 1] + "]");
    Console.WriteLine();
}
// ищем элемент
int ChekNumInArr(int[] arr, int num)
{
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] == num)
        {
            return i;
        }
    }
    return -1;
}
// вывод ответа
void PrintAnswer(int index)
{
    Console.WriteLine(index > 0 ? ("Элемент найден на позиции: " + index) : "Нет");
}


int arrLength = ReadData("Введите длину массива: ");
int start = ReadData("Введите минимальное значение: ");
int stop = ReadData("Введите максимальное значение: ");


int[] arr = GenArray(arrLength, start, stop);
PrintArray(arr);
int num = ReadData("Введите искомое значение: ");
PrintAnswer(ChekNumInArr(arr, num));