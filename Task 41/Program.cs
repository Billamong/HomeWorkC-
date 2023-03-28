void Array(int[] array){
    for (int i=0; i< array.Length; i++){
        Console.Write($"Введите {i+1} элемент : ");
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
}

int ColPolElement (int[] array) {
    int count = 0;
    for ( int i=0 ; i <  array.Length; i++)    
    {
        if (array[i]>0)
            count ++;
    }
    return count;
}

Console.Clear();
Console.Write("Введите колличество элементов : ");
int n = Convert.ToInt32(Console.ReadLine());
int[] mass = new int[n];
Array(mass);
Console.WriteLine($"[{string.Join(", ", mass)}]");
Console.WriteLine(ColPolElement(mass));