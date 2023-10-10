//3 Задание было попроще но я не понял почему мы выносим за двойные скобки сравнение "if((number % 2)==0)"
//у меня получилось вот так, даже с подсказаками я не догадался про это =(



System.Console.Write("Введи число: ");
int number = Convert.ToInt32(Console.ReadLine());

if((number % 2) == 0 )
{
Console.WriteLine($"Чётное {number}");
}
else
{
    Console.WriteLine($"нечетное {number}");
}