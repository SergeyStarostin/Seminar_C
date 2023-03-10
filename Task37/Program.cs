// Задача 6: Проверка на простое число: (Простое число делится на себя и на 1)
// N = 13 -> "Это простое число"
// N = 12 -> “Это не простое число”

bool CheckPrime(long num, long div)
{
    if (div == 1) return true;
    return num % div != 0 && CheckPrime(num, div - 1);
}

int number = 31, div = number - 1;
Console.WriteLine($"{CheckPrime(number, div)}");