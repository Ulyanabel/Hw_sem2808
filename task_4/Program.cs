﻿// Задача 4. Максимальное из трех чисел.
Console.WriteLine("Введите три числа: ");
int numberA = Convert.ToInt32(Console.ReadLine());
int numberB = Convert.ToInt32(Console.ReadLine());
int numberC = Convert.ToInt32(Console.ReadLine());
int max = numberA;
if (numberB > max)
{
    max = numberB;
}
if (numberC > max)
{
    max = numberC;
}
Console.WriteLine("Максимальное число из трех: " + max);
