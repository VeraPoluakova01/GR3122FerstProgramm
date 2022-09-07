// Напишите программу, которая принимает на вход два числа и
// проверяет являются ли одно число квадратом другова числа.

// чтение данных из консоли
int ReadData(string line) //доб. смс пользователю
{
    // Выводим сообщение
    Console.WriteLine(line);
    // Считываем число
    int number = int.Parse(Console.ReadLine() ?? "0");
    // Возращаем значение
    return number;
}
// Тест на квадрат (проверка-является ли квадратом)
bool SqerTest(int firstNum, int secondNum)
{
    if (firstNum == secondNum * secondNum)
    {
        return true;
    }
    else
    {
        return false;
    }
}
// Вывод данных
void PrintData(int firstNum, int secondNum)
{
    if (SqerTest(firstNum, secondNum))
    {
        Console.WriteLine("Число " + firstNum + " квадрат числа " + secondNum);
    }
    else
    {
        Console.WriteLine("Число " + firstNum + " не квадрат числа " + secondNum);
    }
}
int num1 = ReadData("Введите число 1 ");
int num2 = ReadData("Введите число 2 ");

PrintData(num1,num2);
PrintData(num2,num1);
