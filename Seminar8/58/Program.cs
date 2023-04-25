// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

using System;
using static System.Console;

Clear();
Write("Введите количество строк первой матрицы: ");
int rows1 = int.Parse(ReadLine()!);
Write("Введите количество столбцов первой матрицы: ");
int columns1 = int.Parse(ReadLine()!);
int[,] array1 = GetArray(rows1,columns1, 0 , 10);
PrintArray(array1);
WriteLine();

Write("Введите количество строк второй матрицы: ");
int rows2 = int.Parse(ReadLine()!);
Write("Введите количество столбцов второй матрицы: ");
int columns2 = int.Parse(ReadLine()!);
int[,] array2 = GetArray(rows2,columns2, 0 , 10);
PrintArray(array2);
WriteLine();
if(rows1 != columns2)
{
    WriteLine($"Ваши матрицы нельзя перемножить");
    return;
}

int[,] array3 = GetArrayWork(columns1,rows2);
WriteLine($"Произведение матриц:");
PrintArray(array3);




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

int [,] GetArrayWork(int m, int n)
{
    int[,] result = new int[m,n];
    for(int i = 0; i < m ;i++)
    {
        for(int j = 0; j < n; j++)
        {
            result[i,j] = calculation(array1,array2,i,j);
        }
    }
    return result;
}

int calculation (int [,]array1, int [,]array2,int m, int n)
{   int sum = 0;
        for(int j = 0; j < array1.GetLength(1);j++)
        {
            sum+= array1[m,j] * array2[j,n];
        }
    return sum;
}
