/*
40. Напишите программу, которая принимает на вход три часла и проверяет, может
ли существовать треугольник с сторонами такой длины.
*/ 
bool Triangle(int a, int b, int c)
{
    if(a + b > c & b + c > a & a + c > b)
    {
        return true;
    }
    return false;
}

System.Console.WriteLine(Triangle(4, 5, 7));