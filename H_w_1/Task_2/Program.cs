// Задача 4: Напишите программу, которая принимает на вход три числа и 
// выдаёт максимальное из этих чисел.

// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

Console.Clear();
  
int Num1, Num2, Num3;

Console.WriteLine("Введите 1-е число (Num1)");
Num1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите 2-е число (Num2)");
Num2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите 3-е число (Num3)");
Num3 = Convert.ToInt32(Console.ReadLine());

if (Num1 > Num2 && Num1 > Num3)
{
  Console.WriteLine($"Max = Num1 = {Num1}");
}

else if (Num2 > Num1 && Num2 > Num3)
{
  Console.WriteLine($"Max = Num2 = {Num2}");
}

else if (Num3 > Num1 && Num3 > Num2)
{
  Console.WriteLine($"Max = Num3 = {Num3}");
}

else if (Num1 == Num2 && Num1 > Num3)
{
  Console.WriteLine($"Max = Num1 = Num2 = {Num1}");
}

else if (Num2 == Num3 && Num2 > Num1)
{
  Console.WriteLine($"Max = Num2 = Num3 = {Num2}");
}

else if (Num1 == Num3 && Num1 > Num2)
{
  Console.WriteLine($"Max = Num1 = Num3 = {Num1}");
}

else if (Num1 == Num2 && Num2 == Num3)
{
  Console.WriteLine($"Числа равны друг другу, Max = Num1 = Num2 = Num3 = {Num1}");
}
