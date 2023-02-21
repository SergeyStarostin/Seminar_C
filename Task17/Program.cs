// Задача 3: Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке.
// [1,0,1,1,0,1,0,0]

int[] FillArray(int size)  // метод заполнения массива, параметр метода является размером массива
{
    int[] myArray = new int[size]; // объявление и иницифлизация массива
    for (int i = 0; i < myArray.Length; i++) // цикл перебора массива
    {
        myArray[i] = new Random().Next(0, 2); // кладем в каждый элемет массива рандомное число от 0 до 1
    }
    return myArray; //  возвращаем массив
}

void PrintArray(int[] array) // метод вывода массива
{
    for (int i = 0; i < array.Length; i++) // цикл перебора массива
    {
        System.Threading.Thread.Sleep(50); //задержка выполнения ввода на экран(можно не делать)
        System.Console.Write($"{array[i]}, "); // на каждой итерации цикла мы будем выводить элемент массива
    }
    System.Console.WriteLine(); // делается для того чтобы отступить одну строку
}

int InputSizeArray(string msg) // метод ввода числа
{
    System.Console.WriteLine($"{msg}");
    return Convert.ToInt32(Console.ReadLine());
}

int sizeArray = InputSizeArray("Введите размер массива"); // вводим количество элементов массива и кладем в переменную
int[] myArray = FillArray(sizeArray); // заполняем массив рандомным числом от 0 до 1
PrintArray(myArray); // выводим массив