// Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

Console.Clear();

Random rnd = new Random();
int m = rnd.Next(4, 10);
int n = rnd.Next(4, 10);

int [,] array = new int [m, n];
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


for (int i = 0; i < array.GetLength(0); i++)
{
    
   for (int j = 0; j < array.GetLength(1); j++)
     {
        for (int l = 0; l < array.GetLength(1)-1; l++)
        {      
          if (array[i, l] < array[i, l+1])
            {
              (array[i, l+1], array[i, l]) = (array[i, l], array[i, l+1]);
            }  
                
        }
     }
}

for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
       System.Console.Write(String.Format("{0,5}", array[i,j]) + " ");
    }
    System.Console.WriteLine();
}
System.Console.WriteLine();
