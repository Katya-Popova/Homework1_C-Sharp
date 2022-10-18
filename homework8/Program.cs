// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.

void Zadacha54()
{
    Console.WriteLine("Задача 54");
    Random random = new Random();
    int rows = random.Next(3, 5);
    int colums = random.Next(3, 5);
    int[,] numbers = new int[rows, colums];
    FillArray(numbers);
    PrintArray(numbers);
    SortToLower(numbers);

    Console.WriteLine(" ");
    PrintArray(numbers);
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
            numbers[i, j] = random.Next(1, 10);
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
void SortToLower(int[,] numbers)
{
    for (int i = 0; i < numbers.GetLength(0); i++)
    {
        for (int j = 0; j < numbers.GetLength(1); j++)
        {
            for (int k = 0; k < numbers.GetLength(1) - 1; k++)
            {
                if (numbers[i, k] < numbers[i, k + 1])
                {
                    int temp = numbers[i, k + 1];
                    numbers[i, k + 1] = numbers[i, k];
                    numbers[i, k] = temp;
                }
            }
        }
    }
}

//Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
Zadacha54();
 Console.WriteLine(" ");

void Zadacha56()
{
    // Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
    int rows = 4;
    int colums = 5;

    int[,] numbers = new int[rows, colums];
    FillArray(numbers);
    PrintArray(numbers);
    int sumMin = SumInRow(numbers, 0);
    int indexMin = 0;
    
    
    for (int i = 1; i < rows; i++)
    {
       int sum=SumInRow(numbers, i);
       
        if (sum < sumMin)
        {
            sumMin = sum;
            indexMin = i;
        }
    }
        Console.WriteLine();
        Console.WriteLine($"Минимальная сумма равна {sumMin} и находится в строке {indexMin+1}");

    
}
Console.WriteLine(" Задача 56");
int SumInRow(int[,]numbers,int i)
{
    int colums=numbers.GetLength(1);
    int sum = 0;
        for (int j = 0; j < colums; j++)
        {
            sum += numbers[i, j];
        }
        Console.WriteLine($"Сумма {i + 1} строки равна {sum}");
        return sum;
}

void PrintArray2(int[,] numbers)
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

Zadacha56();
 Console.WriteLine(" ");

//Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
void Zadacha58()
{
Console.WriteLine("Задача 58");
int InputInt(string output)
{
    Console.Write(output);
    return int.Parse(Console.ReadLine());
}

void FillArrayRandomNumbers(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 5); //Для увеличения размера чисел в матрицах поменять число 5 на большее
        }
    }
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.Write("[ ");
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.Write("]");
        Console.WriteLine("");
    }
}

int size = InputInt("размерность матриц: ");
int[,] matrixA = new int[size, size];
int[,] matrixB = new int[size, size];
FillArrayRandomNumbers(matrixA);
FillArrayRandomNumbers(matrixB);
int[,] matrixC = new int[size, size];

for (int i = 0; i < size; i++)
{
    for (int j = 0; j < size; j++)
    {
        for (int k = 0; k < size; k++)
        {
            matrixC[i, j] = matrixC[i, j] + (matrixA[i, k] * matrixB[k, j]);
        }
    }
}
Console.WriteLine("Матрица - А");
PrintArray(matrixA);
Console.WriteLine();
Console.WriteLine("Матрица - В");
PrintArray(matrixB);
Console.WriteLine();
Console.WriteLine("Произведение матриц А*В");
PrintArray(matrixC);
}


Zadacha58();

void Zadacha60()
{
int deep1 = InputInt("Введите размерность 1: ");
int deep2 = InputInt("Введите размерность 2: ");
int deep3 = InputInt("Введите размерность 3: ");
int countNums = 89;

if (deep1 * deep2 * deep3 > countNums)
{
    Console.Write("Массив слишком большой");
    return;
}

int[,,] resultNums = Create3DMassive(deep1, deep2, deep3);

for (int i = 0; i < resultNums.GetLength(0); i++)
{
    for (int j = 0; j < resultNums.GetLength(1); j++)
    {
        for (int k = 0; k < resultNums.GetLength(2); k++)
        {
            Console.WriteLine($"[{i},{j},{k}] - {resultNums[i, j, k]}");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}


int[,,] Create3DMassive(int size1, int size2, int size3)
{
    int[,,] array = new int[size1, size2, size3];
    int[] values = new int[countNums];
    int num
     = 10;
    for (int i = 0; i < values.Length; i++)
        values[i] = num
        ++;

    for (int i = 0; i < values.Length; i++)
    {
        int randomInd = new Random().Next(0, values.Length);
        int temp = values[i];
        values[i] = values[randomInd];
        values[randomInd] = temp;
    }

    int valueIndex = 0;

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                array[i, j, k] = values[valueIndex++];
            }
        }
    }
    return array;
}


int InputInt(string output)
{
    Console.Write(output);
    return int.Parse(Console.ReadLine());
}
}
Zadacha60();