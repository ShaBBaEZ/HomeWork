// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)

// 2, 4 -> 16

Console.Clear();
Console.WriteLine("Введите первое число: ");
int a = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите второе число: ");
int b = int.Parse(Console.ReadLine()!);

Console.WriteLine($"Число {a} в степени {b} = {Degree(a)}");


int Degree(int a){
    int result = 1;
    for(int i = 0; i < b; i ++)
    {
        result *= a;
    }
    return result;
}

