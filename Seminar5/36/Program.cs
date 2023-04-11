// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19

// [-4, -6, 89, 6] -> 0

Console.WriteLine("Введите кол-во элементов массива:");
int x = int.Parse(Console.ReadLine()!);
int[] array = GetBinaryArray(x);
Console.Write(String.Join(" ", array));
Console.Write($"-> {SumOdd(array)}");

int[] GetBinaryArray(int size){
    int[] result = new int[size];
    for(int i = 0; i < size; i++)
    {
        result[i] = new Random().Next(2,100);
    }
    return result;
}

int SumOdd(int[] x)
{
    int sum = 0;
    for(int i = 1; i < x.Length; i= i + 2)
    {
        sum += x[i];
    }
    return sum;
}
