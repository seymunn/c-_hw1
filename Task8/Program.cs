//Задача 8: Напишите программу, 
//которая на вход принимает число (N), 
//а на выходе показывает все чётные числа от 1 до N.

Console.WriteLine("Введите число:");
int N = Convert.ToInt32(Console.ReadLine());
int start = 2;
while (start <= N)
{
    Console.WriteLine(start);
    start += 2;
}