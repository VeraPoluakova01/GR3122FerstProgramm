//======================================================================
// Напишите программу, которая выводит случайное число из отрезка [10,99]
// и показывает наибольшую цифру числа
// =====================================================================

void MyVariant ()
{
Console.WriteLine("Метод 1");
System.Random numberGenerator = new System.Random();
int number = numberGenerator.Next(10, 100);
Console.WriteLine(number);
int ferstDigit = number / 10;
int secondDigit = number % 10;

if (ferstDigit > secondDigit)
{
        Console.WriteLine(ferstDigit);
 }
 else
 {
     Console.WriteLine(secondDigit);
 }
}

//Вариант Евгения
void EvgeniyVariant()
{
    Console.WriteLine("Метод 2");
    System.Random numberGenerator = new System.Random();
int number = numberGenerator.Next(10, 100);
Console.WriteLine(number);
int ferstDigit = number / 10;
int secondDigit = number % 10;
Console.WriteLine((ferstDigit>secondDigit)? ferstDigit : secondDigit);
}
// Вариант char
//void CharVariant()
{
    Console.WriteLine("Метод 3");
    System.Random numberGenerator = new System.Random();
int number = numberGenerator.Next(10, 100);
Console.WriteLine(number);
char[] charArray=number.ToString().ToCharArray();
Console.WriteLine(((int)charArray[0]>(int)charArray[1]) ? charArray[0] :charArray[1]);
}

MyVariant();
EvgeniyVariant();
