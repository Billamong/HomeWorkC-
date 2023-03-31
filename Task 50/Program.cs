void InputMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++){
            matrix[i, j] = new Random().Next(-10, 11);
            Console.Write($"{matrix[i, j]} \t");
        }
        Console.WriteLine();// [-10, 10]
    }
}

void PrintMatrix(int[,] matrix,int m,int n)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
            if( m-1==i && n-1==j )
                Console.Write($"Элемент: {matrix[i,j]}");
    }           
}

Console.Clear();
Console.Write("Введите размерность массива: ");
int[] size = Console.ReadLine()!.Split().Select(x => int.Parse(x)).ToArray();
int[,] matrixx = new int[size[0], size[1]];
Console.Write("Введите позиции элемента: ");
int[] poz = Console.ReadLine()!.Split().Select(x => int.Parse(x)).ToArray();
InputMatrix(matrixx);
if (poz[0] < size[0] && poz[1]<size[1])
    PrintMatrix(matrixx,poz[0],poz[1]);
else
    Console.Write("Такой позиции нет");