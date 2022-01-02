//1. Написать метод, возвращающий минимальное из трёх чисел.

Console.Write("Введи число а: ");
int a = int.Parse (Console.ReadLine());
Console.Write("Введи число b: ");
int b = int.Parse (Console.ReadLine());
Console.Write("Введи число c: ");
int c = int.Parse (Console.ReadLine());
int min = 0;

if (a>b & a>c)
{
    min = a;
   
}
else if (b > c)
{
    min = b;
}
else
{
    min = c;
}
Console.Write ($"Минимальное число: {min}");
