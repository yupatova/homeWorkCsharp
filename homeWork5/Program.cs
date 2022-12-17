int[] CreateRandomArray(int size, int minValue, int maxValue)
{
    Random random = new Random();
    int[] array = new int[size];

    for (var i = 0; i < size; i++)
    {
        array[i] = random.Next(minValue, maxValue + 1);
    }

    return array;
}

void PrintArray(int[] array)
{
    string str = string.Join(", ", array);
    Console.WriteLine($"[ {str} ]");
}


/*  Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2 */

int Even (int [] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i]%2 == 0)
    {
        count++;
    }
    }
    return count;
}

/* int[] array = CreateRandomArray(15, 100, 999);
PrintArray(array);
int A = Even (array);
Console.WriteLine($" четных эементов в массиве - {A} штук"); */




/* Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0 */

int Summer (int [] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (i%2 != 0)
        {
            sum = sum + array[i];
        }
    }
    return sum;
}

/* int[] array = CreateRandomArray(4, -10, 10);
PrintArray(array);
int B = Summer (array);
Console.WriteLine($" сумма элементов в нечетных позициях - {B}"); */




/* Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
[3 7 22 2 78] -> 76 */

int DifferentBetween (int [] array)
{
    int max = array[0];
    int min = array[0];
    for (int i = 0; i < array.Length; i++)
    {
    if (array[i] > max)    max = array[i];
    if (array[i] < min)    min = array[i];
    }
    return max - min;
}

int[] array = CreateRandomArray(5, 0, 100);
PrintArray(array);
int C = DifferentBetween (array);
Console.WriteLine($" разница между min и max - {C}");