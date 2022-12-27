/* Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9 */

/* double[,] newarray = CreateRandomDoubleArray(3,4);
PrintArray(newarray);

double[,] CreateRandomDoubleArray(int m, int n)
{
    Random random = new Random();
    double[,] array = new double[n, m];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            //array[i,j] = random.NextDouble();
            array[i,j] = Convert.ToDouble(new Random().Next(-100,100))/10;
        }
    }
    return array;
}

void PrintArray(double[,] array)
{
     for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i,j]+" ");
        }
            Console.WriteLine();

    }
} */

/* Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента 
или же указание, что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
17 -> такого числа в массиве нет */


/* Random rndRow = new Random();
Random rndcol = new Random();

int[,] newarray = CreateRandomArray(rndRow.Next(2, 10), rndcol.Next(2, 10));
PrintArray(newarray);

Console.WriteLine("введите индекс элемента массива");
int row = Convert.ToInt32(Console.ReadLine());
int col = Convert.ToInt32(Console.ReadLine());

if (row > newarray.GetLength(0) && col > newarray.GetLength(1)) 
Console.WriteLine("нет такого элемента");
else Console.WriteLine(newarray[row, col]);

int[,] CreateRandomArray(int m, int n)
{
    Random random = new Random();
    int[,] array = new int[n, m];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = random.Next(0, 100);
        }
    }
    return array;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}

 */
/* Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3. */



int[,] newarray = CreateRandomArray(3, 3);

PrintArray(newarray);

double [] aver = Average (newarray);
for (int i = 0; i < aver.Length; i++)
{
    Console.Write($" {aver[i]} ");
}



double [] Average (int [,] array)
{
    double [] aver = new double [array.GetLength(0)];
    double sum = 0;
    for (int j = 0; j < array.GetLength(1); j++)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            sum +=array[i,j];
        }
        aver[j] = sum/array.GetLength(0);
        sum = 0;
    }
    return aver;

}

int[,] CreateRandomArray(int m, int n)
{
    Random random = new Random();
    int[,] array = new int[n, m];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = random.Next(0, 11);
        }
    }
    return array;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}