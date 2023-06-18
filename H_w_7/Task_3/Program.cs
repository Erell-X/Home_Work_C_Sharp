// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

int AckermansFunction(int m, int n)
{
  if (m == 0)
  {
    return n + 1;
  }

  else if (n == 0 && m > 0)
  {
    return AckermansFunction(m - 1, 1);
  }

  else if (m > 0 && n > 0)
  {
    return AckermansFunction(m - 1, AckermansFunction(m, n - 1));
  }
  return m;
  return n;
}

System.Console.WriteLine("Введите число m: ");
int m = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine("Введите число n: ");
int n = Convert.ToInt32(Console.ReadLine());

AckermansFunction(m, n);
System.Console.WriteLine(AckermansFunction(m, n));