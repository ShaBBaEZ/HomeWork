// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

//6 -> да
//7 -> да
//1 -> нет

Console.Clear();
Console.Write("Введите день недели, ");
int x = int.Parse(Console.ReadLine()!);
if (x < 1 || x > 7)
{
    Console.WriteLine("Такого дня недели нет");
}
else
{
    if (x > 0 && x < 6)
    {
        Console.WriteLine("Не выходной");
    }
    else
    {
        Console.WriteLine("Выходной");
    }

}