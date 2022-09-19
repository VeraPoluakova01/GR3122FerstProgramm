// 43 Напишите программу, которая найдёт точку пересечения двух прямых,
//  заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
//  значения b1, k1, b2 и k2 задаются пользователем.
//----------------------------------------------------------------------
// Получение данных от пользователя и преобразование в число
double ReadData(string text)
{
    Console.Write(text);
    double number = double.Parse(Console.ReadLine() ?? "0");
    return number;
}
// вывод массив
void Print1DArray(double[] array)
{
    Console.WriteLine("[{0}]", string.Join(", ", array));
}
// находим точку пересения по формуле и выводим X,Y массивом.
double[] PointFinde(double k1, double k2, double b1, double b2)
{
    double[] outAr = new double[2];
    double X = (b2 - b1) / (k1 - k2);
    double Y = k1 * (b2 - b1) / (k1 - k2) + b1;
    outAr[0] = X;
    outAr[1] = Y;
    return outAr;
}
//Делаем проверку :пересекаются ли вообще прямые
void CheckData(double k1, double k2, double b1, double b2)
{
    if (k1 == k2)
    {
        if (b1 != b2)
        {
            Console.WriteLine("Прямые параллельны");
        }
        else
        {
            Console.WriteLine("Прямые совпадают");
        }
    }
}
    double k1 = ReadData("введите k1 ");
    double k2 = ReadData("введите k2 ");
    double b1 = ReadData("введите b1 ");
    double b2 = ReadData("введите b2 ");
    CheckData(k1, k2, b1, b2);
    double[] array = PointFinde(k1, k2, b1, b2);
    Print1DArray(array);