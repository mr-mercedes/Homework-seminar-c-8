/* 
Задача 62: Заполните спирально массив 4 на 4.
1 2 3 4
12 13 14 5
11 16 15 6
10 9 8 7 
*/
int row = 4;
int column = 4;
int[,] array = new int[row, column];
array[0, 0] = 1;
int elements = row * column;
int posX = 0;
int posY = 0;
bool up = false;
bool right = true;
bool down = false;
bool left = false;

for (int i = 2; i <= elements; i++)
{
    if(up && (posX - 1 < 0 || array[posX - 1, posY] != 0))//UP
    {
        right = true;
        up = false;
        down = false;
        left = false;
    }
    else if(right && (posY + 1 == row || array[posX, posY + 1] != 0))//Right
    {
        right = false;
        up = false;
        down = true;
        left = false;
    }
    else if(down && (posX + 1 == column || array[posX + 1, posY] != 0))//Down
    {
        right = false;
        up = false;
        down = false;
        left = true;
    }
    else if(left && (posY - 1 < 0 || array[posX, posY - 1] != 0))//Left
    {
        right = false;
        up = true;
        down = false;
        left = false;
    }

    if(up)
    {
        posX--;
        array[posX, posY] = i;
    }
    else if(right)
    {
        posY++;
        array[posX, posY] = i;
    }
    else if(down)
    {
        posX++;
        array[posX, posY] = i;
    }
    else if(left)
    {
        posY--;
        array[posX, posY] = i;
    }
}
Console.WriteLine("Спиральная матрица");
PrintArray(array);

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