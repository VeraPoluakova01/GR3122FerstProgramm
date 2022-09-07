// 18 Определить по номеру четверти облсть значения координат
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
string QuterBorderAsk(int numQuter)
{
    if (numQuter == 1)
        return "x>0 y>0";
    if (numQuter == 2)
        return "x<0 y>0";
    if (numQuter == 3)
        return "x<0 y<0";
    if (numQuter == 4)
        return "x>0 y<0";
//если не подходит ни одно значение выводим пустую строку т.к. string
    return ""; 
}

void PrintResult(string line)

{
    Console.WriteLine(line);
}
int num = ReadData("Введите номер четверти: ");

string res = QuterBorderAsk(num);

PrintResult(res);