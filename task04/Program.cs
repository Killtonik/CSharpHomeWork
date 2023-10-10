//Втарая задача, я думал что нужно ее решить таким образом, но в автотесте было другое решени
//но мое тоже работает
System.Console.Write("Введи первое число: ");
int a = Convert.ToInt32(Console.ReadLine());

System.Console.Write("Введи второе число: ");
int b = Convert.ToInt32(Console.ReadLine());

System.Console.Write("Введи третье число: ");
int c = Convert.ToInt32(Console.ReadLine());


if (a > b && a > c)
{
    Console.WriteLine($"{a} больше");
}
if (c > b && c > a)
{
    Console.WriteLine($"{c} больше");
}
if (b > c && b > a)
{
    Console.WriteLine($"{b} больше");
}