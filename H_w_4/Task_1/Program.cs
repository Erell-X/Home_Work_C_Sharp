// Задача 41: Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2

// 1, -7, 567, 89, 223-> 4

int[] Array(int N)
{
  int[] arr = new int[N];

  for (int i = 0; i < arr.Length; i++)
  {
    System.Console.WriteLine($"Введите Число{i + 1}: ");
    N = Convert.ToInt32(Console.ReadLine());
    arr[i] = N;
  }
  return arr;
}

System.Console.WriteLine("Введите размер массива: ");
int M = Convert.ToInt32(Console.ReadLine());
int[] array = Array(M);
Console.WriteLine(string.Join(", ", array));

int count = 0;

for (int i = 0; i < array.Length; i++)
{
  if (array[i] > 0) count += 1;
}

System.Console.WriteLine($"Количество чисел больших нуля равно {count}");