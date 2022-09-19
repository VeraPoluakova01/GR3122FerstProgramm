// Создадим массив из 10 эл-ов случ. обр. и выведем на экран
// найти позицию заданного числа (если такое есть в массиве)

//   наз. массив.    наз. аргумента
void FillArray(int[] collection)
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        //заполняем случайными числами от1 до 10
        collection[index] = new Random().Next(1, 10);
        index++;
    }
}                 //просто др. название для массива
void PrintArray(int[] col)
{
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
        Console.WriteLine(col[position]);
        position++;
    }
}
//           создай массив из 10 эл-ов          
int[] array = new int[10];
int IndexOf(int[] collection, int find)
{
    int count = collection.Length;
    int index = 0;
    int position = -1;
    while(index<count)
    {
        if(collection[index]==find)
        {
            position=index;
            break;
        }
        index++;
    }
    return position;
}
FillArray(array);
PrintArray(array);
Console.WriteLine();// пустая строка, чтоб отделить массив от ответа
int pos=IndexOf(array,4);
Console.WriteLine(pos);