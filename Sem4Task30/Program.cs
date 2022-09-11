//  30 Напишите программу, которая выводит массив из 8 элементов,
// заполненный нулями и единицами в случайном порядке.

//Анатолий

//Метод считывания данных пользователя
int ReadData(string line)
{
    // Выводим сообщениеq
    Console.Write(line);
    // Считываем число
    int number = int.Parse(Console.ReadLine() ?? "0");
    // Возвращаем значение
    return number;
}
//длинна массива num
int[] GenArr(int num)
{   //генирируем числа
    Random rnd = new Random();
    int[] arr = new int[num];// создаем массив
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(0,2);
    }
    return arr;
}
// печатаем (выводим массив)
//тип массив int[]
void PrintArr(int[] arr)
{
    for (int i = 0; i < arr.Length - 1; i++)
    {
        Console.Write(arr[i] + ", ");
    }
    Console.WriteLine(arr[arr.Length - 1]);
}

int arrLen = ReadData("Введите длину массива ");
int[] array = GenArr(arrLen);
PrintArr(array);

// Внизу команда состоит из двух (3) предыдущих
//PrintArr(GenArr(ReadData("Введите число ")));


// // Константин
// void PrintArray(int[] arr)
// {
//     string arrString = "";

//     for (int i = 0; i < arr.Length; i++)
//     {
//         arrString += arr[i];
//     }

//     Console.WriteLine(arrString);
// }

// int[] GenArray(int arrLength)
// {
//     int[] array = new int[arrLength];

//     for (int i = 0; i < arrLength; i++)
//     {
//         array[i] = new Random().Next(0, 2);
//     }
//     return array;
// }

// int[] array = GenArray(8);
// PrintArray(array);

