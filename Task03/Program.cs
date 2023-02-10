//Напишите программу, которая будет выдавать название дня недели по заданному номеру.
//	3 -> Среда 
//5 -> Пятница
// С приметением массива

string[] week = new string[7] { "Понедельник", "Вторник", "Среда", "Четверг", "Пятница", "Суббота", "Воскресенье" };
while (true)
{
    Console.WriteLine("Введите число от 1 до 7");
    int userNumber = Convert.ToInt32(Console.ReadLine());
    if (userNumber < 1 || userNumber > 7)
    {
        Console.WriteLine("Вы ввели не правильное число попробуйте еще раз");
    }
    else
    {
        int weekIndex = userNumber - 1;
        Console.WriteLine($"Вы ввели число {userNumber} это день недели {week[weekIndex]}");
        break;
    }
}