// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30


using System;
using static System.Console;

Clear();
Write("Введите значение M: ");
int M = int.Parse(ReadLine()!);
Write("Введите значение N: ");
int N = int.Parse(ReadLine()!);
Write(SUM(M,N));

int SUM(int i, int j)
{
    int sum = 0;
    while (i <= j)
    {
        sum+= i;
        i++;
        SUM(i,j);
    }
    return sum;
}

