﻿/*38. Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива. 
[3 7 22 2 78] -> 76
[2 0,4 9 7,2 78] -> 77,6
*/
Console.Clear();

double[] GetDoubleRnd(int size)
{
    double[] array = new double[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(0, 10) + new Random().NextDouble();
    }
    return array;
}

void PrintDoubleArray(double[] arr)
{
    
    for (int i = 0; i < arr.Length; i++)
    {
        
        System.Console.Write(Math.Round(arr[i], 2));
        if (i < arr.Length - 1)
            System.Console.Write(", ");
    }
    
}

void MinMax(double[] arr)
{
    double min = arr[0];
    double max = arr[0];
    for (int i = 0; i < arr.Length; i++)
    {
        if(arr[i] > max) max = arr[i];
        if(arr[i] < min) min = arr[i];
    }
    System.Console.WriteLine($"Разница между {Math.Round(max, 2)} и {Math.Round(min, 2)} равняется {Math.Round(max - min, 2)}");
}


double[] arrayDouble = GetDoubleRnd(5);
PrintDoubleArray(arrayDouble);
System.Console.WriteLine();
MinMax(arrayDouble);