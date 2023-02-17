// Напишите программу, которая по заданному номеру четверти, 
// показывает диапазон возможных координат точек в этой четверти (x и y)
// X > 0, y < 0

int InputInt(string message)                                //название метода
{
    System.Console.Write($"{message}> ");                 //вывод приглашения ко вводу
    int value;                                            // инициализация переменной
    if (int.TryParse(Console.ReadLine(), out value))      //проверка условия корректности ввода + ввод со строки
    {                                                      //если конвертация строки прошла правильно, то мы попадаем в ветку, 
        return value;                                      //которая находится в скобках после наименования функции. Если да
    }                                                       //то выдает первое значение (ввод со строки). Нет - второе (out )
    System.Console.WriteLine("Вы ввели не число");
    Environment.Exit(1);                                  //если TryParse не сработало, выходим из программы (Exit) с кодом 1
    return 0;                                             //нужна для компиляции.
}

bool ValidateQuorter(int quorter)
{
    if (quorter < 1 || quorter > 4)
    {
        System.Console.WriteLine("Вы задали неверные значения");
        return false;
    }
    return true;
}

(int, int) GetCoords(int quorter)       //Кортеж - набор переменных
{
    switch (quorter)                    //выбор четверти
    {
        case 1:                        //что делаем при определенном значении переменной quorter. Вариант при quorter = 1
            return (1, 1);            //возвращает эти два числа при выборе 1
            break;                    //пишется для выхода из switch. Если был до этого return  - можно не писать

        case 2:
            return (-1, 1);           
            break;
        case 3:
            return (-1, -1);
            break;
        default:                     //вариация else (если не выбрано любое другое значение)
            return (1, -1);
            break;
    }
}

int quorter = InputInt ("Введите номер четверти Декартовой системы координат: ");    //вызываем функцию ввода с переменной quorter
if (ValidateQuorter(quorter))                                                        //проверка правильности ввода (что это четверть)
{
    (int x, int y) = GetCoords(quorter);                                             //получение пары координат [x, y] в зависимости от введенной четверти
    System.Console.WriteLine($"Возможные координаты в четверти {quorter}: {x}, {y}");  //вывод результата на экран
}