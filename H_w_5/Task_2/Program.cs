// Задача 50. Напишите программу, которая на вход принимает позиции элемента
// в двумерном массиве, и возвращает значение этого элемента или же указание, 
// что такого элемента нет.

// Например, задан массив:

// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

// 17 -> такого числа в массиве нет

void FillMatrixWithRandomNumbers(int[,] matrix)
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

int Element(int[,] matrix)
{
  System.Console.Write("Введите элемент: ");
  int el = Convert.ToInt32(Console.ReadLine());
  bool isOk = false;

  for (int i = 0; i < matrix.GetLength(0); i++)
  {
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
      if (el == matrix[i, j])
      {
        isOk = true;
        break;
      }
    }
  }
  if (isOk)
    {
      System.Console.WriteLine($"Элемент {el} найден");
    }
  else
    {
      System.Console.WriteLine($"Элемента {el} в массиве нет");
    }
  return el;
}

System.Console.Write("Введите количество строк массива: ");
int m = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите количество столбцов массива: ");
int n = Convert.ToInt32(Console.ReadLine());

int[,] matrix = new int[m, n];

FillMatrixWithRandomNumbers(matrix);
PrintMatrix(matrix);
Element(matrix);