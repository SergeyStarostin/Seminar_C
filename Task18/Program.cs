// Задача *: Напишите программу, которая из массива случайных чисел. 
// Ищет второй максимум (число меньше максимального элемента, но больше всех остальных). Постарайтесь сделать одним циклом 
// [1, 3, 5, 6, 6, 4] -> 5

int size = Prompt("Введите размер массива: ");
int [] newArray = CreationArray(size);
FillArray(newArray); // Заполнение массива
PrintArray(newArray); // Вывод заполненного двумерного массива

MaxSearchTwoElementArray(newArray); // Сортировка массива по убыванию
Console.Write($"Второй максимальный элемент массива = {MaxSearchTwoElementArray(newArray)}");

int Prompt (string message) // Метод считывания чисел с консоли
{
    Console.Write(message);
    int value;
    if (int.TryParse(Console.ReadLine(), out value)) // проверка условия корректности ввода
    {
        return value;
    }
    Console.WriteLine("Вы ввели не число");
    Environment.Exit(1);
    return 0;
}

int[] CreationArray(int size) // Метод создания массива
{
    int[] array = new int[size];
    return array;
}

void FillArray(int[] array) // Метод заполнения массива
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        array[i] = Convert.ToInt32(new Random().Next(-100, 100));
    }
}

int MaxSearchTwoElementArray(int[] array) // Метод нахождения второго максимального элемента массива
{
    int maxValue = array[0], maxValueTwo = array[1];
    if (maxValueTwo > maxValue)
    {
        maxValue = maxValueTwo;
        maxValueTwo = array[0];
    }
    for (int i = 2; i < array.Length; i++)
    {
        if (maxValue < array[i])
        {
            maxValueTwo = maxValue;
            maxValue = array[i];
        }
        if (maxValueTwo < array[i] && array[i] != maxValue)
        {
            maxValueTwo = array[i];
        }
    }
    return maxValueTwo;
}

void PrintArray(int[] array) // Метод вывода массива на экран 
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]}\t");
    }
    Console.WriteLine("]");
}