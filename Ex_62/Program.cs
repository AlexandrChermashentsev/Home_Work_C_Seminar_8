/*
Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4. 
Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07
*/
int[,] InitHelixMatrix(int[,] matrix)
{
    int count = 0;
    for (int i = 0; i < 4; i++) // первый вправо
    {
        matrix[0, i] = count + 1;
        count++;
    }
    for (int i = 1; i < 4; i++) // второй вниз
    {
        matrix[i, 3] = count + 1;
        count++;
    }
    for (int i = 2; i >= 0; i--) // третий влево
    {
        matrix[3, i] = count + 1;
        count++;
    }
    for (int i = 2; i >= 1; i--) // четвертый вверх
    {
        matrix[i, 0] = count + 1;
        count++;
    }
    for (int i = 1; i < 3; i++) // пятый вправо
    {
        matrix[1, i] = count + 1;
        count++;
    }
    for (int i = 2; i >= 1; i--) // шестой влево
    {
        matrix[2, i] = count + 1;
        count++;
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if(matrix[i, j] < 10) Console.Write($"0{matrix[i, j]} ");
            else Console.Write($"{matrix[i, j]} ");
        }
        Console.WriteLine();
    }
}

int row = 4;
int col = 4;
int[,] matrix = new int[row, col];
matrix = InitHelixMatrix(matrix);
PrintMatrix(matrix);

