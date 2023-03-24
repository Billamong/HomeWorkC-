void InputArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        array[i] = new Random().Next(1, 32);
}
Console.Clear();
Console.Write("Введите кол-во элементов в массиве: ");
int n = int.Parse(Console.ReadLine()!);
int[] array = new int[n];
InputArray(array);
Console.WriteLine($"Начальный массив: {string.Join(" ", array)}");
int chet = 0, nechet=0;
for(int i = 0; i<array.Length; i++){
    if (array [i]%2==0){
        Console.Write($"{array[i]} ");
        chet++;
    }
}
Console.WriteLine();
for(int i = 0; i<array.Length; i++){
    if (array [i]%2!=0){
        Console.Write($"{array[i]} ");
        nechet++;
    }
}
Console.WriteLine();
if( chet > nechet )
    Console.Write("Yes");
else 
    Console.Write("No");