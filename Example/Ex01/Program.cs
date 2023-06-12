// Задача 53: Задайте двумерный массив. Напишите программу, которая 
// поменяет местами первую и последнюю строку массива.

void FillMatrix(int[,] matrix)
{
  Random rnd = new Random();
  for (int i = 0; i < matrix.GetLength(0); i++)
  {
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
      matrix[i, j] = rnd.Next(0, 11);
    }
  }
}

void PrintMatrix(int[,] matrix)
{
  for (int i = 0; i < matrix.GetLength(0); i++)
  {
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
      System.Console.Write($"{matrix[i, j]}" + "\t");
    }
    System.Console.WriteLine();
  }
}

void ExchangeOfLines(int[,] matrix)
{
  int orig = 0;
  for (int j = 0; j < matrix.GetLength(1); j++)
  {
    orig = matrix[0, j];
    matrix[0, j] = matrix[matrix.GetLength(0) - 1, j];
    matrix[matrix.GetLength(0) - 1, j] = orig;
  }
}

System.Console.Write("Введите количество строк: ");
int m = Convert.ToInt32(Console.ReadLine());

System.Console.Write("Введите количество столбцов: ");
int n = Convert.ToInt32(Console.ReadLine());

int[,] matrix = new int[m, n];

FillMatrix(matrix);
PrintMatrix(matrix);
System.Console.WriteLine();
ExchangeOfLines(matrix);
PrintMatrix(matrix);