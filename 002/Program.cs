// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

int numberA = -9;
int numberB = -3;
if (numberA > numberB)
{
    Console.WriteLine ("Наибольшее число " + numberA);
    Console.WriteLine ("Наименьшее число " + numberB);
}
else
{
    Console.WriteLine ("Наибольшее число " + numberB);
    Console.WriteLine ("Наименьшее число " + numberA);
}
