void Zadacha41()
{
Console.WriteLine("Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.");

// 0, 7, 8, -2, -2-> 2

// 1, -7, 567, 89, 223-> 3

int size = 5;
int[] numbers = new int[size];
FillArray(numbers);
PrintArray(numbers);
int courent = 0;
for (int i = 0; i < numbers.Length; i++)
{
    if (numbers[i] > 0)
    courent++;
}
Console.WriteLine($"Чисел больше 0: {courent}");
}

void FillArray(int[] numbers)
{
    for (int i = 0; i < numbers.Length; i++)
    {
        numbers[i] = Convert.ToInt32(Console.ReadLine());
    }
}

void PrintArray(int[] numbers)
{
    Console.WriteLine("Вывод массива:");
    for (int i = 0; i < numbers.Length; i++)
    {
        Console.Write(numbers[i] + " ");
    }
    Console.WriteLine();


}

Zadacha41();

// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9-> (-0, 5; -0,5)