/* Задача 64: Задайте значение n. Напишите программу, которая выведет все натуральные числа в промежутке от n до 1. Выполнить с помощью рекурсии.
n = 5 -> "5, 4, 3, 2, 1"
n = 8 -> "8, 7, 6, 5, 4, 3, 2, 1" */

/* Console.WriteLine("введите число");
int n = int.Parse(Console.ReadLine());
Console.WriteLine();
numbers (n);

void numbers (int num)
{
    if (num > 0)
    {
    Console.Write($" {num} ");
    numbers (num-1);
    }
} */



/* Задача 66: Задайте значения m и n. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от m до n. 
Выполнить с помощью рекурсии.
m = 1; n = 15 -> 120
m = 4; n = 8. -> 30 */

/* Console.WriteLine("введите число m");
int M = int.Parse(Console.ReadLine());

Console.WriteLine("введите число n");
int N = int.Parse(Console.ReadLine());

Console.WriteLine();
NumberSum(M, N, 0);


void NumberSum (int m, int n, int s)
{
    if (m > n) 
    {
        Console.WriteLine($"Сумма чисел в промежутке от m до n: {s}"); 
        return;
    }
    s = s + (m++);
    NumberSum(m, N, s);
} */

/* Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29 */


Console.WriteLine("введите число m");
int m = int.Parse(Console.ReadLine());

Console.WriteLine("введите число n");
int n = int.Parse(Console.ReadLine());

Console.WriteLine();

Console.WriteLine(Akkerman(m, n));
int Akkerman(int m, int n)
{
    if (n == 0)
        return m + 1;
    else if ((n != 0) && (m == 0))
        return Akkerman(n - 1, 1);
    else
        return Akkerman(n - 1, Akkerman(n, m - 1));
}