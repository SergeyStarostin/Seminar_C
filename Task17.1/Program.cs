// Задача 3: Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке.
// [1,0,1,1,0,1,0,0]

void FillArray(int[]massiv)
{
    Random rnd = new Random();
    for (int i =0; i < massiv.Length / 2; i++)//делим на 2 для того чтобы уменьшить колличество едениц
    {
        massiv [rnd.Next(0, massiv.Length)] = 1;
    }
}
void printArray(int [] massiv)
{
    System.Console.Write(massiv[0]);
    for(int i = 1; i < massiv.Length; i++)
    {
        System.Console.Write(", " + massiv[i]);
    }
}

int InputSizeArray(string msg) // метод ввода числа
{
    System.Console.Write($"{msg}");
    return Convert.ToInt32(Console.ReadLine());
}
int SizeArray = InputSizeArray("Введите размер массива = ");
int[] Array = new int[SizeArray];
FillArray (Array);
printArray (Array);