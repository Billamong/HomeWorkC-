﻿// Принимает на входчисло на выходе показывает все четные числа от 1 до N
Console.Clear();
Console.Write("Введите число: ");
int N = Convert.ToInt32(Console.ReadLine());

for ( int i = 2; i<= N;i = i+2 ){
    Console.Write($"{i}, ");
}
