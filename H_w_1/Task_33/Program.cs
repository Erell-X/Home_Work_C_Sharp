﻿// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

4 -> да
-3 -> нет
7 -> нет

Console.Clear();

int Num;

Console.WriteLine("Введите число:");
Num = Convert.ToInt32(Console.ReadLine());

if (Num % 2 == 0)
{
 Console.WriteLine($"Число является чётным");
}

else
{
 Console.WriteLine($"Число является нечётным");
}