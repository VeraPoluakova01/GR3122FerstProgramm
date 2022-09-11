// 19 Напишите программу, которая принимает на вход пятизначное число 
// и проверяет, является ли оно палиндромом.

int ReadData(string line) //доб. смс пользователю
{
    // Выводим сообщение
    Console.WriteLine(line);
    // Считываем число
    int P = int.Parse(Console.ReadLine() ?? "0");
    // Возращаем значение
    return P;
}
bool TestPolindrom(int P) // проверяем на полиндром
{
    if (P > 9999 && P < 100000)
    {

        if ((P / 10000 == P % 10) && ((P / 1000) % 10) == (P / 10) % 10)
            return true;
        else
            return false;
    }

    else
    {
        Console.WriteLine("Число не пятизначное");
        return false;
    }
}
void PrintResult(bool line) //выводим ответ
{
    Console.WriteLine(line);
}

int num = ReadData("Введите пятизначное число ");
PrintResult(TestPolindrom(num));