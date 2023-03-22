void InputArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        array[i] = new Random().Next(0, 100);
}

int sumNechetElement (int[] array){
    int sum=0;
    for (int i = 1; i < array.Length; i=i+2){
        sum +=array[i];
    }
    return sum;
}

Console.Clear();
Console.Write("Введите кол-во элементов в массиве: ");
int n = int.Parse(Console.ReadLine()!);
int[] array = new int[n];
InputArray(array);
Console.WriteLine($"Начальный массив: [{string.Join(", ", array)}]");
Console.WriteLine(sumNechetElement(array));