// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

Console.Clear();
Console.WriteLine("Введите b1 координату: ");
double b1 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите k1 координату: ");
double k1 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите b2 координату: ");
double b2 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите k2 координату: ");
double k2 = int.Parse(Console.ReadLine()!);
Console.WriteLine($"{Intersection(k1,k2,b1,b2)}");


string Intersection(double b1, double k1, double b2, double k2)
{
    if(k1==k2)
    {
        if(b1==b2)
        {
            string message = "Прямые лежат друг на друге";
            return message;
        }
        else
        {
            string message = "Прямые параллельны";
            return message;
        }
    }
    else
    {
       double x = (b2 - b1)/(k1 - k2);
       double y = k1 * x + b1;
       string message =($"Координаты пересечения по оси X {x:f1} по оси Y {y:f1}");
       return  message;
    }
   
}