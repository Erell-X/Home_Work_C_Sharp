// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт 
// сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int sumNumbers(int M, int N)
{
  if (M <= N) return sumNumbers(M + 1, N) + M;
  else return 0;
}

System.Console.WriteLine(sumNumbers(1, 15));