﻿// Напишите программу которая принимает три числа и выдает максимум из них
Console.Clear();
Console.Write("Введите первое число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите третие число: ");
int c = Convert.ToInt32(Console.ReadLine());

if (a >= b){
    if(a>=c){
        Console.WriteLine($"max = {a} ");
    }
    else
        Console.WriteLine($"max = {c} ");
}
else if (b >= c)
    Console.WriteLine($"max = {b} ");
else 
    Console.WriteLine($"max = {c} ");


