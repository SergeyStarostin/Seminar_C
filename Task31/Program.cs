// Задайте двумерный массив из целых чисел. Напишите программу, 
// которая удалит строку и столбец, на пересечении которых расположен 
// наименьший элемент массива.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Наименьший элемент - 1, на выходе получим 
// следующий массив:
// 9 2 3
// 4 2 6
// 2 6 7

int[,] GenerateArray(int row, int col)
{
    int[,] array = new int[row, col]; // Создаем 2-мерный массив
    Random rnd = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = rnd.Next(-9, 10);
        }
    }
    return array;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.WriteLine();
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]}\t");
        }
    }
    Console.WriteLine();
}

(int, int) FindeMinArray(int[,] array)
{
    int mini = 0;
    int minj = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[mini, minj] > array[i, j])
            { mini = i; minj = j; }
        }
    }
    return (mini, minj);
}

int[,] DeliteMInElement(int[,]array, int mini, int minj)
{
    int[,] result = new int[array.GetLength(0) - 1, array.GetLength(1) - 1];
    for (int i = 0; i < array.GetLength(0); i++)
    {
    for (int j = 0; j < array.GetLength(1); j++)
    {
        if (i == mini || j == minj ) continue;
        int k = i;
        int l = j; 
        if (i > mini) k--; 
        if (j > minj) l--;
        result [k, l] = array[i, j];
    } 
    }
    return result;
}

int[,] matrix = GenerateArray(4, 4);
PrintArray(matrix);
(int mini, int minj) = FindeMinArray(matrix);
PrintArray(DeliteMInElement(matrix, mini, minj));
