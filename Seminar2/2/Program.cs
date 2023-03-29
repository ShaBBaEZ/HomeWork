// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

//645 -> 5

//78 -> третьей цифры нет

//32679 -> 6

Console.Clear();
int num = new Random().Next();
Console.WriteLine($"{num}");
if (num < 100)
{
    Console.WriteLine("Третьей цифры нет");
}
else
{
 while (num > 1000)
 {
    num = num / 10;
 }
 int x = num % 10;
 Console.WriteLine($"Третья цифра числа {x}");
}      