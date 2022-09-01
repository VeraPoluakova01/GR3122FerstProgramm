//===========================================
//# 7 Напишите программу, которая на вход принимает трехзначное число, 
//а на выходе показывает последнюю цифру. 
//==========================================

string? inputLine = Console.ReadLine();

if (inputLine != null)
{
    int inputNumber = int.Parse(inputLine);
    if (inputNumber > 99 && inputNumber < 1000)
    {
        int lastDigit = inputNumber % 10;
        Console.Write(lastDigit + " ");
    }
}