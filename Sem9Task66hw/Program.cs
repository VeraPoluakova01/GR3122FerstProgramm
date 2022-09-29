//  66: Задайте значения M и N. Напишите программу,
// которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 4; N = 8. -> 30
//-----------------
// Чтение данных из консоли
int ReadData(string line)
{
    Console.Write(line);
    int number = int.Parse(Console.ReadLine() ?? "0");
    return number;
}
int RecSumMN(int M, int N)
{
    if (M >= N) return N;
    
        int sum = M + RecSumMN(M + 1, N);
    
    return sum;
}

bool TestNum(int m, int n)
{
    bool num = false;
    if (m < n) num = true;
    else num = false;
    return num;
}

int m = ReadData("Введите числа M: ");
int n = ReadData("Введите числа N: ");

// Вывод данных
void PrintData(int m, int n)
{
    if (TestNum(m, n))
    {
        Console.WriteLine(RecSumMN(m, n));
    }
    else
    {
         Console.WriteLine(RecSumMN(n, m));
    }
}
PrintData(m,n);
