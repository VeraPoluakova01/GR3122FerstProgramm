// 26 Напишите программу, которая принимает на вход число и выдает
// количество цифр в числе.
//-----------------------------------------------------------------

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
//
int CalculateDigitsString(int num)
{
    string numString = num.ToString();
    return numString.Length;
}
int num = ReadData("Введите число: ");

//Второй способ
int CalculateDigits(int num)
{
    return (int)(Math.Log10(num) + 1);
}
int DigitCount(int num)
{
    int sum = 0;
    while (num > 0)
    {
        sum += 1;
        num = num / 10;

    }
    return sum; // доделать
}

int count = CalculateDigitsString(num);
PrintResult("Количество цифр " + count);
int numberOfDigits = DigitCount(num);
PrintResult("Количество цифр " + numberOfDigits);
int numberOfDigit = CalculateDigits(num);
PrintResult("Количество цифр " + numberOfDigit);

