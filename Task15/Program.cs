// Задача 2: Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.
// 4 -> 24 
// 5 -> 120


int Inputint(string prompt)
{
    System.Console.Write($"{prompt}  --> ");
    return Convert.ToInt32(Console.ReadLine());
}

int GetNumber(int num)   // метод который считает количество цифр в числе
{
    int countNumber = 0; // счетчик цифр
    while (num > 0)      // ело цикла будет выполняться пока число не станет 0
    {
        num /= 10;       // делим число на 10 и отсекаем последнюю цифру числа
        countNumber++;   // прибовляем счетчик который подсчитывает количество цифр 
    }
    return countNumber;  // возвращаем значение счетчика как результат метода
}

int userNumber = Inputint("Введите число "); // вызываем метод Inputint и кладем значение в переменную
Console.WriteLine($"Количество цифр в числе {userNumber} = {GetNumber(userNumber)}"); // выводим информацию пользователю и вызываем метод