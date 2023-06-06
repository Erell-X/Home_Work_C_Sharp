// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых,
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)


int[] Array(int size)
{
  int[] array = new int[size];

  for (int i = 0; i < array.Length; i++)
  {
    switch (i)
    {
      case 0:
        {
          Console.WriteLine("Введите коэффициент k1");
          int k1 = Convert.ToInt32(Console.ReadLine());
          array[i] = k1;
          break;
        }
      case 1:
        {
          Console.WriteLine("Введите коэффициент b1");
          int b1 = Convert.ToInt32(Console.ReadLine());
          array[i] = b1;
          break;
        }
      case 2:
        {
          Console.WriteLine("Введите коэффициент k2");
          int k2 = Convert.ToInt32(Console.ReadLine());
          array[i] = k2;
          break;
        }
      case 3:
        {
          Console.WriteLine("Введите коэффициент b2");
          int b2 = Convert.ToInt32(Console.ReadLine());
          array[i] = b2;
          break;
        }

    }
  }
  return array;
}

int size = 4;
int[] array = Array(size);
// Console.WriteLine(string.Join(", ", array));

double x = 0,
       y = 0;

int k1 = 0,
    b1 = 0,
    k2 = 0,
    b2 = 0;

for (int i = 0; i < array.Length; i++)
{
  if (i == 0) k1 = array[i];
  if (i == 1) b1 = array[i];
  if (i == 2) k2 = array[i];
  if (i == 3) b2 = array[i];
}

x = b2 - b1;
y = k1 - k2;

x = (x) / (y);
y = k1 * x + b1;

Console.WriteLine($"Координаты точки пересечения двух прямых: ({x}; {y})");
