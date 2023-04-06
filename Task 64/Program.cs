string f(int a, int b)
{
    if (a == b)
        return $" {a}";
    return $" {b}," + f(a, b - 1);
}


Console.Clear();
Console.Write("Введите первое число: ");
int n = int.Parse(Console.ReadLine()!);
Console.Write("Введите последнее число: ");
int m = int.Parse(Console.ReadLine()!);
while (n > m)
{
    Console.WriteLine("Вы ошиблись");
    Console.Write("Введите первое число: ");
    n = int.Parse(Console.ReadLine()!);
    Console.Write("Введите последнее число: ");
    m = int.Parse(Console.ReadLine()!);
}
Console.WriteLine(f(n, m));