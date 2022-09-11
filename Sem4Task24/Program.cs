// Напишите программу, которая на вход принимает число А
// и суммирует все числа от 1 до А


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
int VariantSumSimple(int numA)
{
    int sumOfNumbers = 0;
    for (int i = 1;i<=numA; i++)
    {
        sumOfNumbers += i;
    }
    return sumOfNumbers;
}
int numberA=ReadData("Введите число А:");
int res1 = VariantSumSimple(numberA);
PrintResult("Сумма чисел от 1 до А равна: "+ res1);


int VariantSumGause(int numA)
{
    int sumOfNumbers=0;
    sumOfNumbers=((1+numA)*numA)/2;
    return sumOfNumbers;
}

int res2 = VariantSumSimple(numberA);
PrintResult("Сумма чисел от 1 до А равна по Гаусу: "+ res2);