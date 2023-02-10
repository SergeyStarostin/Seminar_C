//Напишите программу, которая на вход принимает число и выдает
// его квадрат (число умноженное на себя)

Console.WriteLine("Введите число > "); //Ввод в консоль приглашения для ввода
String inputValue;                      //Объявление переменной, в которую будем сохранять
inputValue = Console.ReadLine(); //Присвоение переменной из консоли
int value = Convert.ToInt32(inputValue);

int square = value * value; // Вычисление квадрата

//вывод на экран

System.Console.WriteLine("Квадрат числа " + value +  " равен " + square);
System.Console.WriteLine($"Квадрат числа {value} равен  {square}");