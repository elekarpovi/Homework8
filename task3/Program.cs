// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18


Console.Clear();

Random rnd = new Random();
int m = rnd.Next(3, 5);
int n = rnd.Next(3, 5);

//матрица1
System.Console.WriteLine("Исходная матрица 1:");

int [,] array1 = new int [m, n];
for (int i = 0; i < array1.GetLength(0); i++)
{
    for (int j = 0; j < array1.GetLength(1); j++)
    {
       array1[i, j] = rnd.Next(5);
       System.Console.Write(String.Format("{0,5}", array1[i,j]) + " ");
    }
    System.Console.WriteLine();
}
System.Console.WriteLine();

//матрица2
System.Console.WriteLine("Исходная матрица 2:");

int [,] array2 = new int [m, n];
for (int i = 0; i < array2.GetLength(0); i++)
{
    for (int j = 0; j < array2.GetLength(1); j++)
    {
       array2[i, j] = rnd.Next(5);
       System.Console.Write(String.Format("{0,5}", array2[i,j]) + " ");
    }
    System.Console.WriteLine();
}
System.Console.WriteLine();

if (array1.GetLength(0) != array2.GetLength(1)) 
{
    System.Console.WriteLine("Матрицы нельзя перемножить!");
    return;
}


int [,] resultArray = new int [array1.GetLength(0), array2.GetLength(1)];
System.Console.WriteLine("Произведение 2 матриц представлено в результирующей матрице: ");
for (int i = 0; i < array1.GetLength(0); i++)
{
    for (int j = 0; j < array2.GetLength(1); j++)
    {
        for (int k = 0; k < array2.GetLength(0); k++)
        {  
          resultArray[i, j] = resultArray[i, j] + array1[i, k] * array2[k, j];
          
        }
        System.Console.Write(String.Format("{0,5}", resultArray[i,j]) + " ");
    }
    System.Console.WriteLine();       
    }  


