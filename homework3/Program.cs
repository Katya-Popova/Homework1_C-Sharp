void Zadacha19()
{
 // Задача 19 Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

Console.WriteLine("Введите пятизнаное число: ");
int number = Convert.ToInt32(Console.ReadLine());
int number1 = number /10000;
int number2 = number / 1000 % 10;
int number4 = number / 10 % 10;
int number5 = number % 10;
if (number1 == number5 && number2 == number4)
{
    Console.WriteLine(number + " Число являетслся палиндромом");
}
else
{
    Console.WriteLine(number + " Число не являетслся палиндромом");
}  
}     


void Zadacha21()
{// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

//A (3,6,8); B (2,1,-7), -> 15.84
//A (7,-5, 0); B (1,-1,9) -> 11.53
int x1 = Convert.ToInt32(Console.ReadLine());
int y1 = Convert.ToInt32(Console.ReadLine());
int z1 = Convert.ToInt32(Console.ReadLine());
int x2 = Convert.ToInt32(Console.ReadLine());
int y2 = Convert.ToInt32(Console.ReadLine());
int z2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"A ({x1}, {y1}, {z1})");
Console.WriteLine($"B ({x2}, {y2}, {z2})");
double dist = Math.Sqrt(Math.Pow((x2-x1),2) + Math.Pow((y2-y1),2) +Math.Pow((z2-z1),2));
Console.WriteLine("Расстояние между точками А и В составляет "+ dist);
}

void Zadacha23()
{
//Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

//3 -> 1, 8, 27
//5 -> 1, 8, 27, 64, 125
Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int count = 1;
while (count <= number)
{
    Console.WriteLine(count*count*count);
    count++;
}
}

Zadacha19();
Zadacha21();
Zadacha23();