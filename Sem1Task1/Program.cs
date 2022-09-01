//===========================================
//#  Напишите программу, которая на вход принимает два числа
// и проверяет, яляется ли второе число квадратом первого
//==========================================


string? inputLineA = Console.ReadLine();
string? inputLineB = Console.ReadLine();
if (inputLineA != null && inputLineB != null)
{
    int inputNumberA = int.Parse(inputLineA);
    int inputNumberB = int.Parse(inputLineB);

    bool outResult = (inputNumberA * inputNumberA == inputNumberB);

    Console.WriteLine(outResult);
}