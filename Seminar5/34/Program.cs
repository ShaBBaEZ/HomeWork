// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2


int[] startArray = GetArray(15, 100, 999);
Console.Write(String.Join(" ", startArray));
Console.Write($"-> {EvenCounter(startArray)}");


int EvenCounter(int[] startArray)
{
   int count = 0;

   for(int i = 0; i < startArray.Length; i++)
   {
    if (startArray[i] % 2 == 0)
    {
       count++;
    }
   }
   return count;
}



int[] GetArray(int size, int minValue, int maxValue)
{
    int[] res = new int[size];
    for(int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minValue,maxValue + 1);
    }
    return res;
}
