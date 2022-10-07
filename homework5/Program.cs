//  Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
void Zadacha34()
{
    Console.WriteLine("Задача 34.Задайте массив заполненный случайными положительными трёхзначными числами.");
    Console.WriteLine("Напишите программу, которая покажет количество чётных чисел в массиве.");
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
    Console.WriteLine("Задача 36: Задайте одномерный массив, заполненный случайными числами.");
    Console.WriteLine("Найдите сумму элементов, стоящих на нечётных позициях.");
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
    Console.WriteLine("Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.");
    int size = 8;
    double [] numbers = new double [size];
    FillArray2(numbers, -9, 10); //  задали массив
    PrintArray2(numbers);        // вывели массив
    Minnumber(numbers);
    Maxnumber(numbers);
    Console.WriteLine("Максимальное число в массиве: " + Maxnumber(numbers));
    Console.WriteLine("Минимальное число в массиве: " + Minnumber(numbers));
    Console.WriteLine("Разница между максимальным и минимальным элементов массива: " + ( Maxnumber(numbers) -Minnumber(numbers)));
}

double Minnumber(double[] numbers)
{
    double min = numbers[0];
        for (int i = 0; i < numbers.Length; i++)
        {
            if (numbers[i] < min)
            min = numbers[i];
    }
    return min;
}
double Maxnumber(double[] numbers)
{
    double max = numbers[0];
        for (int i = 0; i < numbers.Length; i++)
        {
            if (numbers[i] > max)
            max = numbers[i];
    }
    return max;
}

void FillArray2(double[] numbers, int minValue=0, int maxValue=9)
{
    Random random = new Random();
    maxValue++;
    int size = numbers.Length;

    for (int i = 0; i < size; i++)
    {
        numbers[i] = Math.Round(random.NextDouble()*20-10, 2);
    }
}

void PrintArray2(double[] numbers)
{
    Console.WriteLine("Вывод массива:");
    for (int i = 0; i < numbers.Length; i++)
    {
        Console.Write(numbers[i] + " ");
    }
    Console.WriteLine();

}
Zadacha34();
Console.WriteLine(" ");

Zadacha36();
Console.WriteLine(" ");

Zadacha38();