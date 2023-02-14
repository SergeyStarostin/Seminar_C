// Напишите программу, которая выводит случайное число из отрезка [10, 9999] и показывает наибольшую цифру числа.
// 7812 -> 8 
// 1213-> 3 
// 845 -> 8

int number = new Random().Next(10, 10000); // от 10-9999
System.Console.WriteLine(number);
int max = 0;

while (number > 0)
{
    if (max < number % 10)
    {
        max = number % 10;
    }
    number /=10; //number = number / 10;
}
Console.WriteLine($"Наибольшая цифра равна {max}");