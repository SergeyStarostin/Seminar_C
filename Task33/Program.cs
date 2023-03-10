// Задача 2: Задайте значения M и N. Напишите программу, которая рекурсивно выведет все натуральные числа в промежутке от M до N.
// M = 1; N = 5 -> "1, 2, 3, 4, 5"
// M = 4; N = 8 -> "4, 5, 6, 7, 8"


void ShowNumber(int first, int second)
{
    if (first > second) return;
    Console.Write($"{first}  ");
    ShowNumber(first + 1, second);
}

int num = 4, numTwo = 8;
ShowNumber(num, numTwo);