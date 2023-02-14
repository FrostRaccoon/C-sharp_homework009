/* Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
*/

int m = 1;
int n = new Random().Next(5, 20);
Console.WriteLine($"От {m} до {n}: ");
Console.WriteLine();
Console.Write(SumOfNaturalNums(m - 1, n));

int SumOfNaturalNums(int m, int n)
{
    int result = m;
    if(m == n)
    {
        return 0;
    }
    else
    {
        m++;
        result = m + SumOfNaturalNums(m, n);
        return result;
    }
}
