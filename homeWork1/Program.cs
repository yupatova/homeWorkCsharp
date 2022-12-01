/* Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

a = 5; b = 7 -> max = 7
a = 2 b = 10 -> max = 10
a = -9 b = -3 -> max = -3 */

/* Console.WriteLine("введите два числа");

int N1 = int.Parse(Console.ReadLine());
int N2 = int.Parse(Console.ReadLine());

if (N1>N2)
{
    Console.WriteLine("первое > второго");
}

if (N2>N1)
{
    Console.WriteLine("второе > первого");
}

if (N2==N1)
{
    Console.WriteLine("числа равны");
} */





/* Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22 */

/* Console.WriteLine("введите три числа");

int N1 = int.Parse(Console.ReadLine());
int N2 = int.Parse(Console.ReadLine());
int N3 = int.Parse(Console.ReadLine());
int max = N1;
if (N2>max)
{
    max = N2;
}

if (N2>max)
{
    max = N2;
}
if (N3>max)
{
    max = N3;
}

    Console.WriteLine(max + " большее из чисел"); */


/* Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
4 -> да
-3 -> нет
7 -> нет */

/* Console.WriteLine("введите число");

int N1 = int.Parse(Console.ReadLine());

if (N1%2 == 0)
{
    Console.WriteLine("число четное");
}

else
{
    Console.WriteLine("число нечетное");
} */


/* Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

5 -> 2, 4
8 -> 2, 4, 6, 8 */

Console.WriteLine("введите число");

int N1 = int.Parse(Console.ReadLine());

for (int i = 1; i <= N1; i++)
{
    if (i % 2 == 0)
    {
        Console.Write(i + " ");
    }
}
