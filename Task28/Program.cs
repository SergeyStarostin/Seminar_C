// Задача 1: Задайте двумерный массив. Напишите программу, которая поменяет местами первую и последнюю строку массива.


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

void PrintArray (int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.WriteLine();
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i,j]} \t");
        }
    }
    Console.WriteLine();
}

int[,] MuveFirstLast(int[,]array)
{
    int LastRow = array.GetLength(0)-1;
    for (int i = 0; i < array.GetLength(1); i++)
    {
       (array[LastRow,i],array[0,i])=(array[0,i],array[LastRow,i]);
    }
    return array;
} 

int[,] MyArray = GenerateArray(5,6);
PrintArray(MyArray);
PrintArray(MuveFirstLast(MyArray));