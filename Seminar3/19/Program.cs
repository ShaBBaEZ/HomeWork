// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

// 14212 -> нет

// 12821 -> да

// 23432 -> да
Console.Clear();
Console.WriteLine("Введите пятизначное число: ");
int x = int.Parse(Console.ReadLine()!);
int[] result = new int[x];
int x0 = result[0];
int x1 = result[1];
int x4 = result[3];
int x5 = result[4];
if (x < 10000 || x > 99999)
{                                                    
    Console.WriteLine("Число не пятизначное");
}
else if(x0 == x5 && x1 == x4)
{
    Console.WriteLine("Число палиндром");
}
else if (x0 != x5 || x1 != x4)
{
    Console.WriteLine("Не палиндром");
}

    

