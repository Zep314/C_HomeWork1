// Написать программу, которая на вход принимает число (N), а на выходе показывает все четные числа от 1 до N 

using System;

Console.Write("Введите число: ");
int N = Convert.ToInt32(Console.ReadLine());

// Сразу построим цикл, в котором переменная УЖЕ будет четной
for (int i = 2; i<=N; i = i + 2)
{
    if (i>2) Console.Write(", "); // красивый вывод с запятыми
    Console.Write($"{i}");
}
Console.WriteLine();
