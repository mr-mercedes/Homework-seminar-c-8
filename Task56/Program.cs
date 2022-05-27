// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

int row = 4;
int column = 6;
int[,] array = FillArray(row, column);
Console.WriteLine("Массив");
PrintArray(array);
int[] sumArray = SumLineArray(array);
int minNumber = sumArray[0];
int count = 0;
for (int i = 1; i < sumArray.Length; i++)
{
    if (minNumber > sumArray[i])
    {
        minNumber = sumArray[i];
        count = i;
    }
}
Console.WriteLine($"В строке {count} сумма элементов минимальная, равна {minNumber}.");

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
int[] SumLineArray(int[,] array)
{
    int[] sumArray = new int[array.GetLength(0)];
    int sum = 0;
    int count = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (count >= array.GetLength(1))
            {
                count = 0;
                sum = 0;
            }
            if (count == array.GetLength(1) - 1)
            {
                sum = array[i, j] + sum;
                sumArray[i] = sum;
                count = array.GetLength(1) + 1; 
            }
            else
            {
                sum = array[i, j] + sum;
                sumArray[i] = sum;
                count++;
            }
        }
    }
    return sumArray;
}
