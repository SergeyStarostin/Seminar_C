﻿// Задача 3: Не используя рекурсию, выведите первые N чисел Фибоначчи. 
// Первые два числа Фибоначчи: 0 и 1.
// Если N = 5 -> 0 1 1 2 3
// Если N = 3 -> 0 1 1
// Если N = 7 -> 0 1 1 2 3 5 8

int InputUser(string msg)
{
    Console.Write($"{msg} -> ");
    return Convert.ToInt32(Console.ReadLine());
}

int[] Array(int size)
{
    int[] array = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < size; i++)
    {
        array[i] = rnd.Next(0, 100);
    }
    return array;
}

void PrintArray(int[] array)
{
    foreach (int item in array)
    {
        System.Console.Write($"{item} ");
    }
    System.Console.WriteLine();
}

int [] Fibo(int n) // функция вычисления числа Фибоначчи
{
    int [] result = new int[n];
    result[0] = 0; result[1] = 1;
    for (int i = 2; i < result.Length; i++)
    {
        result[i] = result[i-1] + result[i-2];
    }
return result;
}

int [] fibo = Fibo (InputUser( "Введите число"));
PrintArray(fibo);