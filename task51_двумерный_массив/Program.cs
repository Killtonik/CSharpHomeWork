/*
Задайте двумерный массив. Найдите сумму
элементов, находящихся на главной диагонали (с индексами
(0,0); (1;1) и т.д.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Сумма элементов главной диагонали: 1+9+2 = 12
*/ 

int[, ] Get2DArray(int row, int col)
{
    int[, ] array = new int[row, col];
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < col; j++)
        {
            array[i, j] = new Random().Next(0, 10);
        }
    } 
    return array;
}

void Print2DArray(int[, ] array2)
{
    for (int i = 0; i < array2.GetLength(0); i++)
    {
        for (int j = 0; j < array2.GetLength(1); j++)
        {
            Console.Write(array2[i, j] + "\t");
        }
        Console.WriteLine();
    }
}
int SummDiag(int[, ] array1)
{
    int result = 0;
    for (int i = 0; i < array1.GetLength(0); i++)
    {
       result += array1[i, i];
    }
    return result;
}


int[, ] user2DArray = Get2DArray(3, 4);
Print2DArray(user2DArray);
int Sum = SummDiag(user2DArray);
System.Console.WriteLine();
System.Console.WriteLine(Sum);