// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// 452 -> 11

// 82 -> 10

// 9012 -> 12


Console.Clear();
Console.WriteLine($"Введите число: ");
int x = int.Parse(Console.ReadLine()!);
Console.WriteLine($"Сумма цифр числа {x} = {GetSum(x)}");

int GetSum(int x){
    int sum = 0;
    while(x > 0){
        int y = x % 10;
        sum = sum + y;
        x = x / 10;
    }
    return sum;
}