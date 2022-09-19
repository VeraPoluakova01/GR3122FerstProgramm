// Чтение данных из консоли
int ReadData(string line)
{
    // Выводим сообщение
    Console.WriteLine(line);
    // Считываем число
    int number = int.Parse(Console.ReadLine() ?? "0");
    // Возвращаем значение
    return number;
}

// Проверяем на полидром число любой длины
bool TestPalidromLength(int number)
{
    int result = (int)Math.Log10(number) + 1;
    while (result > 1)
    {
        if ((int)(number / (Math.Pow(10, result - 1))) == number % 10)
        {
            number = (int)(number % (Math.Pow(10, result - 1)));
            number = number / 10;
        }
        else
        {
            return false;
        }
        result -= 2;
    }
    return true;
}

// Печать результата
void PrintResult(string line)
{
    Console.WriteLine(line);
}

int number = ReadData("Введите палиндром: ");

PrintResult(TestPalidromLength(number) ? "3) Да" : "3) Нет");