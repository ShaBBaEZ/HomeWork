// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

using System;
using static System.Console;

Clear();
Write("Введите количество строк массива: ");
int rows = int.Parse(ReadLine()!);

Write("Введите количество столбцов массива: ");
int columns = int.Parse(ReadLine()!);

int[,] array = GetArray(rows,columns);
PrintArray(array);
WriteLine();



int[,] GetArray(int m, int n)
{
    int[,] result = new int[m,n];
    int x = 0;
    int i = 0;
    int j = 0;
    while (x < result.GetLength(0) * result.GetLength(1))
    {   
        result[i, j] = x + 1;
        x++;
        if (i <= j + 1 && i + j < result.GetLength(1) - 1)
        j++;
        else if (i < j && i + j >= result.GetLength(0) - 1)
        i++;
        else if (i >= j && i + j > result.GetLength(1) - 1)
        j--;
        else
        i--;
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
