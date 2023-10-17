/* Напиши программ, которая будет выдавать название для недели по заданному номеру.

3 -> Среда
5 -> Пятница
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

if(weekDay == day1)Console.WriteLine("Понедельник");
else if(weekDay == day2)Console.WriteLine("Вторник");
else if(weekDay == day3)Console.WriteLine("Среда");
else if(weekDay == day4)Console.WriteLine("Четверг");
else if(weekDay == day5)Console.WriteLine("Пятница");
else if(weekDay == day6)Console.WriteLine("Суббота");
else if(weekDay == day7)Console.WriteLine("Воскресенье");
else Console.WriteLine("Введино неверное число");