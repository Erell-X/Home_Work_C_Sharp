
// Задача 13: Напишите программу, которая выводит третью цифру заданного числа 
// или сообщает, что третьей цифры нет.

// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

using System;

class Program6 {

  static void Main() {

  int Num, Res, lastFigure;
  
  lastFigure = 0;
  
  Console.Clear();
  Console.WriteLine("Введите число: ");
  Num = Convert.ToInt32(Console.ReadLine());
  
  if (Num/100 >= 1 && Num/100 <= 9)
  {
    lastFigure = Num % 10;
    
    Console.WriteLine($"Третья цифра заданного числа равна {lastFigure}");
  }
  
  else if (Num/100 > 10)
  {
    Res = Num / 10 
  }
  
  else if (Num/100 < 1)
  {
    Console.WriteLine("Третьей цифры у заданного числа нет");
  }

 
  }
  
}
