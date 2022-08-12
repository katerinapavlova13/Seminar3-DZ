﻿// Напишите программу, которая 
//принимает на вход число (N) и 
//выдаёт таблицу кубов чисел от 1 до N.
//3 -> 1, 8, 27
//5 -> 1, 8, 27, 64, 125

Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());

void PrintQuart(int a)
{
    for (int i = 1; i <= a; i++)
    Console.WriteLine($"{i} \t {i * i * i}");
}
if (n < 1)
{
    Console.Write("Введите число  > 1");
    return;
}
PrintQuart(n);