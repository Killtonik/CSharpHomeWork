/*
Задача 49: Задайте двумерный массив. Найдите элементы, у
которых оба индекса чётные, и замените эти элементы на их
квадраты.
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
int[, ] Sqare2Deven(int[, ] array1)
{
    for (int i = 0; i < array1.GetLength(0); i++)
    {
        for (int j = 0; j < array1.GetLength(1); j++)
        {
            if(j % 2 == 0 & i % 2 == 0) array1[i, j] *= array1[i, j];
        }
    }
    return array1;
}


int[, ] user2DArray = Get2DArray(3, 4);
Print2DArray(user2DArray);
System.Console.WriteLine();
int[, ] userSqare = Sqare2Deven(user2DArray);
Print2DArray(userSqare);