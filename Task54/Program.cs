// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.

Console.WriteLine("Введите размер массива");
int row = InputNumber("Введите количество строк: ");
int column = InputNumber("Введите количество столбцов: ");
int[,] array = FillArray(row, column);
Console.WriteLine("Исходный массив");
PrintArray(array);
Console.WriteLine("Сортировка по строкам: ");
int[] lineArray = new int[column];
for (int i = 0; i < row; i++)
{
    for (int j = 0; j < column; j++)
        lineArray[j] = array[i, j];
        SortLineArray(lineArray);
        MassiveSort(true, i, lineArray, array);
}
PrintArray(array);


void MassiveSort(bool isRow, int i, int[] lineArray, int[,] array)
{
    for (int k = 0; k < lineArray.Length; k++)
    {
        if (isRow)
            array[i, k] = lineArray[k];
        else
            array[k, i] = lineArray[k];
    }
}
int[,] FillArray(int t, int i)
{
    int[,] table = new int[t, i];
    Random random = new Random();
    for (int a = 0; a < t; a++)
    {
        for (int b = 0; b < i; b++)
        {
            table[a, b] = random.Next(0, 9);
        }
    }
    return table;
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
void SortLineArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        for (int j = 0; j < array.Length - i - 1; j++)
        {
            if (array[j] < array[j + 1])
            {
                int maxNumber = array[j+1];
                array[j+1] = array[j];
                array[j] = maxNumber;
            }
        }
} 
int InputNumber(string output)
{
    Console.Write(output);
    return Convert.ToInt32(Console.ReadLine());
}
