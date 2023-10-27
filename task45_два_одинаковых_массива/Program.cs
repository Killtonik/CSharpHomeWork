// 45. Напишите программу, которая будет создавать копию заданного одномерного массива с помощью поэлементного копирования. 

int[] GetMassive(int size)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(0, 10);
    }
    return array;
}

void CreateNewArray(int[] arr)
{
    int[] arrayNew = new int[arr.Length];
    for (int i = 0; i < arr.Length; i++)
    {
        arrayNew[i] = arr[i];
    }
    
}

void PrintArray(int[] arr)
{
    Console.ForegroundColor = ConsoleColor.Green;
    System.Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        Console.ForegroundColor = ConsoleColor.Cyan;
        Thread.Sleep(1);
        System.Console.Write(arr[i]);
        if (i < arr.Length - 1)
            System.Console.Write(", ");
    }
    Console.ForegroundColor = ConsoleColor.Green;
    System.Console.Write("]");
    Console.ResetColor();
    
}



int[] arrayUser = GetMassive(10);
PrintArray(arrayUser);
int[] arrayCopy = CreateNewArray();
PrintArray(arrayCopy);