﻿//  Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
//= 5 b = 7 -> max = 7
//a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

Console.Write("Введите число а: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число b: ");
int b = Convert.ToInt32(Console.ReadLine());

if (a > b) {
  System.Console.WriteLine($"Большее число: {a} меньшее число:  {b}");
}
if (a < b) {
System.Console.WriteLine($"Большее число: {b}, меньшее число: {a}");
}

