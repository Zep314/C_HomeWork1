// Написать программу, которая на вход принимает два числа и выдает, какое число больше, а какое меньше
using System;

Console.Write("Введите первое число a: ");
int numberA = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе число b: ");
int numberB = Convert.ToInt32(Console.ReadLine());

if ( numberA == numberB )
{
    Console.WriteLine($"Числа a и b равны. ( {numberA} == {numberB}). max = {numberA}");
}
else
    if ( numberA > numberB )
    {
        Console.WriteLine($"Число a больше b. ( {numberA} > {numberB}). max = {numberA}");
    }
    else
    {
        Console.WriteLine($"Число a меньше b. ( {numberA} < {numberB}). max = {numberB}");
    }
