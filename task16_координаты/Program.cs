/*
16. Напишите программу, которая принимает на вход два числа и проваряет,
является ли одно число квадратом другого.
5, 25 -> да
-4, 16 -> да 
25, 5 -> да 
8, 9 -> нет
*/ 

System.Console.WriteLine("Введи первое число: ");
int number1 = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введи второе число: ");
int number2 = Convert.ToInt32(Console.ReadLine());

if(number1 == number2 * number2 || number2 == number1 * number1)
{
    Console.WriteLine("Одно из чисел кавадрат другого");
}
else
{
    Console.WriteLine("не квадрат");
}