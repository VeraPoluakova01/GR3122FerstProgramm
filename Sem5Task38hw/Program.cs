// 38 Задайте массив вещественных чисел, найде разницу м\у максимальным 
// и минимальным элементами массива.
//----------------------------------------------------------------------

// Универсальный метод генерации и заполнение массива
double[] FillArray(int length, double topBorder, double downBorder)
{
    Random rand = new Random();
    double[] array = new double[length];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rand.NextDouble();
    }
    return array;
}
// вывод массив
void Print1DArray(double[] array)
{
    Console.WriteLine("[{0}]", string.Join(", ", array));
}
// находим max,min и их разницу
double MaxMin(double[] arr)
{
    double max = int.MinValue;
    double min = int.MaxValue;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > max)
        {
            max = arr[i];
        }
        if (arr[i] < min)
        {
            min = arr[i];
        }
    }
    return (max - min);

}
double[] array = FillArray(10, 0, 100);
Print1DArray(array);
MaxMin(array);
void PrintAnswer(double answer)
{
    Console.WriteLine("Разница между максимальным и минимальным элементом равна: " + answer);
}
PrintAnswer(MaxMin(array));