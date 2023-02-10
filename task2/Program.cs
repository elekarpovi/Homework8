// Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

Console.Clear();

Random rnd = new Random();
int m = rnd.Next(3, 10);

int [,] array = new int [m, m];

for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
       array[i, j] = rnd.Next(-10, 11);
       System.Console.Write(String.Format("{0,5}", array[i,j]) + " ");
    }
    System.Console.WriteLine();
}
System.Console.WriteLine();

int [] a = new int[m];
for (int i = 0; i < array.GetLength(0); i++)
{
   int sum = 0; 
   for (int j = 0; j < array.GetLength(1); j++)
     {
        {  
          sum = sum + array[i, j];      
        }
     }
     a[i] = sum;
     System.Console.Write($"Сумма элементов строки {i+1}: ");
     System.Console.WriteLine(a[i]);  
}
System.Console.WriteLine();

int min = a[0];
int n = 0;
for (int i = 0; i < m; i++)
{
    if (a[i] < min) 
    {
        min = a[i];
        n=i;
    }
}
System.Console.WriteLine($"Номер строки с наименьшей суммой элементов: {n+1}");

