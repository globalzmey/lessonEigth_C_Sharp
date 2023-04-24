/*
Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18
*/

int x = 2;
int y = 2;
int[,] firstMartrix = new int[y, x];
int[,] secondMartrix = new int[y, x];
int[,] resultMatrix = new int[y, x];

FillRandom2DArray(firstMartrix);
FillRandom2DArray(secondMartrix);
Console.WriteLine("Произведение двух матриц второго порядка.");
Console.WriteLine("Даны матрицы:");
PrintTwoMatrix(firstMartrix, secondMartrix);
Console.WriteLine("Результирующая матрица будет:");
FirstOnSecondMatrix(firstMartrix, secondMartrix, resultMatrix);
Print2DArray(resultMatrix);

void Print2DArray(int[,] array)
{
    for(int y = 0; y < array.GetLength(0); y++)
    {
        for(int x = 0; x < array.GetLength(1); x++)
        {
            Console.Write($"{array[y, x]} ");
        }
        Console.WriteLine();
    }
}

void FirstOnSecondMatrix(int[,] firstMartrix, int[,] secomdMartrix, int[,] resultMatrix)
{
    for (int i = 0; i < resultMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < resultMatrix.GetLength(1); j++)
        {
            int sum = 0;
            for (int k = 0; k < firstMartrix.GetLength(1); k++)
            {
                sum += firstMartrix[i, k] * secondMartrix[k, j];
            }
            resultMatrix[i, j] = sum;
        }
    }
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

void PrintTwoMatrix(int[,] firstMatrix, int[,] secondMatrix)
{
    for(int y = 0; y < firstMatrix.GetLength(0); y++)
    {
        for(int x = 0; x < firstMatrix.GetLength(1); x++)
        {
            Console.Write($"{firstMatrix[y, x]} ");
        }
        Console.Write("| ");
        for(int x = 0; x < secondMatrix.GetLength(1); x++)
        {
            Console.Write($"{secondMatrix[y, x]} ");
        }
        Console.WriteLine();
    }
}