// Задача 1: Напишите программу, которая принимает на вход число (А) и 
// выдаёт сумму чисел от 1 до А.
// 7 -> 28
// 4 -> 10
// 8 -> 36

// Ввод числа
int InputInt(string prompt)
{
    System.Console.Write($"{prompt} >");            // Вывод приглашения на экран
    return Convert.ToInt32(Console.ReadLine());     // Ввод с консоли
}

// Проверяет введенное число, что оно больше 0
bool ValidatePositive(int value)
{
    if (value <= 0)     // Сама проверка
    {
        System.Console.WriteLine("Введите положительное число");    // Выводим ошибку пользователю
        return false;       // Признак неправильрного ввода
    }

    return true;            // Можно работать дальше
}

// Подсчет сумма от 1 до value
int SumNumbers(int value)
{
    int sum = 0;    // Будем здесь накапливать сумму
    for(int i = 1; i <= value; i++) //Цикл вычисления суммы
    {
        sum += i;                   // Накапливаем сумму
    }
    return sum;
}

// Подсчет суммы Гауссом
int SumGaussNumbers(int value)
{
    return (1+value)*value/2;
}

int value = InputInt("Введите число");  // Ввод числа
if (ValidatePositive(value))        // Проврека на положительное число
{
    int sum = SumNumbers(value);
    System.Console.WriteLine($"Сумма чисел от 1 до {value} равна {sum}");
    System.Console.WriteLine($"Сумма чисел по Гауссу от 1 до {value} равна {SumGaussNumbers(value)}");
}