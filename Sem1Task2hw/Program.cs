//===========================================
//#  Напишите программу, которая на вход принимает два числа и выдаёт, 
// какое число большее, а какое меньшее.
//==========================================

string? inputLineA = Console.ReadLine();//вводим числа
string? inputLineB = Console.ReadLine();
if (inputLineA != null && inputLineB != null)//проверяем что оба числа не ноль
{
    if (inputLineA != inputLineB) //проверяю не равны ли числа
    {
        int inputNumberA = int.Parse(inputLineA); //переводим в целые числа
        int inputNumberB = int.Parse(inputLineB);
        if (inputNumberA > inputNumberB)//используя оператор ветвления сравниваем числа
        {
            Console.WriteLine(inputNumberA + "- это число больше");//выводим ответ на экран
            Console.WriteLine(inputNumberB + "- это число меньше");
        }
        else //если условия if не выполняется то выводим следующее
        {
            Console.WriteLine(inputNumberA + "- это меньше число");
            Console.WriteLine(inputNumberB + "- это больше число");
        }
    }
    else
    {
        Console.WriteLine("числа равны ");
    }
}

