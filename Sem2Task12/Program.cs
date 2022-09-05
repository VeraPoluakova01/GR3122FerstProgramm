
//-----------------------------------------------------------------------------------------------------------                                    Задача 12
//Напишите программу, которая будет принимать на вход два числа 
// и выводить,является ли второе число кратным первому.
// Если второе число некратно первому, 
// то программа выводит остаток от деления.
//------------------------------------------------------------------------------------------------------

// вариант Константина
// Void Variant1()
// {
//     Console.Write("Введите первое число: ");
//     string? inputLineA = Console.ReadLine();
//     Console.Write("Введите второе число: ");
//     string? inputLineB = Console.ReadLine();

//     int inputNumberA = int.Parse(inputLineA);
//     int inputNumberB = int.Parse(inputLineB);

//     Console.WriteLine((inputNumberB % inputNumberA == 0) ? ("Второе число кратно первому") : ("Остаток от деления: " + inputNumberB % inputNumberA));
// }

// Void Variant2()
// // Вариант Евгений
// {
// string? inputLineA = Console.ReadLine();
// string? inputLineB = Console.ReadLine();

// if (inputLineA != null && inputLineB != null)
// {
//     int inputNumberA = (int)int.Parse(inputLineA);
//     int inputNumberB = (int)int.Parse(inputLineB);

//     Console.WriteLine(inputNumberB%inputNumberA==0?"Является кратным":inputNumberB%inputNumberA);
// }
// }
// Variant2();
//Variant1();

int inputNumberA=0;
int inputNumberB=0;
bool result = false;
// Получаем два числа от пользователя
void ReadData() 
{
    Console.Write("Введите первое число: ");
    string? inputLineA = Console.ReadLine();
    Console.Write("Введите второе число: ");
    string? inputLineB = Console.ReadLine();

    inputNumberA = int.Parse(inputLineA);
    inputNumberB = int.Parse(inputLineB);
}
// определяем кратность чисел
void ConculateData()
{
   result = (inputNumberB % inputNumberA == 0);
}
//Выводим результаты вычесления
void PrintData()
{
   if(result)
   {
    Console.WriteLine("Второе число кратно первому");
   }
   else
   {
    Console.WriteLine("Остаток от деления: " + inputNumberB % inputNumberA);
   }
}
ReadData();
ConculateData();
PrintData();






