/* Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
 */

/*  Console.WriteLine("введите значение b1");
 double b1 = double.Parse(Console.ReadLine());
 
 Console.WriteLine("введите значение k1");
 double k1 = double.Parse(Console.ReadLine());
 
 Console.WriteLine("введите значение b2");
 double b2 = double.Parse(Console.ReadLine());
 
 Console.WriteLine("введите значение k2");
 double k2 = double.Parse(Console.ReadLine());

 if (b1/b2 == k1/k2 || b1/b2 == 1 && b1/b2 != k1/k2)
 {
    Console.WriteLine("прямые совпадают или параллельны");
 }                
 else
 {
 double x = (b2-b1)/(k1-k2);
 double y = (k1*x)+b1;
 Console.WriteLine($" прямые пересекаются в точке {x}; {y}");
 } */




/* Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3 */


Console.WriteLine("введите числа");

string received = Console.ReadLine();

string [] numbers = new string [received.Length];

int k = 0;
for (int i = 0; i < received.Length; i++)
{
  if (received[i] == ',' || received[i] == ' ')
  {
    k++;
  }
  else
  {
    numbers[k] = numbers[k]+$"{received[i]}";
  }
}
k++;
int [] resultreceived = new int[k];
PrintArray (resultreceived, numbers);
int sum = 0;
for (int i = 0; i < k; i++)
{
  if (resultreceived[i]>0)
  {
    sum++;
  }
}
Console.WriteLine ("Количество чисел больше 0: "+sum);

void PrintArray (int [] array, string [] string1)
{
  for (int i = 0; i < array.Length; i++)
  {
  array[i] = Convert.ToInt32(string1[i]);
  Console.Write (array[i]+"  ");
  }
Console.WriteLine();
}



