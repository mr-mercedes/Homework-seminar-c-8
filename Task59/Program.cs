/* Задача 59: Задайте двумерный массив из целых чисел. Напишите программу, которая удалит строку и столбец, на пересечении которых расположен наименьший элемент массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Наименьший элемент - 1, на выходе получим
следующий массив:
9 4 2
2 2 6
3 4 7 */

Console.WriteLine("Введите размер массива");
int row = InputNumber("Введите количество строк: ");
int column = InputNumber("Введите количество столбцов: ");
int[,] array = new int[row, column];
FillArray(array);
Console.WriteLine("Начальный массив");
PrintArray(array);
int minNumber = array[0,0];
int positionRow = 0;
int positionColumn = 0;
for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        if (minNumber > array[i,j])
        {
            minNumber = array[i,j];
            positionRow = i;
            positionColumn = j;
        }
    }
}
Console.WriteLine($"Минимальное число в массиве {minNumber} находится на строке {positionRow} столбце {positionColumn}.");
int[,] newArray = ClearArray(array);
Console.WriteLine("Конечный массив");
PrintArray(newArray);

int[,] ClearArray (int[,] array)
{
    int newRow = 0;
    int newColums = 0;
    int[,] newArray = new int [array.GetLength(0) - 1, array.GetLength(1) - 1];
    for (int i = 0; i < newArray.GetLength(0); i++)
    {
        if (newRow == positionRow)
        {
            newRow++;
        }
        for (int j = 0; j < newArray.GetLength(1); j++)
        {
            if (newColums == positionColumn)
            {
                newColums++;
            }
            newArray[i,j] = array[newRow, newColums];
            newColums++;
        }
        newColums = 0;
        newRow++;
    }
    return newArray;
}
int InputNumber (string output)
{
    Console.Write(output);
    return Convert.ToInt32(Console.ReadLine());
}
void PrintArray(int[,] array) 
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i,j] + " ");
        }
        Console.WriteLine();
    }
}
void FillArray(int[,] array) 
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i,j] = new Random().Next(1, 10);
        }
    }
}