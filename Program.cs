//  Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
//  M = 1; N = 15 -> 120
//  M = 4; N = 8. -> 30

Console.Write("Число M = ");
int numberM = int.Parse(Console.ReadLine());

Console.Write("Число N = ");
int numberN = int.Parse(Console.ReadLine());

SumFromMToN(numberM, numberN);

void SumFromMToN(int numberM, int numberN)
{
    Console.Write(SumMN(numberM, numberN ));
}

int SumMN(int numberM, int numberN)
{
    int sum = numberM;
    if (numberN - numberM <= 1) return 0;
    else
    {
        numberM++;
        sum = numberM + SumMN(numberM, numberN);
        return sum;
    }
}