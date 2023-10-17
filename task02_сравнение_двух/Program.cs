//Значит, Я решал сначала в autotest, я вооще не понял как там писать код и решил проверить и написать тут,
//убедился что все работет, пошел искать вариант как там пройти оказывается что, нужно же еще учесь равность
//этих чисел поэтому я решил на половину только=(
/*System.Console.Write("Введи первое число: ");
int firstNumber = Convert.ToInt32(Console.ReadLine());

System.Console.Write("Введи второе число: ");
int secondNumber = Convert.ToInt32(Console.ReadLine());
if(firstNumber > secondNumber)
{
    Console.WriteLine($"Число {firstNumber} больше числа {secondNumber}");
}
else
{
    Console.WriteLine($"Число {secondNumber} больше числа {firstNumber}");
}
*/
      

System.Console.Write("Введи первое число: ");
int firstNumber = Convert.ToInt32(Console.ReadLine());

System.Console.Write("Введи второе число: ");
int secondNumber = Convert.ToInt32(Console.ReadLine());
if(firstNumber == secondNumber)
{
    Console.WriteLine($"Число {firstNumber} равны числа {secondNumber}");
}
if(firstNumber > secondNumber)
{
    Console.WriteLine($"Число {firstNumber} больше числа {secondNumber}");
}
if(firstNumber < secondNumber)
{
    Console.WriteLine($"Число {secondNumber} больше числа {firstNumber}");
}