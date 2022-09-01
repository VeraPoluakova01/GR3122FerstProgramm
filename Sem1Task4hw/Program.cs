///===========================================
//#   Напишите программу, которая принимает на вход три числа 
// и выдаёт максимальное из этих чисел.
//==========================================

string? inputLineA = Console.ReadLine();//вводим числа
string? inputLineB = Console.ReadLine();
string? inputLineC = Console.ReadLine();
if (inputLineA != null && inputLineB != null && inputLineC != null)//проверяем что числа не ноль
{
    int inputNumberA = int.Parse(inputLineA); //переводим в целые числа
    int inputNumberB = int.Parse(inputLineB);
    int inputNumberC = int.Parse(inputLineC);
    if (inputNumberA > inputNumberB)//используя оператор ветвления сравниваем числа
    {
        if (inputNumberA > inputNumberC)

        {
            Console.WriteLine(inputNumberA + "- это максимальное число");
        }

        else //если условия if не выполняется то выводим следующее
        {
            Console.WriteLine(inputNumberC + "- это максимальное число");
        }
    }
    else
    {
        if (inputNumberB > inputNumberC)
        {
            Console.WriteLine(inputNumberB + "- это максимальное число");
        }
        else
        {
            Console.WriteLine(inputNumberC + "- это максимальное число");
        }
    }
}
