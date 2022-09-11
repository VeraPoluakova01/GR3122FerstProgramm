// 29 Напишите программу, которая задаёт массив из 8 элементов 
// и выводит их на экран.

//Метод считывания данных пользователя
int ReadData(string line)
{
    // Выводим сообщение
    Console.Write(line);
    // Считываем число
    int number = int.Parse(Console.ReadLine() ?? "0");
    // Возвращаем значение
    return number;
}
//длинна массива num
int[] GenArr(int num, int start, int stop)
{   //генирируем числа
    Random rnd = new Random();
    int[] arr = new int[num];// создаем массив
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(start, stop);
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

int arrLen = 8;
int start1 = ReadData("Введите начало диапазона значений ");
int stop1 = ReadData("Введите конец диапазлна значений ");
int[] array = GenArr(arrLen, start1, stop1);
PrintArr(array);