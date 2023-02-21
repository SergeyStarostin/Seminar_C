// Задача 2: Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.
// 4 -> 24 
// 5 -> 120

int Inputint(string prompt)
{
    System.Console.Write($"{prompt}  --> ");
    return Convert.ToInt32(Console.ReadLine());
}

int GetNumber(int num)
{
    int countNumber = 0;
    while (num > 0)
    {
        num /= 10;
        countNumber++;
    }
    return countNumber;
}

int userNumber = Inputint("Введите число ");
Console.WriteLine($"Количество цифр в числе {userNumber} = {GetNumber(userNumber)}");

