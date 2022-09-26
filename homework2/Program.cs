void Zadacha10()
{
    Console.Write ("Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.");

    Console.Write("Введите трехзачное число: ");
    int number = Convert.ToInt32(Console.ReadLine());
    int number1 = number / 10 % 10;
    Console.WriteLine("Вторая цифра числа: " + number1);
}

void Zadacha13()
{
Console.Write ("Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.");
Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number < 100)
{
    Console.WriteLine("третьей цифры нет");
}
else
{
while (number > 999)
    {
    number = number / 10;
    }
    Console.WriteLine(number%10);
}
}  

void Zadacha15()
{
Console.Write ("Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.");

Console.Write("Введите число: цифру, обозначающую день недели (от 1 до 7)");
int number = Convert.ToInt32(Console.ReadLine());
if (number == 6 || number == 7 )
{
    Console.WriteLine("ДА");
}
else
{
    Console.WriteLine("НЕТ");
}
}

Zadacha10();

Zadacha13();       

Zadacha15();
  