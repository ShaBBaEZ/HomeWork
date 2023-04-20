// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 17 -> такого числа в массиве нет




using System;
using static System.Console;

Clear();
WriteLine("Введите позицию элемента: ");
int x = int.Parse(ReadLine()!);
Console.Write("Введите количество строк массива: ");
int rows = int.Parse(Console.ReadLine()!);

Console.Write("Введите количество столбцов массива: ");
int columns = int.Parse(Console.ReadLine()!);

int[,] array = GetArray(rows,columns, 0 , 100);
PrintArray(array);
number(array);



int[,] GetArray(int m, int n, int minValue, int maxValue)
{
    int[,] result = new int[m,n];
    for (int i = 0; i < m; i++)
    {
        for(int j = 0; j < n; j++)
        {
            result[i,j] = new Random().Next(minValue,maxValue + 1);
        }
    }
    return result;
}


void PrintArray(int[,] inArray)
{   
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for(int j = 0; j < inArray.GetLength(1); j++)
        {
            Write($"{inArray[i,j]} ");
        }
        WriteLine();
    }
}

void number(int[,] array)
{   
    if(x < 1 || x > rows * columns)
    {
        WriteLine("Такого элемента нет");
    }
    else
    {
        if( x % columns == 0)
        {
            int i = x / columns - 1;
            int j = columns - 1;
            WriteLine($"{x} - > {array[i,j]}");
        }
        else
        {
            int i = x / columns;
            int j = (x % columns) - 1;
            WriteLine($"Элемент под номером {x} - > {array[i,j]}");
        }
    }
}


