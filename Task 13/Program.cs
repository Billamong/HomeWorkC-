Console.Clear();
Console.WriteLine("Введите число");
int n = Convert.ToInt32(Console.ReadLine());

if (n<100){
    Console.WriteLine("третей цифры нет");
}
else if (n>999 && n<10000 ){
    n = n / 10;
    n = n % 10;
    Console.WriteLine(n);
}

else if (n>9999 && n < 100000){
    n = n / 100;
    n = n % 10;
    Console.WriteLine(n);
}
else if ( n > 99999){
    n = n / 1000;
    n = n % 10;
    Console.WriteLine(n);
}