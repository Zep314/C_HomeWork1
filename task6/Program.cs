// Написать программу, которая на вход принимает число, и выдает, является ли оно четным
// (делится на 2 без остатка)
using System;

Console.Write("Введите число: ");

int x = Convert.ToInt32(Console.ReadLine());

if ( (x % 2) ==0 )
{
    Console.WriteLine($"Число {x} является четным");
}
else
{
    Console.WriteLine($"Число {x} является нечетным");
}