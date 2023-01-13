/* Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2 */

/* int[,] newarray = CreateRandomArray(5, 5);
PrintArray(newarray);

Console.WriteLine ("");

PrintArray(Sorting (newarray));


int [,] Sorting (int [,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(1); k++)
            {
                if (array[i, j] > array[i, k])
                {
                    int tmp = array[i, j];
                    array[i, j] = array[i, k];
                    array[i, k] = tmp;
                } 
            }   
        }  
    }
    return array;
}

int[,] CreateRandomArray(int m, int n)
{
    Random random = new Random();
    int[,] array = new int[n, m];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = random.Next(1, 11);
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
            Console.Write(array[i, j] + "   ");
        }
        Console.WriteLine();
    }
}*/

/*Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка*/

/* int[,] newarray = CreateRandomArray(5, 5);
PrintArray(newarray);

SumRowArray (newarray);


void SumRowArray (int[,] array)
{
    int minRow = 0, minsum = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sum += array[i, j];
        }
        Console.WriteLine($"Сумма {i + 1} строки = {sum}");
        if (i == 0)
        {
            minsum = sum;
        }
        else if (sum < minsum)
        {
            minsum = sum;
            minRow = i+1;
        }
    }
    Console.WriteLine($"Номер строки с минимальной суммой элементов {minRow}. ");
}

int[,] CreateRandomArray(int m, int n)
{
    Random random = new Random();
    int[,] array = new int[n, m];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = random.Next(1, 11);
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
            Console.Write(array[i, j] + "   ");
        }
        Console.WriteLine();
    }
}

 */

/*Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18*/

/*int[,] newarray1 = CreateRandomArray(2, 2);
PrintArray(newarray1);

Console.WriteLine();

int[,] newarray2 = CreateRandomArray(2, 2);
PrintArray(newarray2);

Console.WriteLine();

PrintArray(arrayMultiplic (newarray1, newarray2));


int[,] CreateRandomArray(int m, int n)
{
    Random random = new Random();
    int[,] array = new int[n, m];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = random.Next(1, 11);
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
            Console.Write(array[i, j] + "   ");
        }
        Console.WriteLine();
    }
}

int [,] arrayMultiplic (int [,] array1, int [,] array2)
{
    int [,] multi = new int[array1.GetLength(0), array2.GetLength(1)];
    if (array1.GetLength(1) == array2.GetLength(0))
    {
        for (int i = 0; i < multi.GetLength(0); i++)
        {
            for (int j = 0; j < multi.GetLength(1); j++)
            {
                multi[i, j] = 0;
                for (int n = 0; n < array1.GetLength(1); n++)
                {
                    multi[i, j] += array1[i, n] * array2[n, j];
                }
            }
        }
    }
    return multi;
} */


/*Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, 
которая будет построчно выводить массив, добавляя индексы каждого элемента.
Массив размером 2 x 2 x 2
66(0,0,0) 25(0,1,0)
34(1,0,0) 41(1,1,0)
27(0,0,1) 90(0,1,1)
26(1,0,1) 55(1,1,1)*/


/* int[,,] array3D = CreateRandomArray (2, 2, 2);
Printarray(array3D);



 int[,,] CreateRandomArray(int row, int col, int dep)
{
    Random random = new Random();
    int[,,] array = new int[row, col, dep];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++) 
            { 
                array[i, j, k] = random.Next(1, 99);
            }
        }
    }
    return array;
}

void Printarray(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write("  ");
            for (int k = 0; k < array.GetLength(2); k++) 
            { 
                Console.Write($"{array[i, j, k],1}({i},{j},{k}) "); 
            }
            Console.WriteLine();
        }
    }
} */


 


/*Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07 */



 


Console.Clear();


int n = 4;
int[,] array = new int[n, n];

int tmp = 1;
int i = 0;
int j = 0;


/* for (j = 0; j <= array.GetLength(1)-1; j++)
{
    array[i,j] = tmp;
    tmp++;
}

j = array.GetLength(1)-1;

for (i = 1; i <= array.GetLength(0)-2; i++)
{
    array[i,j] = tmp;
    tmp++;
}

i = array.GetLength(0)-1;

for (j = array.GetLength(1)-1; j >= 0; j--)
{
    array[i,j] = tmp;
    tmp++;
}

j = 0;

for (i = 2; i > 0; i--)
{
    array[i,j] = tmp;
    tmp++;
} */

while (tmp <= array.GetLength(0) * array.GetLength(1))
{
  array[i, j] = tmp;
  tmp++;
  if (i <= j + 1 && i + j < array.GetLength(1) - 1)
    j++;
  else if (i < j && i + j >= array.GetLength(0) - 1)
    i++;
  else if (i >= j && i + j > array.GetLength(1) - 1)
    j--;
  else
    i--;
}

WriteArray(array);

void WriteArray (int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      if (array[i,j] / 10 <= 0)
      Console.Write($"0{array[i,j]} ");

      else Console.Write($"{array[i,j]} ");
    }
    Console.WriteLine();
  }
}