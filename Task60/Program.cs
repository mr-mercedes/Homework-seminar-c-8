// Задача 60: Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.

Console.WriteLine("Задайте размеры трехмерного массива");
int row = InputNumber("Введите количество строк: ");
int column = InputNumber("Введите количество столбцов: ");
int depth = InputNumber("Введите глубину массива: ");
int[,,] array = new int[row, column, depth];
int count = 10;
for (int x = 0; x < array.GetLength(0); x++)
{
    for (int y = 0; y < array.GetLength(1); y++)
    {
        for (int z = 0; z < array.GetLength(2); z++)
        {
            array[x, y, z] = count;
            count++;
        }
    }
}
PrintArray(array);

int InputNumber(string output)
{
    Console.Write(output);
    return Convert.ToInt32(Console.ReadLine());
}
void PrintArray(int[,,] array)
{
    int count = 0;
    for (int z = 0; z < array.GetLength(2); z++)
    {
        for (int x = 0; x < array.GetLength(0); x++)
        {
            for (int y = 0; y < array.GetLength(1); y++)
            {
                if (count >= array.GetLength(1))
                {
                    Console.WriteLine();
                    count = 0;
                }
                if (count == array.GetLength(1) - 1)
                {
                    count = array.GetLength(1) + 1;
                }
                Console.Write($"{array[x, y, z]} [{x},{y},{z}] ");
                count++;
            }
        }
    }
}

