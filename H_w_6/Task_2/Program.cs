// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, 
// которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки 
// с наименьшей суммой элементов: 1 строка

void fillMatrix(int[,] matrix)
{
  Random rnd = new Random();
  for (int i = 0; i < matrix.GetLength(0); i++)
  {
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
      matrix[i, j] = rnd.Next(0, 10);
    }
  }
}

void printMatrix(int[,] matrix)
{
  for (int i = 0; i < matrix.GetLength(0); i++)
  {
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
      Console.Write($"{matrix[i, j]}" + "\t");
    }
    System.Console.WriteLine();
  }
}

void smallestSumRow(int[,] matrix)
{
  int minRow = 0;
  int sumRow = 0;
  int numRow = 0;

  for (int j = 0; j < matrix.GetLength(1); j++)
  {
    minRow =+ matrix[0, j];
  }

  for (int i = 0; i < matrix.GetLength(0); i++)
  {
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
      sumRow = +matrix[i, j];
      if (sumRow < minRow)
      {
        minRow = sumRow;
        numRow = i;
      }
    }
    sumRow = 0;
  }
  
  System.Console.WriteLine($"В строке [{numRow + 1}] сумма элементов наименьшая");
}

System.Console.Write("Введите количество строк: ");
int m = Convert.ToInt32(Console.ReadLine());

System.Console.Write("Введите количество столбцов: ");
int n = Convert.ToInt32(Console.ReadLine());

int[,] matrix = new int[m,n];

fillMatrix(matrix);
printMatrix(matrix);
smallestSumRow(matrix);