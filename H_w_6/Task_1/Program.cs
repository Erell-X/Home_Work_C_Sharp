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

void fillMatrix(int[,] matrix)
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

void printMatrix(int[,] matrix)
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

void decreasingElements(int[,] matrix)
{
  for (int i = 0; i < matrix.GetLength(0); i++)
  {
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
      for (int r = 0; r < matrix.GetLength(1) - 1; r++)
      {
        if (matrix[i, r + 1] > matrix[i, r])
				{
  int temp = matrix[i, r];
  matrix[i, r] = matrix[i, r + 1];
  matrix[i, r + 1] = temp;
}
			}
		}
	}
}

Console.WriteLine("Введите количество строк: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите количество столбцов: ");
int n = Convert.ToInt32(Console.ReadLine());

int[,] matrix = new int[m, n];

fillMatrix(matrix);
printMatrix(matrix);
Console.WriteLine();
decreasingElements(matrix);
printMatrix(matrix);