// Задача 47.Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

void Zadacha46()
{
Random random = new Random();
int n = random.Next(4,8);
int m = random.Next(4,8);
double[,] numbers = new double[n,m];
for (int i = 0; i < n; i++)
{
    for (int j = 0; j < m; j++)
    {
        numbers[i,j] = random.NextDouble()*10;
    }
}
for (int i = 0; i < n; i++)
{
    for (int j = 0; j < m; j++)
    {
        Console.Write( numbers[i,j]+ "\t");
    }
Console.WriteLine();
}
}
//Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.


// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
Zadacha46();
