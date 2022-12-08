/* Задача 19
Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да */

/* Console.WriteLine("напишите пятизначное число");
int N = int.Parse(Console.ReadLine());

if (N>10000 && N<99999)
{
    int N1 = N/10000;
    int N2 = N/1000%10;
    int N4 = N/10%10;
    int N5 = N%10;

    if (N1 == N5 && N2 == N4)
    {
        Console.WriteLine("палиндром");  
    }
    else
    {
        Console.WriteLine("не палиндром");  
    }
}
else
{
   Console.WriteLine("число не пятизначное"); 
} */



/* Задача 21
Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53 */

/* double Distance3D (int X1, int Y1, int Z1, int X2, int Y2, int Z2)
{
    double result = Math.Sqrt(Math.Pow(X2-X1, 2)+Math.Pow(Y2-Y1, 2)+Math.Pow(Z2-Z1, 2));
    return result;
}

Console.WriteLine("введите координы точек в 3д пространстве");
int A1 = int.Parse(Console.ReadLine());
int A2 = int.Parse(Console.ReadLine());
int B1 = int.Parse(Console.ReadLine());
int B2 = int.Parse(Console.ReadLine());
int C1 = int.Parse(Console.ReadLine());
int C2 = int.Parse(Console.ReadLine());

double D = Distance3D (A1, A2, B1, B2, C1, C2);

Console.Write("расстояние между заданными точками в 3д пространстве: " + D); */


/* Задача 23
Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125 */

Console.WriteLine("введите число");
int N = int.Parse(Console.ReadLine());
for (int i = 1; i <= N; i++)
{
    Console.Write(Math.Pow(i, 3) + " ");
}