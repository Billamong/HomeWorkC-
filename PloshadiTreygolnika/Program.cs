Console.Clear();
Console.WriteLine(" Введите x1:");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(" Введите y1:");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(" Введите x2:");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(" Введите y2:");
int y2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(" Введите x3:");
int x3 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(" Введите y3:");
int y3 = Convert.ToInt32(Console.ReadLine());

double plash = Convert.ToDouble(((x2-x1)*(y3-y1)-(x3-x1)*(y2-y1))/2);
if (plash<0) plash*= -1;
Console.WriteLine($" Площадь треугольника {plash}");