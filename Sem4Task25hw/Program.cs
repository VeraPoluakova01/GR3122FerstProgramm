// Напишите цикл,который принимает на вход два числа (A и В) и
// возводит А в натуральную степень В.


int ReadData(string line) //доб. смс пользователю
{
    // Выводим сообщение
    Console.WriteLine(line);
    // Считываем число
    int number = int.Parse(Console.ReadLine() ?? "0");
    // Возращаем значение
    return number;
}

void PrintResult(string line)
{
    Console.WriteLine(line);
}
long Stepen(int numA, int numB)
{
    long PowA = 1;
    for (int i = 1; i <= numB; i++)
    {
        PowA = PowA * numA;
    }
    return PowA;
}

int numA = ReadData("Введите число А:");
int numB = ReadData("Введите число B:");
long PowA = Stepen(numA, numB);
PrintResult("Чило " + numA + " в степени " + numB + " равно: " + PowA);

// Через степень
double Stepen1(int numA, int numB)
{
    double StepA = Math.Pow(numA, numB);
    return StepA;
}

double PowA1 = Stepen1(numA, numB);
PrintResult("Чило " + numA + " в степени " + numB + " по методу степени равно: " + PowA1);
