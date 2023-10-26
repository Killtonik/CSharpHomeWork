﻿/*
33. Задайте массив. Напишите программу, которая определяет, присутствует ли 
заданное число в массиве.
4; массив [6, 7, 19, 345, 3] -> нет
-3; массив [6, 7, 19, 345, 3] -> да
*/ 



int[] GetRnd(int size)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(-9, 10);
    }
    return array;
}

void PrintArray(int[] arr)
{
    Console.ForegroundColor = ConsoleColor.Green;
    System.Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        Console.ForegroundColor = ConsoleColor.Cyan;
        Thread.Sleep(100);
        System.Console.Write(arr[i]);
        if (i < arr.Length - 1)
        System.Console.Write(", ");
    }
        Console.ForegroundColor = ConsoleColor.Green;
        System.Console.Write("]");
        Console.ResetColor();
}

bool Numb(int[] arr, int srav)
{
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] == srav) return true;
        if (arr[i] * -1 == srav) return true;
    }
    return false;
}