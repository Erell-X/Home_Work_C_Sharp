// Задача 64: Задайте значение N. Напишите программу, которая выведет 
// все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

string seriesOfNumbers(int i, int N)
{
  if (i <= N) return seriesOfNumbers(i+1, N) + $"{i} ";
  else return String.Empty;
}
System.Console.WriteLine(seriesOfNumbers(1, 10));