﻿//Напишите программу, которая принимает на вход три
// числа и выдаёт максимальное из этих чисел.
Console.WriteLine("Введите первое число: ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите первое число: ");
int numberB = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите первое число: ");
int numberC = Convert.ToInt32(Console.ReadLine());
int max = numberA;

if (numberB > max) max = numberB;
if (numberC > max) max = numberC;

Console.Write("max = ");
Console.Write(max);