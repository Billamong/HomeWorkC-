Console.Clear();
Console.WriteLine("Введите день недели от 1 до 7");
int n = Convert.ToInt32(Console.ReadLine());
if (n>=1 && n<=7){
    if (n>5 && n<=7)
        Console.WriteLine("Выходной");
    else
        Console.WriteLine("Рабочий день");
}
else   
    Console.WriteLine("Это не день недели");