// Задача 2: Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.
// 4 -> 24 
// 5 -> 120

int Inputint(string prompt)
{
    System.Console.Write($"{prompt}  --> ");
    return Convert.ToInt32(Console.ReadLine());
}

int Factorial(int number)                 // метод нахождения факториала
{
    int result = 1;                       // в переменную кладем результат 
    for (int i = 1; i <= number; i++)     // цикл вычесление будет работать пока i счетчик не будет больше числа
    {
        result = result * i;             // вычесление факториала
    }
    return result;                      // возврат результата метода
}

int userNumber = Inputint("Введите число");  // вызов метода Inputint
System.Console.WriteLine($"Факториал числа {userNumber} = {Factorial(userNumber)}"); // вывод информации пользувателю о факториале числа