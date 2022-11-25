/*
Задача 60. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
Напишите программу, которая будет построчно выводить массив, 
добавляя индексы каждого элемента.
Массив размером 2 x 2 x 2
66(0,0,0) 25(0,1,0)
34(1,0,0) 41(1,1,0)
27(0,0,1) 90(0,1,1)
26(1,0,1) 55(1,1,1)
*/
int[,,] InitArray(int x, int y, int z)
{
    Random rnd = new Random();
    int[,,] array = new int[x, y, z];
    for (int i = 0; i < x; i++)
    {
        for (int j = 0; j < y; j++)
        {
            for (int k = 0; k < z; k++)
            {
                array[i, j, k] = rnd.Next(10, 100);
                while (TestNumber(arrayNumber: array, 
                testElement: array[i, j ,k]) == true)
                {
                    array[i, j, k] = rnd.Next(10, 100);
                }
            }
        }
    }
    return array;
}

void PrintArray(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                Console.Write($"{array[i, j, k]}({i},{j},{k}) ");
            }
            Console.WriteLine();
        }
    }
}

bool TestNumber(int[,,] arrayNumber, int testElement)
{
    bool test = new bool();
    int count = new int();
    for (int i = 0; i < arrayNumber.GetLength(0); i++)
    {
        for (int j = 0; j < arrayNumber.GetLength(1); j++)
        {
            for (int k = 0; k < arrayNumber.GetLength(2); k++)
            {
                if (arrayNumber[i, j, k] == testElement) count++;
            }
        }
    }
    if (count > 1) test = true;
    else test = false;
    return test;
}

int x = 2, y = 2, z = 2;
int[,,] array = InitArray(x, y, z);
PrintArray(array);

