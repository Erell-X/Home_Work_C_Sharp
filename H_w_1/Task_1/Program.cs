// Напишите программу, которая на вход принимает два числа и выдаёт, 
// какое число большее, а какое меньшее.

// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

Console.Clear();
  
int Number1, Number2;

Console.WriteLine("Введите 1-е число (Number1)");
Number1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите 2-е число (Number2)");
Number2 = Convert.ToInt32(Console.ReadLine());

if (Number1 > Number2)
{
  Console.WriteLine($"Max = Number1 = {Number1}");
}

else if (Number1 < Number2)
{
  Console.WriteLine($"Max = Number2 = {Number2}");
}

else if (Number1 == Number2)
{
  Console.WriteLine($"Max = Number1 = Number2 = {Number1}");
}
