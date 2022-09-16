// Создайте массив из эле-ов 
int ReadData(string line)
{
    // Выводим сообщениеq
    Console.Write(line);
    // Считываем число
    int number = int.Parse(Console.ReadLine() ?? "0");
    // Возвращаем значение
    return number;
}
//Универсальный метод генирации и заполнения массива
//нижн.граница   верх граница   
int[] FillArray(int num, int downBorder, int topBorder)
{   //генирируем числа
    Random numSintezaor = new Random();
    // создаем массив
    int[] arr = new int[num];
    // тест границ
    if (downBorder < topBorder)
    {   //Заполняем массив
        for (int i = 0; i < arr.Length; i++)
        {
            arr[i] = numSintezaor.Next(downBorder, topBorder + 1);
        } //возвращаем результат
    }
    return arr;
}
// печатаем одномерный массив (выводим массив)
//тип массив int[]
void PrintResult(string line)
{
    Console.WriteLine(line);
}
void Print1DArr(int[] arr)
{
    for (int i = 0; i < arr.Length - 1; i++)
    {
        Console.Write(arr[i] + ", ");
    }
    Console.WriteLine(arr[arr.Length - 1]);
}

int[] NegativPositivSums(int[] arr)
{
    int[] sums = new int[2];
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > 0)
        {
            sums[0] += arr[i];
        }
        else
        {
            sums[1] += arr[i];
        }
    }
    return sums;
}
int arrayLength = ReadData("Введите длину массива: ");
int downBorder = ReadData("Ввидите нижнюю границу массива: ");
int topBorder = ReadData("Ввидите нижнюю границу массива: ");
int[] inputArray = FillArray(arrayLength, downBorder, topBorder);
Print1DArr(inputArray);
int[] sumArray = NegativPositivSums(inputArray);
PrintResult("Сумма >0: "+sumArray[0]+" Сумма <0: "+sumArray[1]);