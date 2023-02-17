// Напишите программу, которая принимает на вход координаты 
// точки (X и Y), причём X ≠ 0 или Y ≠ 0 и выдаёт номер четверти плоскости, 
// в которой находится эта точка.

int InputInt(string message)                //Название метода
{
    System.Console.Write($"{message}> ");   //Вывод приглашения ко вводу
    int value;                              //Инициализация переменной
    if (int.TryParse(Console.ReadLine(), out int value))//Проверка условия корректности ввода+ввод со строки
    //Если конвертация строки прошла правильно, то попадаем в ветку, которая находится в скобках
    //после наименования функции. Если да - то выдает первое значение(ввод со строки).
    //Нет - второе (out)
    {
        return value;
    }
    System.Console.WriteLine("Вы ввели не число");
    Environment.Exit(1); //Если TryParse не сработало, выходим из программы (Exit) с кодом 1
    return 0;            //Нужна для компиляции.
}
bool ValidateCoords(int x, int y)
{
    if (x == 0 || y == 0)
    {
        System.Console.WriteLine("Одна из координат назодится на оси");
        return false;
    }

    return true;
}
int GetQuorter(int x, int y)
{
    if (x > 0 && y > 0)
    {
        return 1;
    }
    if (x < 0 && y > 0)
    {
        return 2;
    }
    if (x < 0 && y < 0)
    {
        return 3;
    }
    return 4;
}
int x = InputInt("Введите X");
int y = InputInt("Введите Y");
if (ValidateCoords(x, y))
{
    System.Console.WriteLine($"Координаты {x}, {y} находятся в четверти {GetQuorter(x, y)}");
}