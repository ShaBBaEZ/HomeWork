﻿// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

 Console.Clear();
 Console.WriteLine("Введите число: ");
int X = int.Parse(Console.ReadLine()!);

for(int y = 1; y <= X; y ++)
{
    double square = Math.Pow(y,3);
    Console.WriteLine($"{square}");
}