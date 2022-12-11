/* Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16 */

Console.WriteLine("введите два числа");
int A = int.Parse(Console.ReadLine());
int B = int.Parse(Console.ReadLine());
double C = Degree(A, B);
Console.WriteLine(A + " в степени " + B + " будет " + C);

int Degree (int x, int y)
{
    int deg = 1;
    while (y>0)
    {
        deg = deg * x;
        y-=1;
    }
    return deg;
}

/* Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12 */

/* Console.WriteLine("введите число");
int A = int.Parse(Console.ReadLine());
int B = Summ (A);
Console.WriteLine("сумма чисел в " + A + " равна " + B); */

int Summ (int x)
{
    int sum = 0;
    while (x>0)
    {
        sum = sum + x%10;
        x = x/10;
    }
    return sum;
}

/* Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33] */

/* Console.WriteLine("введите размер массива");
int S = int.Parse(Console.ReadLine());
int [] array = new int [S];
Console.WriteLine("теперь нужно заполнить массив. введите " + S + " чисел");
for (int i = 0; i < S; i++)
{
    int x = int.Parse(Console.ReadLine());
    array [i] = x;   
}
PrintArray (array); */



void PrintArray(int[] array)
{
    Console.Write("[");
    for (var i = 0; i < array.Length-1; i++)
    {
        Console.Write($"{array[i]},");
    }
    Console.Write(array[array.Length-1]);
    Console.Write("]");
}
