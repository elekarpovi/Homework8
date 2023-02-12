// Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, 
//которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

Console.Clear();

Random rnd = new Random();
int m = rnd.Next(2, 10);
int n = rnd.Next(2, 10);
int k = rnd.Next(2, 10);
System.Console.WriteLine($"Параметры массива: {m} x {n} x {k}");
System.Console.WriteLine();

int [,,] array = new int [m, n, k];
int t = m * n * k;
if (t > 90) System.Console.Write("Невозможно сформировать массив!");
else
{
int[] arr = new int[90];
for (int q = 10; q < arr.Length + 10; q++)
{
    arr[q - 10] = q;

}

for (int r = 0; r < arr.Length; r++)
{
    int w = rnd.Next(90);
    int buf = arr[w];
    arr[w] = arr[r];
    arr[r] = buf;
}


void FillArray(int[,,] array)
{
    int t = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {

                array[i, j, k] = arr[t];
                t++;
            }
        }

    }
}


void PrintArray(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)

        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                Console.Write(String.Format("{0,4}", array[i, j, k]) + (i,j,k) + " ");
            }
            Console.WriteLine();
        }


    }
}

Console.WriteLine();
FillArray(array);
Console.WriteLine("Массив из неповторяющихся двузначных чисел с индексами:");
PrintArray(array); 
}   
// int[] arr = new int[t];
// int y =0;
// for (int i = 0; i < t; i++)
// {
//     arr[0] = 10;
//     arr[i] = arr[i] + 1;
//     y = arr[i];
//     if (i >= 1)
//     {
//         for (int j = 0; j < i; j++)
//         {
//             while (arr[i] == arr[j])
//                 {
//                     arr[i] =rnd.Next(10, 100);
//                     j = 0;
//                     y = arr[i];
//                 }
 
//                 y = arr[i];
//         }
//     }


//            array[i,j,l] = arr[i];                       
//            System.Console.Write(String.Format("{0,2}", array[x,j,l]) + (x,j,l) + " ");  
// }
//        }       
    
//     System.Console.WriteLine();

// System.Console.WriteLine();

                       
