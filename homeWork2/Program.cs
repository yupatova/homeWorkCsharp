﻿/* Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
456 -> 5
782 -> 8
918 -> 1 */

/* Console.WriteLine("введите трехзначное число");
int N = int.Parse(Console.ReadLine());
Console.WriteLine(N%100/10); */





/* Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6 */

/* Console.WriteLine("введите число");
int N = int.Parse(Console.ReadLine());

if (N > 999)
{
    while (N > 999)
    {
    N = N/10;
    }
Console.WriteLine(N%100%10);
}
else
{
    Console.WriteLine("Третьей цифры нет");
} */




/* Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
6 -> да
7 -> да
1 -> нет */

Console.WriteLine("введите цифру от 1 до 7");
int N = int.Parse(Console.ReadLine());

if (N == 6 || N == 7)
{
    Console.WriteLine("yes");
}
else
{
    Console.WriteLine("no");

}
