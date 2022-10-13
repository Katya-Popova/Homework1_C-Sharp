// Задача 47.Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

void Zadacha47()
{   Console.WriteLine("Задача 47");
    Random random = new Random();
    int n = random.Next(3, 6);
    int m = random.Next(3, 6);
    double[,] numbers = new double[n, m];
    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < m; j++)
        {
            numbers[i, j] = random.NextDouble() * 10;
        }
    }
    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < m; j++)
        {
            Console.Write(numbers[i, j] + "\t");
        }
        Console.WriteLine();
    }
}
Zadacha47();
Console.WriteLine(" ");

//Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
//и возвращает значение этого элемента или же указание, что такого элемента нет.
void Zadacha50()
{
    Console.WriteLine("Задача 50");
    Random random = new Random();
    int rows = random.Next(3, 6);
    int colums = random.Next(3, 6);
    int[,] numbers = new int[rows, colums];
    FillArray(numbers);
    PrintArray(numbers);
    Console.WriteLine("Введите строку:");
    int rows2 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите колонку:");
    int colums2 = Convert.ToInt32(Console.ReadLine());
    if (rows2 < 0 | rows2 > numbers.GetLength(0) - 1 | colums2 < 0 | colums2 > numbers.GetLength(1) - 1)
    {
        Console.WriteLine("Элемент не существует");
    }
    else
    {
        Console.WriteLine($"Значение элемента равно {numbers[rows2, colums2]}");
    }
}


void FillArray(int[,] numbers)
{
    Random random = new Random();
    int rows = numbers.GetLength(0);
    int colums = numbers.GetLength(1);
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < colums; j++)
        {
            numbers[i, j] = random.Next(-10, 10);
        }
    }
}

void PrintArray(int[,] numbers)
{
    int rows = numbers.GetLength(0);
    int colums = numbers.GetLength(1);
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < colums; j++)
        {
        
            Console.Write(numbers[i, j] + "\t");
        }
        Console.WriteLine();
    }
}

Zadacha50();
Console.WriteLine(" ");

// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
void Zadacha52()
{
    Console.WriteLine("Задача 52");
    Random random = new Random();
    int rows = random.Next(3, 6);
    int colums = random.Next(3, 6);
    int[,] numbers = new int[rows, colums];
    double summ = 0;
    FillArray(numbers);
    PrintArray(numbers);
    for (int j = 0; j < colums; j++)
    {
    for (int i = 0; i < rows; i++)
    {
         summ = summ + numbers[i, j];
                 
    }
        Console.WriteLine($"среднее арифметическое в {j} столбце {summ/rows}"); 
    }

    }
        

Zadacha52();