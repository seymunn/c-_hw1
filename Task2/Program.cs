﻿//Задача 2: Напишите программу, 
//которая на вход принимает два числа и выдаёт, 
//какое число большее, а какое меньшее.

Console.WriteLine("Введите первое число:");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число:");
int number2 = Convert.ToInt32(Console.ReadLine());
if (number1>number2)
{
    Console.WriteLine($"Большее число: {number1}, меньшее число: {number2}");
}
else
{
    Console.WriteLine($"Большее число: {number2}, меньшее число: {number1}");
}