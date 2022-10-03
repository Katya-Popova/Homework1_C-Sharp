void Zadacha25()
{
//Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B
Console.WriteLine("Введите числа: ");
int number1 = Convert.ToInt32(Console.ReadLine());
int number2 = Convert.ToInt32(Console.ReadLine());
int count = 1;
int resultat = number1;
while (count < number2)
{
    resultat = (resultat * number1);
    count++;
}
Console.WriteLine("Число " + number1 + " в степени " + " равна" + resultat);
}

void Zadacha27()
{
//Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int resultat = 0;
int number1 = number;
while (number1 > 0)
{
    int number2 = number1 % 10;
    number1 = number1 /10;
    resultat = resultat+number2;
}
Console.WriteLine("Сумма цифр в числе: " + resultat);
}

void Zadacha29()
{
//Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
void FillArray(int[] arr) // метод заполнения массива
{
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(1,100);
    }
}

void PrintArray(int[] arr) // метод вывода массива
{
    Console.Write("["); // специально на печать "[" перед массивом, чтобы массив вывелся на консоль, как в примере
    for (int i = 0; i < arr.Length - 1; i++) // специально без последного (восьмого) элемента массива
    {
        Console.Write(arr[i] + ", ");
        if (i == arr.Length - 2) // специально для вывода последного (восьмого) элемента массива
        {
            Console.Write(arr[arr.Length - 1] + "]"); // специально на печать "]" после массива
        }
    }
}

int[] array = new int[8];
FillArray(array);
PrintArray(array);

}
Zadacha29();

