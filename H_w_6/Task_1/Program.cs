// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит 
// по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

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

void DecreasingElements(int[,] matrix, int[,] newmatrix)
{
  int orig = 0;
  for (int i = 0; i < newmatrix.GetLength(0); i++)
  {
    for (int j = 0; j < newmatrix.GetLength(1); j++)
    {
      orig = matrix[i, j];
      if (matrix[i, j] < matrix[i, j + 1])
      {
        matrix[i, j] = matrix[i, j + 1];
      }
      newmatrix[i, j] = matrix[i, j+1];
      matrix[i, j+1] = orig;
    }
  }
}

System.Console.Write("Введите количество строк: ");
int m = Convert.ToInt32(Console.ReadLine());

System.Console.Write("Введите количество столбцов: ");
int n = Convert.ToInt32(Console.ReadLine());

int[,] matrix = new int[m, n];
int[,] newmatrix = new int[m, n];

FillMatrix(matrix);
PrintMatrix(matrix);
System.Console.WriteLine();
DecreasingElements(matrix, newmatrix);
PrintMatrix(newmatrix);