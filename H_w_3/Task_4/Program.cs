/* Алгоритм написания метода по заполнению массива случайными числами:

double[] Array (int size)               - 1. описание основного метода
{
  double[] arr = new double [size];     - 2. описание внутреннего метода
  Random rnd = new Random();            - 3. введение метода рандомных чисел

  for (int i = 0; i < arr.Length; i++)  - 4. конструкция цикла for
  {
    arr[i] = rnd.Next(-100, 100) + rnd.NextDouble(); - 5. обозначение пределов случайно образованных чисел массива
  }
  return arr;                           - 6. возвращение внутреннего метода
}

Console.Write ("Введение размера массива: ");     - 7.  Сообщение пользователю о вводе размера массива 
int length = Convert.ToInt32(Console.ReadLine()); - 8.  Введение размера массива с клавиатуры
double[] array = Array (length);                  - 9.  Перезапись массива через переменную length вместо size
Console.WriteLine(string.Join(", ", array));      - 10. 

*/

