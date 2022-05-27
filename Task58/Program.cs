// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

int row = 5;
int column = 5;
int[,] firstArray = FillArray(row, column);
Console.WriteLine("Первая матрица");
PrintArray(firstArray);
int[,] secondArray = FillArray(row, column);
Console.WriteLine("Вторая матрица");
PrintArray(secondArray);
int[,] multiplicationArray = new int[row, column];
for (int i = 0; i < multiplicationArray.GetLength(0); i++)
{
    for (int j = 0; j < multiplicationArray.GetLength(1); j++)
    {
        multiplicationArray[i,j] = 0;
        for (int k = 0; k < multiplicationArray.GetLength(0); k++)
        {
            multiplicationArray[i, j] = multiplicationArray[i,j] + (firstArray[i, k] * secondArray[k, j]);
        }
    }
}
Console.WriteLine("Произведение двух матриц");
PrintArray(multiplicationArray);

int[,] FillArray(int row, int column)
{
    int[,] array = new int[row, column];
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < column; j++)
        {
            array[i, j] = new Random().Next(0, 10);
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
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}

