/*
Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2
*/

int x = 4;
int y = 3;
int[,] array = new int[y, x];

FillRandom2DArray(array);
Console.WriteLine("Исходный массив:");
Print2DArray(array);
Console.WriteLine("Сортированный массив:");
SortRows2DArray(array);
Print2DArray(array);

void FillRandom2DArray(int[,] array)
{
    for(int y = 0; y < array.GetLength(0); y++)
    {
        for(int x = 0; x < array.GetLength(1); x++)
        {
            array[y, x] = new Random().Next(0, 9);
        }
    }
}

void SortRows2DArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(1) - 1; k++)
            {
                if (array[i, k] < array[i, k + 1])
                {
                    int tmp = array[i, k + 1];
                    array[i, k + 1] = array[i, k];
                    array[i, k] = tmp;
                }
            }
        }
    }
}

void Print2DArray(int[,] array)
{
    for(int y = 0; y < array.GetLength(0); y++)
    {
        Console.Write("|");
        for(int x = 0; x < array.GetLength(1) - 1; x++)
        {
            Console.Write($"{array[y, x]}, ");
        }
        Console.WriteLine(array[y, array.GetLength(1) - 1] + "|");
    }
}