
Console.Clear();
Console.WriteLine("Введите введите пятизначное число :");
string s = Console.ReadLine()!;


if(s[0]==s[4]){
    if(s[1]==s[3])
        Console.WriteLine("число полиндром");
}
else
Console.WriteLine("Число не полиндром");
