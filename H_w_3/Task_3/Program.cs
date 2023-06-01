// Задача 38: Задайте массив вещественных(тип double) чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.

// [3,1; 7,2; 22,3; 2,4; 78,5] -> 76,1

double[] Array (int size)
{
  double[] arr = new double[size];
  Random rnd = new Random();

  for (int i = 0; i < arr.Length; i++)
  {
    arr[i] =rnd.Next(-100, 100) + rnd.NextDouble();
  }
  return arr;
}

System.Console.Write("Введите размер массива: ");
int length = Convert.ToInt32(Console.ReadLine());
double[] array = Array(length);
System.Console.WriteLine(string.Join(", ", array));

double min = 0;

for (int i = 0; i < array.Length; i++)
{
  if (array[i] < array[i+1])
  {
    min = array[i];
  }

return array;

}

System.Console.WriteLine($"Минимальное {min}");



// double[] Array (int length)
// {
//   double[] arr2 = new double[length];
//   Random rnd = new Random();

//   for (int i = 0; i < arr2.Length; i++)
//   {
//     arr2[i] = max;
//   }
//   return arr2;
// }