// 17 Определить по координам четверь координатной плоскости
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
int QuterTest(int x, int y) //метод возвращает номер четверти
{
    if (x > 0 && y > 0)            //if (x > 0 && y > 0)
        return 1;
    if (x < 0 && y < 0)
        return 2;
    if (x < 0 && y > 0)
        return 3;
    if (x > 0 && y < 0)
        return 4;

//если не подходит ни одно значение выводим "0" т.к. int
    return -1;
}

void PrintResult(string line)

{
    Console.WriteLine(line);
}
int x = ReadData("Введите координату X:");
int y = ReadData("Введите координату Y:");
int res = QuterTest(x, y);

PrintResult("Точка находится в четверти №: " + res);