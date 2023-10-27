/*
42. Напишите программу, которая будет преобразовывать десятичные числа в двоичное.
45 -> 101101
3 -> 11
2 -> 10
*/ 
void DecToBinary(int numb)
{
    string result = "";
    int temp = 0;
    for(int i = numb; i > 0; i/=2)
    {
        temp = i % 2;
        result = temp + result;
    }
    System.Console.WriteLine(result);
}

DecToBinary(12);