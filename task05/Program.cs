/*
5. Напишите программу, которая на вход принимает одно число (N),
а на выходе прказывает все целые числа в промежутке -N до N.

4 -> "-4, -3, -1, 0, 1, 2, 3, 4"
2 -> "-2, 1, 0, 1, 2"
*/
/*Через Wilte
System.Console.WriteLine("Введи первое число: ");
int numN = Convert.ToInt32(Console.ReadLine());
itn N = -numN;
while(N < numN + 1)
{
    System.Console.Write(N + " " );
    N = N + 1
}
*/
System.Console.WriteLine("Введи первое число: ");
int numN = Convert.ToInt32(Console.ReadLine());
for (int i = - numN; i <= numN; i++)
{
    Console.Write(i);
    if(i<numN);
    System.Console.Write(", ");
}