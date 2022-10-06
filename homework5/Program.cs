//  Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
void Zadacha34()
{
    int size = 8;
    int[] numbers = new int [size];
    FillArray(numbers, 100, 999);
    PrintArray(numbers);
    Console.WriteLine("Количество четных чисел в массиве: " + Counter(numbers));
}

int Counter(int[] numbers)
{
    int count = 0;
    for (int i = 0; i < numbers.Length; i++)
    {
        if (numbers[i] % 2 == 0)
            count++;
    }
    return count;
}
void FillArray(int[] numbers, int minValue=0, int maxValue=100)
{
    Random random = new Random();
    maxValue++;
    for (int i = 0; i < numbers.Length; i++)
    {
        numbers[i] = random.Next(minValue,maxValue);
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

void Zadacha36()
// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.


{
    int size = 8;
    int[] numbers = new int [size];
    FillArray(numbers, -10,10);
    PrintArray(numbers);
     Console.WriteLine("Сумма элементов, стоящих на нечётных позициях в массиве: " + Sum(numbers) );
}

int Sum(int[] numbers)
{
    int summa = 0;
    for (int i = 1; i < numbers.Length; i=i+2)
    {
       summa=summa + numbers[i];
    }
    return summa;
}
void Zadacha38()
//  Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
{

}