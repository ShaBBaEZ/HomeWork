// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

// [3 7 22 2 78] -> 76
Console.WriteLine("Введите кол-во элементов массива:");
int x = int.Parse(Console.ReadLine()!);
int[] array = GetBinaryArray(x);


int[] GetBinaryArray(int size){
    int[] result = new int[size];
    for(int i = 0; i < size; i++)
    {
        result[i] = new Random().Next(1,100);
    }
    return result;
}
