
double Raznisa(double[] array){
    double max= array[0], min = array[0];
    for(int i=0;i<array.Length;i++){
        if(max<array[i])
            max=array[i];
        if(min>array[i])
            min=array[i];
    }
    return (max-min);
}

Console.Clear();
Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
double[] array = new double[n];
for (int i = 0; i < array.Length; i++)
    array[i] = Math.Round(new Random().NextDouble() * (100 - 0), 2);
Console.WriteLine($"[{string.Join(", ", array)}]");
Console.WriteLine(Math.Round(Raznisa(array), 2));

