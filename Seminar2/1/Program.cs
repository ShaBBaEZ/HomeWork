﻿// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

//456 -> 5
//782 -> 8
//918 -> 1

Console.Clear();
int num = new Random().Next(100, 1000);
Console.WriteLine(num);
int a1 = num / 10;
int a2 = a1 % 10;
Console.WriteLine($"{a2}");

