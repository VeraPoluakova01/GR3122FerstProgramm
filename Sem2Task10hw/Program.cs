// Напишите программу, которая принимает на вход трёхзначное число 
// и на выходе показывает вторую цифру этого числа.

// Считываем число
Console.Write("Введите число: ");
string? inputLineA = Console.ReadLine();
// Если число трехзначно
if (inputLineA.Length == 3)
{
    //Превращае введенное число в массив
    char[] charArray = inputLineA.ToString().ToCharArray();
    //выводим элемент массива
    Console.WriteLine(charArray[1]);
}
//если число оказалось не трехзначным, то выводи
else
{
    Console.Write("Число не трехзначное ");
}