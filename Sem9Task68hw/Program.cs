//  Задача 68: Напишите программу вычисления функции Аккермана 
// с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9 | m = 3, n = 2 -> A(m,n) = 29
//-----------------------------------------------------------------------
// Чтение данных из консоли
int ReadData(string line)
{
    Console.Write(line);
    int number = int.Parse(Console.ReadLine() ?? "0");
    return number;
}
//Печать в консоль
void PrintResult(int line)
{
    Console.WriteLine(line);
}

// функция Аккермана
int Akkerman(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    else
    if (m != 0 && n == 0)
    {
        return Akkerman(m - 1, 1);
    }
    else
    {
        return (Akkerman(m - 1, Akkerman(m, n - 1)));
    }
}
int m = ReadData("Введите число M: ");
int n = ReadData("Введите число N: ");
PrintResult(Akkerman(m, n));
