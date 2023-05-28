// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и 
// возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)

// 2, 4 -> 16

Console.Clear();

int A, B;
double degree;

System.Console.Write("Введите число A: ");
A = Convert.ToInt32(Console.ReadLine());

System.Console.Write("Введите число B: ");
B = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine();

degree = Math.Pow(A, B);
System.Console.WriteLine($"{A}^{B}={degree}");