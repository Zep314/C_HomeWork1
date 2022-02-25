// Написать программу, которая на вход принимает два числа и выдает, какое число больше, а какое меньше
using System;

Console.Write("Введите первое число a: ");
int numberA = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе число b: ");
int numberB = Convert.ToInt32(Console.ReadLine());

if ( numberA == numberB )
{
    Console.WriteLine("Числа a и b равны. ( {0} == {0})",numberA,numberB);
}
else
    if ( numberA > numberB )
    {
        Console.WriteLine("Число a больше b. ( {0} > {0})",numberA,numberB);
    }
    else
    {
        Console.WriteLine("Число a меньше b. ( {0} < {0})",numberA,numberB);
    }
