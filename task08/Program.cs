// Я не разобрался как правильно решить, я только понял что там должен быть цикл


System.Console.WriteLine("Введи  число: ");
int numN = Convert.ToInt32(Console.ReadLine());
for (int i = 2; i <= numN; i=i+2)
{
    Console.Write(i);
    System.Console.WriteLine(" ");
}



