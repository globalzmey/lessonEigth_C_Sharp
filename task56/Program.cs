/*
Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка
*/

int x = 4;
int y = 4;
int minSumRow = 0;
int[,] array = new int[y, x];

FillRandom2DArray(array);
Console.WriteLine("Задан массив:");
Print2DArray(array);

int sumRow = SumElementsOfRow(array, 0);
for (int i = 1; i < array.GetLength(0); i++)
{
  int tmpSumRow = SumElementsOfRow(array, i);
  if (sumRow > tmpSumRow)
  {
    sumRow = tmpSumRow;
    minSumRow = i;
  }
}

Console.WriteLine($"Наименьшая сумма элементов: {sumRow} в строке: {minSumRow + 1}");

int SumElementsOfRow(int[,] array, int i)
{
  int sumRow = array[i,0];
  for (int j = 1; j < array.GetLength(1); j++)
  {
    sumRow += array[i,j];
  }
  return sumRow;
}

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