// Напишите программу, которая принимает на вход число (N) 
// и выдаёт таблицу кубов чисел от 1 до N.

int ReadData(string line) //доб. смс пользователю
{
    // Выводим сообщение
    Console.WriteLine(line);
    // Считываем число
    int number = int.Parse(Console.ReadLine() ?? "0");
    // Возращаем значение
    return number;
}

string LineNumbers(int numberN)
{
    int i = 1;
    string outLine = string.Empty;
    while (i < numberN)
    {
        outLine = outLine + i + "\t";
        ++i;
    }
    outLine = outLine + numberN;
    return outLine;
}
string LineSqer(int numberN)
{
    int i = 1;
    string outLine = string.Empty;
    while (i < numberN)
    {
        outLine = outLine + i*i*i + "\t";
        ++i;
    }
    outLine = outLine + numberN*numberN*numberN;
    return outLine;
}

void PrintResult(string line)
{
    Console.WriteLine(line);
}

int num= ReadData("Введите число N");
string lineTop=LineNumbers(num);
string lineDown=LineSqer(num);

PrintResult(lineTop);
PrintResult(lineDown);
