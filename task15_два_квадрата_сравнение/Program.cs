/*
15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, 
является ли этот день выходным.
6 -> да
7 -> да
1 -> нет
*/


System.Console.WriteLine("Введи число от 1 до 7: ");
int weekDay = Convert.ToInt32(Console.ReadLine());

int day1 = 1;
int day2 = 2;
int day3 = 3;
int day4 = 4;
int day5 = 5;
int day6 = 6;
int day7 = 7; 

if(weekDay == day1)Console.WriteLine("Нет");
else if(weekDay == day2)Console.WriteLine("Нет");
else if(weekDay == day3)Console.WriteLine("Нет");
else if(weekDay == day4)Console.WriteLine("Нет");
else if(weekDay == day5)Console.WriteLine("Нет");
else if(weekDay == day6)Console.WriteLine("Да");
else if(weekDay == day7)Console.WriteLine("Да");
else Console.WriteLine("Введино неверное число");