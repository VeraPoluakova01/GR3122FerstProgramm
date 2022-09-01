// Напишите программу, которая на вход принимает число (N), 
// а на выходе показывает все чётные числа от 1 до N.

string? inputLineN = Console.ReadLine(); // вводим число

if (inputLineN != null) // проверяем, что число не ноль
{
    int inputNumberN = int.Parse(inputLineN); //делаем число целым
    int NumberB = 2; // берем переменную с 2
    while (NumberB < inputNumberN) // цикл повторения с 2 до N
    {
        if (NumberB % 2 == 0) // если В четное
        {
            Console.Write(NumberB + ", "); //то выводим его на экран
            NumberB = NumberB + 2; // увеличиваем переменную на 2
        }
    }
    if (inputNumberN%2==0) //проверям на четность само число N
    {
    Console.Write(inputNumberN + " "); // если N четное,то его тоже выводим
    }
}
