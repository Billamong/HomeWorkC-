int f(int a, int b)
{
    if (a ==b  )
        return a;
    return f(a, b - 1) + b;
}


Console.Clear();
Console.Write("Введите первое число: ");
int m = int.Parse(Console.ReadLine()!);
Console.Write("Введите последнее число: ");
int n = int.Parse(Console.ReadLine()!);
Console.WriteLine(f(m, n));