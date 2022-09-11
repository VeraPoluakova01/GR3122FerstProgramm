// Напишите программу, которая принимает на вход число 
// и выдаёт сумму цифр в числе.

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
int SumDigit(int num)
{
    int sum = 0;
    while (num > 0)
    {
        sum += num % 10;
        num = num / 10;
    }
    return sum;
}
int num1 = ReadData("Введите число: ");
int sum1 = SumDigit(num1);
PrintResult("Чмсло " + sum1);