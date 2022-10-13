// Задача 47.Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

void Zadacha47()
{
Random random = new Random();
int n = random.Next(3,6);
int m = random.Next(3,6);
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
//Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
//и возвращает значение этого элемента или же указание, что такого элемента нет.
void Zadacha50()
{
int[,] numbers = new int[x,y];
FillArray(x,y);
PrintArray(x,y);

void FillArray(int[x,y])
for (int i = 0; i < x; i++)
{
    for (int j = 0; j < y; j++)
    {
        numbers[i,j] = random.Next;
    }
}

void PrintArray(int[x,y])
for (int i = 0; i < x; i++)
{
    for (int j = 0; j < y; j++)
    {
        Console.Write( numbers[i,j]+ "\t");
    }
Console.WriteLine();
}
}
// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
Zadacha50();
