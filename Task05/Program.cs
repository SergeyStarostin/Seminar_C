// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает последнюю цифру этого числа.
// 456 -> 6
// 782 -> 2
// 918 -> 8

int Prompt(string msg)
{
    System.Console.Write($"{msg} >");
    return Convert.ToInt32(Console.ReadLine());
}

bool Validate(int num)
{
    if (num >= 100 && num < 1000)
    {
        return true;
    }
    System.Console.WriteLine("Это число не трехзначное");
    return false;
}

int number = Prompt("Введите 3-хзначное число");
if (Validate(number))
{
    int lastDigit = number % 10;
    System.Console.WriteLine($"последняя цифра числа {number} равна {lastDigit}");
}