// Напишите программу которая на вход принимает два чила и выдаёт которое из них максимальное и минимальное
Console.Clear();
Console.Write("Введите первое число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int b = Convert.ToInt32(Console.ReadLine());

if (a>b)
    Console.WriteLine($"max {a}\nmin {b}");
else if (a<b)
    Console.WriteLine($"max {b}\nmin {a}");
else
    Console.WriteLine("они равны");