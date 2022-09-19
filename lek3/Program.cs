// Имеется одномерный массив array из n элементов, 
// требуется найти элемент массива, равный find 
//               0  1   2   3   4   5  6   7
int[] array = { 12, 48, 30, 14, 85, 6, 17, 48 };
int n = array.Length;
int find = 48; //ищем эл-т равный find, т.е.17
int index = 0;
while (index < n)
{
    if (array[index] == find)
    {
        Console.WriteLine(index);
        break; // команда ПРЕРВИ, чтоб показать только первую позицию найденого числа (на случай, если их несколько)
    }
     index++;
}