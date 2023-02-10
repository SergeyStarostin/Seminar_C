//Напишите программу, которая будет выдавать название дня недели по заданному номеру.
//	3 -> Среда 
//5 -> Пятница

System.Console.WriteLine("введите день недели");
int weekday = Convert.ToInt32(Console.ReadLine());
if (weekday==1)
{
    System.Console.WriteLine ("понедельник");
}
if (weekday==2)
{
    System.Console.WriteLine ("вторник");
}
if (weekday==3)
{
    System.Console.WriteLine ("среда");
    }
if (weekday==4)
{
    System.Console.WriteLine ("четверг");
}
if (weekday==5)
{
    System.Console.WriteLine ("пятница");
}
if (weekday==6)
{
    System.Console.WriteLine ("суббота");
}
if (weekday==7)
{
    System.Console.WriteLine ("воскресенье");
}
if (weekday < 1 || weekday > 7)
{
 System.Console.WriteLine ("не правильно задан номер недели");   
}

