// Напишите программу, которая найдет точку пересечения двух правых,
// заданных уравнениями y = k1 * x +b1, y = k2 * x + b2; 
// значения k1, b1, k2, b2 задаются пользователем.

Console.Clear();
Console.WriteLine(" Введите b1:");
int b1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(" Введите k1:");
int k1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(" Введите b2:");
int b2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(" Введите k2:");
int k2 = Convert.ToInt32(Console.ReadLine());

double x = Convert.ToDouble((b2-b1) / (k1-k2));
double y = Convert.ToDouble(k1 * x + b1);
Console.WriteLine($"x={x}, y={y}");
