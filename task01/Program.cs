/* 
1. Напишите программу, которая на вход принимает два числа и проверяет, является ли первое число кадратом второго.

a = 25; b = 5 -> да
a = 2 b = 10 -> нет
a = 9; b = -3 -> да
а = -3 b = 9 -> нет
*/ 
/* "Вариации примеров"
System.Console.WriteLine("Введи первое число: ");
int numberA = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine("Введи второе число: ");
int numberB = Convert.ToInt32(Console.ReadLine());

if(numberB * numberA == numberA)
{
    Console.WriteLine($"Число {numberB} является квадратом числа {numberA}");
}
else
{
    Console.WriteLine($"Число {numberB} не является квадратом числа {numberA}");;
}


*/
System.Console.WriteLine("Введи первое число: ");
int numberA = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine("Введи второе число: ");
int numberB = Convert.ToInt32(Console.ReadLine());

if(numberA / numberB == numberB || numberB / numberA == numberA)
{
    Console.WriteLine("да");
}
else
{
    Console.WriteLine("нет");
}