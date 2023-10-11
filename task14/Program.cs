/*
14. Напишите программу, которая принимает на вход число и проверяет, кратное ли оно одновременно 7 и 23
14 -> нет
46 -> нет
161 -> да 
*/ 

System.Console.WriteLine("Задать число: ");
int number = Convert.ToInt32(Console.ReadLine());
if(number % 7 == 0 && number % 23 == 0)
{
    System.Console.WriteLine("Число кратное");
}
else
{
    System.Console.WriteLine("Не кратное");
}