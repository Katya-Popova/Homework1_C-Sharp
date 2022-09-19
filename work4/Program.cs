// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

Console.WriteLine("Эта программа покажет наибольшее из 3-х чисел");
Console.Write("Введите первое число ");
int numberA = int.Parse(Console.ReadLine());

Console.Write("Введите второе число ");
int numberB = int.Parse(Console.ReadLine());

Console.Write("Введите третье число ");
int numberC = int.Parse(Console.ReadLine());

int numbermax = numberA;

if (numberA < numberB)
{
     int numbermax = numberB;
}

else if (numbermax < numberC)
{
    int numbermax = numberC;
}

Console.WriteLine("Максимальное число из этих чисел " + numbermax);
