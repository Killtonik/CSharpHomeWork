/*
12. Напишите программу, которая будте принимать на вход два числа и выводить, является ли второе число 
кратным первому.
Если второе число некратное первому, То программа выводит остаток от деления
34, 5 -> некратное, остатко 4
16, 4 -> кратное
*/ 


System.Console.WriteLine("Введи первое число: ");
int number1 = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine("Введи второе число: ");
int number2 = Convert.ToInt32(Console.ReadLine());

if(number1 == number2 * number2)
{
    Console.WriteLine("Без остатка");
}
else
{
    int result = number1 % number2;
    Console.WriteLine($"Остаток будет {result}");
}