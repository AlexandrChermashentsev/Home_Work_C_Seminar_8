/*
Задача 56: Задайте прямоугольный двумерный массив. 
Напишите программу, которая будет находить строку с наименьшей суммой элементов.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке
и выдаёт номер строки с наименьшей суммой элементов: 1 строка
*/

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

int[,] InitialMatrix(int line, int column)
{
    Random randomNumber = new Random();
    int[,] matrix = new int[line, column];
    for (int i = 0; i < line; i++)
    {
        for (int j = 0; j < column; j++)
        {
            matrix[i, j] = randomNumber.Next(0, 10);
        }
    }
    return matrix;
}

int MinSummLineOfMatrix(int[,] matrix, int line, int column)
{
    int summ = 0;
    int tempSumm = 0;
    int str = 1;
    for (int i = 0; i < column; i++)
    {
        summ = summ + matrix[0, i];
    }
    Console.WriteLine($"Summ[0, i] = {summ}");
    for (int i = 1; i < line; i++)
    {
        for (int j = 0; j < column; j++)
        {
            tempSumm = tempSumm + matrix[i, j];
        }
        if (summ > tempSumm)
        {
            summ = tempSumm;
            str = i + 1;
        }
        // строка ниже поможет определить правильность работы программы
        Console.WriteLine($"Summ={summ}, Temp={tempSumm}, str = {str}");
        tempSumm = 0;
    }
    return str;
}

Random random = new Random();
int line = random.Next(2, 10);
int column = random.Next(2, 6);

int[,] matrix = InitialMatrix(line, column);
PrintMatrix(matrix);
int str = MinSummLineOfMatrix(matrix, line, column);
Console.WriteLine($"строка с наименьшей суммой: {str}");