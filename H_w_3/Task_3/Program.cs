// Задача 38: Задайте массив вещественных(тип double) чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.

// [3,1; 7,2; 22,3; 2,4; 78,5] -> 76,1

double[] Array (int size)
{
  double[] arr = new double [size];
  Random rnd = new Random();            

  for (int i = 0; i < arr.Length; i++) 
  {
    arr[i] = rnd.Next(-1000, 1000) + rnd.NextDouble(); 
    arr[i] = Math.Round(arr[i], 1);
  }
  return arr;                        
}

Console.Write ("Введение размера массива: ");
int length = Convert.ToInt32(Console.ReadLine());
double[] array = Array (length);                  
Console.WriteLine(string.Join("; ", array));      

double min = 0, 
       max = 0;

for (int i = 0; i < array.Length; i++)
{
  if (array[i] < min) min = array[i];
}

for (int i = 0; i < array.Length; i++)
{
  if (array[i] > max) max = array[i];
}

double diff = max - min;
       diff = Math.Round(diff, 1);

System.Console.WriteLine($"Макс = {max}");
System.Console.WriteLine($"Мин = {min}");
System.Console.WriteLine($"{max} - {min} = {diff}");