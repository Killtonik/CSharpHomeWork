// 7. Напишите программу, которая принимает на вход трехзначное число и на выходе покахывает последнюю цифру этого числа.
// 456 -> 6
// 782 -> 2
// 918 -> 8
/*С проверкой на трехзначно число
System.Console.WriteLine("Введи трехзначное число: ");

int number = int.Parse(илиConvert.ToInt32)(Console.ReadLine());

if (number > 999 || numbrer < 100)
    System.Console.WriteLine("Неверное число");
    
System.Console.Write("Последня цифра");
System.Console.WriteLine(number % 10);
*/

System.Console.Write("Введи трех значное число: ");
int num = Convert.ToInt32(Console.ReadLine());

int result = num %10;
    
Console.WriteLine($"Последняя цифра числа {num}: {result}");