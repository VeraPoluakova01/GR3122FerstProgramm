// # 13 Напишите программу, которая выводит третью цифру заданного числа 
// или сообщает, что третьей цифры нет.

// Считываем число
Console.Write("Введите число: ");
string? inputLineA = Console.ReadLine();
// Если число больше двухзначного,то 
if (inputLineA.Length >= 3)
{
    //Превращае введенное число в массив
    char[] charArray = inputLineA.ToString().ToCharArray();
    //выводим элемент массива
    Console.WriteLine(charArray[2]);
}
//если число разряд введеного чила <3, то
else
{
    Console.WriteLine("Третей цифры нет ");
}