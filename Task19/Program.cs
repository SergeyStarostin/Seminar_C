// Задача 1: Напишите программу, которая перевернёт одномерный массив 
//(последний элемент будет на первом месте, а первый - на последнем и т.д.)
// [1 2 3 4 5] -> [5 4 3 2 1]
// [6 7 3 6] -> [6 3 7 6]


int InputInt(string msg)
{
    Console.Write($"{msg} -> ");
    return Convert.ToInt32(Console.ReadLine());
}

int[] Array(int size) //функция объявление массива
{
    int[] array = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < size; i++)
    {
        array[i] = rnd.Next(0, 100);
    }
    return array;
}

void PrintArray(int[] array)
{
    foreach (int item in array)
    {
        System.Console.Write($"{item} ");
    }
    System.Console.WriteLine();
}

int[] Reverse(int[] array)
{
    for (int i = 0; i < array.Length / 2; i++)
    {
        Swap2(array, i, array.Length - 1 - i);
    }
    return array;
}

void Swap(int[] array, int i, int j) // вариант с помощью пузыря
{
    int temp = array[i];
    array[i] = array[j];
    array[j] = temp;
}

void Swap2(int[] array, int i, int j) //2й вариант с помощью кортежа
{
    (array[i], array[j]) = (array[j], array[i]);
}

int len = InputInt("Введите длину массива");
int[] array = Array(len);
PrintArray(array);
PrintArray(Reverse(array));