// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

int N, F;
  
  F = 1;
  
  Console.Clear();
  Console.WriteLine("Введите число:");
  
  N = Convert.ToInt32(Console.ReadLine());

  Console.WriteLine();
  Console.Write("Ряд чётных чисел: ");

  while (F <= N)
  {
    
    if (F % 2 == 0)
    {
    Console.Write($"{F}, ");
    }
  
    F++;
    
  }
