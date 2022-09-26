void Zadacha10()
{
    // Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
    Console.Write("Введите число: ");
    int number = Convert.ToInt32(Console.ReadLine());
    int number1 = number / 10 % 10;
    Console.WriteLine("Вторая цифра числа: " + number1);
}

void Zadacha13()
{
// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
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

          

  