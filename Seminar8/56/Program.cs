// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 5 2 6 7

// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

using System;
using static System.Console;

Clear();
Write("Введите количество строк массива: ");
int rows = int.Parse(ReadLine()!);
Write("Введите количество столбцов массива: ");
int columns = int.Parse(ReadLine()!);

int[,] array = GetArray(rows,columns, 0 , 100);
PrintArray(array);
int [] masSum = GetRowArray(array, rows);
WriteLine();
int sum = SumMin(masSum);
int x = MinRows(masSum,sum);
WriteLine($"Минимальная сумма {sum} находится в строке - > {x}");
PA(GetRowArray(array, rows));



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

int[] GetRowArray(int[,] inArray, int x)
{
    int[] result = new int[x];
    for(int o = 0; o < x; o++)
    {
        for(int i = 0; i < inArray.GetLength(0);i++)
        {
            int sum = 0;
            for(int j = 0; j < inArray.GetLength(1);j++)
            {
               sum+= array[i,j]; 
            }
            result[o] = sum;
        }
    }
    return result;
}

int SumMin (int [] array)
{
    int min = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        if(min < array[i])
        {
            min = array[i];
        }
    }
    return min;

}

int MinRows(int[] array, int x)
{
    int i = 0;
    while(array[i] != x)
    {
        i++;
    }
    return i;
}

void PA(int[] inArray)
{
    for (int i = 0; i < inArray.Length; i++)
    {
        {
            Write($"{inArray[i]} ");
        }
        WriteLine();
    }
}