/* 
18. Напишите программу, которая по заданному номеру четверти, показывает диапазон 
возможных координат точек в этой четверти (x и y).
*/ 

System.Console.Write("Задай номер четверти от 1 до 4: ");
int number = int.Parse(Console.ReadLine());

if (number == 1)
{
    int umbrX = new Random().Next(0, 100);
    int umbrY = new Random().Next(0, 100);
    System.Console.Write($"Точка координат Y{umbrY} X{umbrX}");
}
if (number == 2)
{
    int umbrX = new Random().Next(-0, -100);
    int umbrY = new Random().Next(0, 100);
    System.Console.Write($"Точка координат Y{umbrY} X{umbrX}");
}
if (number == 3)
{
    int umbrX = new Random().Next(-0, -100);
    int umbrY = new Random().Next(-0, -100);
    System.Console.Write($"Точка координат Y{umbrY} X{umbrX}");
}
if (number == 4)
{
    int umbrX = new Random().Next(0, 100);
    int umbrY = new Random().Next(-0, -100);
    System.Console.Write($"Точка координат Y{umbrY} X{umbrX}");
}
if (number == 0 && number > 4)
{
    System.Console.WriteLine("Вы ввели неверно число");
}