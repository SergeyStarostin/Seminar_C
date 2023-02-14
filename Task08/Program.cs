// Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23.
// 14 -> нет 
// 46 -> нет 
// 161 -> да

int Prompt(string msg)
{
    System.Console.Write($"{msg} >");
    return Convert.ToInt32(Console.ReadLine());
}
int num = Prompt("Введите число ");
int divider1 = Prompt("Введите делитель 1 ");
int divider2 = Prompt("Введите делитель 2 ");

if (num % divider1 == 0 && num % divider2 == 0)
{
    System.Console.WriteLine($"Число {num} кратно одновременно {divider1} и {divider2}");
}
else
{
    System.Console.WriteLine($"Число {num} не кратно одновременно {divider1} и {divider2}");
}