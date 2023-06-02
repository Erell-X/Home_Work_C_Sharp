// Задача 34: Задайте массив заполненный случайными положительными 
// трёхзначными числами. Напишите программу, которая покажет количество
// чётных чисел в массиве.

// [345, 897, 568, 234] -> 2

int[] Array(int size)
{
  int[] arr = new int[size];
  Random rnd = new Random();

  for (int i = 0; i < arr.Length; i++)
  {
    arr[i] = rnd.Next(-1000, 1000);
  }
  return arr;
}

System.Console.Write("Введите размер массива: ");
int length = Convert.ToInt32(Console.ReadLine());
int[] array = Array(length);
System.Console.WriteLine(string.Join(", ", array));

int g = 0;

for (int i = 0; i < array.Length; i++)
{
  if (array[i] % 2 == 0)
  {
    g += 1;
  }

}

System.Console.WriteLine($"Количество чётных чисел в массиве равно {g}");