// Написать программу, которая на вход принимает три числа и выдает максимальное из этих чисел.
using System;

const int size_array = 3; //по условию - сравниваем 3 числа, 
                          //поменяв эту константу можно сравнивать любое количество чисел

int[] my_array = new int[size_array]; // объявляем массив для хранения переменных

for (int i=0; i < size_array; i++)  // заполняем массив
{
    Console.Write($"Введите {i+1}-е число из {size_array}: ");
    my_array[i] = Convert.ToInt32(Console.ReadLine());
}

int j = 0; // указатель на масимальное число

for (int i=1; i < size_array; i++)  // ищем максимальное число, начиная со 2-ого элемента массива
{
    if (my_array[i]>my_array[j])
    {
        j = i;
    }
}

Console.WriteLine($"Максимальный {j+1}-й элемент, который равен {my_array[j]}");
