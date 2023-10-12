/*
20. Напишите программу, которая принимает на вход координаты двух точек и находит 
расстояние между ними в 2D пространстве.

A (3,6); B (2,1) -> 5,09
A (7,-5); B (1,-1) -> 7,21
*/ 

System.Console.Write("Задай координту точки A x: ");
int userAX = int.Parse(Console.ReadLine());
System.Console.Write("Задай координту точки A y: ");
int userAY = int.Parse(Console.ReadLine());

System.Console.Write("Задай координту точки B x: ");
int userBX = int.Parse(Console.ReadLine());
System.Console.Write("Задай координту точки B y: ");
int userBY = int.Parse(Console.ReadLine());

// int sqrX = (userBX - userAX) * (userBX - userAX);
double sqrX = Math.Pow(userBX - userAX, 2); //Math.Pow(a, 2) функция возвдит в степень (переменная, в какую степень нужно взвести)
double sqrY = Math.Pow(userBY - userAY, 2);
double sqrt = Math.Sqrt(sqrX + sqrY); //Math.Sqrt(sqrX + sqrY); выводит квадратный корень из переменной
System.Console.WriteLine(Math.Round(sqrt, 2)); // Math.Round(sqrt, 2) округляет десятичное число (переменная, сколько знаков после запятой оставить)