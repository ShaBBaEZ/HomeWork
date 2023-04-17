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
int rows = new Random().Next(5,10);
int columns = new Random().Next(5,10);
WriteLine($"Строк {rows - 1} столбцов {columns - 1}");

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
    for (int i = 0; i < inArray.GetLength(0) - 1; i++)
    {
        for(int j = 0; j < inArray.GetLength(1) - 1; j++)
        {
            Write($"{inArray[i,j]} ");
        }
        WriteLine();
    }
}

void number(int [,] array)
{   
    if(x < 1 || x > (array.GetLength(1) - 1) * (array.GetLength(0) - 1))
    {
        WriteLine($"Число выходит за пределы массива и его нет");
    }
    else
    {
        int i = x / (array.GetLength(0) - 1);
        int j = x % array.GetLength(0) - 1;
        WriteLine($"{i} {j}");
        WriteLine($"Под номером {x} - > {array[i,j]}"); 
    }
}
