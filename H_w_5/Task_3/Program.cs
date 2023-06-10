// Задача 52. Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

void FillMatrix(int[,] matrix)
{
  Random rnd = new Random();
  for (int i = 0; i < matrix.GetLength(0); i++)
  {
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
      matrix[i, j] = rnd.Next(0, 101);
    }
  }
}

void PrintMatrix(int[,] matrix)
{
  for (int i = 0; i < matrix.GetLength(0); i++)
  {
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
      System.Console.Write($"{matrix[i, j]} " + "\t");
    }
    System.Console.WriteLine();
  }
}

double Average(int[,] matrix)
{
  double Av = 0;

  for (int j = 0; j < matrix.GetLength(1); j++)
  {
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
      Av += matrix[i, j];
    }
    Console.Write($"{Av=Math.Round(Av / matrix.GetLength(0),1)}; ");
    Av = 0;
  }
  Console.WriteLine();
  return Av;
}

System.Console.Write("Введите количество строк массива: ");
int m = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите количество столбцов массива: ");
int n = Convert.ToInt32(Console.ReadLine());

int[,] matrix = new int[m, n];

FillMatrix(matrix);
PrintMatrix(matrix);
Average(matrix);