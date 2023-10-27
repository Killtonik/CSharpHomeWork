// 41. Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// -1, -7, 567, 89, 223-> 3

int[] GetMassive(int size)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(-99, 100);
    }
    return array;
}
int Prompt(string message)
{
    System.Console.Write(message);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}


void CompareNumbers(int[] array) 
{
    int temp = 0;
    for(int i = 0; i < array.Length; i++)
    if(array[i] > 0) temp += 1;
    System.Console.Write($"В этом массиве столько чисел {temp} > 0 ");
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


int userSize = Prompt("Ведите размер массива: ");
int[] arrayMassiv = GetMassive(userSize);
PrintArray(arrayMassiv);
System.Console.WriteLine();
CompareNumbers(arrayMassiv);