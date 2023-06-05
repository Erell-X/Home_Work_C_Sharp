// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых,
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

double[] Array (int size)
{
  double[] array = new double[size];

  for (int i = 0; i < array.Length; i++)
  {
    switch(size)
    {
      case 1:
      {
          Console.WriteLine("Введите b1");
          int b1 = Convert.ToInt32(Console.ReadLine());
          Console.WriteLine();
          break;
      }
      case 2:
      {
          Console.WriteLine("Введите k1");
          int b1 = Convert.ToInt32(Console.ReadLine());
          Console.WriteLine();
          break;
      }
      case 3:
      {
          Console.WriteLine("Введите b2");
          int b1 = Convert.ToInt32(Console.ReadLine());
          Console.WriteLine();
          break;
      }
      case 4:
      {
          Console.WriteLine("Введите k2");
          int b1 = Convert.ToInt32(Console.ReadLine());
          Console.WriteLine();
          break;
      }
    }
  return array;
  }
}