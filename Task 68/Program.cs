
int f(int a, int b)
{
    if (a == 0)
        return b + 1;
    else
        if ((a != 0) && (b == 0))
        return f(a - 1, 1);
    else
        return f(a - 1, f(a, b - 1));
}

Console.Clear();
Console.Write("Введите первое число: ");
int m = int.Parse(Console.ReadLine()!);
Console.Write("Введите последнее число: ");
int n = int.Parse(Console.ReadLine()!);
while (m < 0 && m < 0)
{
    Console.WriteLine("Вы ошиблись");
    Console.Write("Введите первое число: ");
    n = int.Parse(Console.ReadLine()!);
    Console.Write("Введите последнее число: ");
    m = int.Parse(Console.ReadLine()!);
}
Console.WriteLine(f(m, n));