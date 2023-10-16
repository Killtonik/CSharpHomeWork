﻿/*
24. Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.
7 -> 28
4 -> 10
8 -> 36
*/ 
System.Console.WriteLine("Задай число: ");
int value = Convert.ToInt32(Console.ReadLine());

int sum = SumOfNumberDigits(value);

System.Console.WriteLine(sum);


int SumOfNumberDigits(int num)
{
    int result = 0;
    for(int i = 1; i <= num;i++)
     {
        result = result + i;
     }
        
    return result;
}