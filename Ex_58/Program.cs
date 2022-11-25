/*
Задача 58: Задайте две матрицы. Напишите программу,
которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18
*/

int[,] InitialMatrix(int line, int column)
{
    Random randomNumber = new Random();
    int[,] matrix = new int[line, column];
    for (int i = 0; i < line; i++)
    {
        for (int j = 0; j < column; j++)
        {
            matrix[i, j] = randomNumber.Next(0, 6);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]} ");
        }
        Console.WriteLine();
    }
}

int[,] MultiplicationTwoMatrix(int[,] matrixFirst, int[,] matrixSecond)
{
    int summ = 0;
    int[,] matrixMulti = new int[matrixFirst.GetLength(0), matrixSecond.GetLength(1)];
    for (int i = 0; i < matrixMulti.GetLength(0); i++)
    {
        for (int j = 0; j < matrixMulti.GetLength(1); j++)
        {
            summ = 0;
            for (int k = 0; k < matrixFirst.GetLength(1); k++)
            {
                summ = summ + (matrixFirst[i, k] * matrixSecond [k, j]);
            }
            matrixMulti[i, j] = summ;
        }
    }
    return matrixMulti;
}

Random random = new Random();
int line = random.Next(2, 4);
int column = random.Next(2, 4);
int[,] matrixFirst = InitialMatrix(line, column);

line = random.Next(2, 4);
column = random.Next(2, 4);
int[,] matrixSecond = InitialMatrix(line, column);
PrintMatrix(matrixFirst);
Console.WriteLine("-------------");
PrintMatrix(matrixSecond);

if (matrixFirst.GetLength(1) == matrixSecond.GetLength(0))
{
    int[,] resultMatrix = MultiplicationTwoMatrix(matrixFirst, matrixSecond);
    Console.WriteLine("-------------");
    PrintMatrix(resultMatrix);
}
else Console.WriteLine("Эти две матрицы не могут быть перемножены");