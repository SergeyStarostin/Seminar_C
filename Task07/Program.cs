// Напишите программу, которая будет принимать на вход два числа и выводить, является ли второе число кратным первому. Если число 2 не кратно числу 1, то программа выводит остаток от деление.
// 34, 5 -> не кратно, остаток 4 
// 16, 4 -> кратно

int Prompt(string msg)
{
    System.Console.Write($"{msg} >");
    return Convert.ToInt32(Console.ReadLine());
}
int del = Prompt("Введите делитель > ");
int num = Prompt("Введите число > ");
int remains = num % del;
if (num % del == 0)
{
    System.Console.WriteLine($"{num} является кратным числу {del}");
}
else
{
    System.Console.WriteLine($"{num} не кратно {del}, остаток равен {remains}");
}

