// 41  Пользователь вводит с клавиатуры M чисел.
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
//------------------------------------------------------------

// Получение данных от пользователя и преобразование в число
int ReadData(string text)
{
    Console.Write(text);
    int number = int.Parse(Console.ReadLine() ?? "0");
    return number;
}

// Вывод результата в консоль
void PrintResult(string data)
{
    Console.WriteLine(data);
}
// Метод подсчета введеных положительных чисел
int Count(int M)
{
    int res = 0;
    for (int i = 0; i < M; i++)
    {
        int num = ReadData("Введите число ");
        if (num > 0) res++;
    }
    return res;
}
int N = ReadData("Введите колличество чисел ");
int result = Count(N);
// Или можем здесь задать сами колличесво чисел вводимых всего
// int result = Count(5);
PrintResult("Чисел больше нуля: " + result);


