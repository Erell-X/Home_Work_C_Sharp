// Задача 27: Напишите программу, которая принимает на вход число и 
// выдаёт сумму цифр в числе.

// 452 -> 11

// 82 -> 10

// 9012 -> 12

Console.Clear();

System.Console.Write("Введите число: ");
int Num = Convert.ToInt32(Console.ReadLine());

int Number = Num;
int NewNum = 0;
int Sum = 0;

while (Num > 9)
{
  NewNum = Num % 10;
  Sum = Sum + NewNum;
  Num = Num / 10;
}

Sum = Sum + Num;
System.Console.Write($"Сумма цифр числа {Number} равна {Sum}");