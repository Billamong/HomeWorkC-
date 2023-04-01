void InputMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++){
            matrix[i, j] = new Random().Next(-10, 11);
            Console.Write($"{matrix[i, j]} \t");
        }
        Console.WriteLine();
    }
}

void PrintMatrix(int[,] matrix,int m)
{   
    double rezeltat = 0;
    for (int i = 0; i < matrix.GetLength(1);i++)
    { 
        for (int j = 0; j < matrix.GetLength(0); j++){
            rezeltat = rezeltat + matrix[j,i];
        }
        Console.Write($" {rezeltat/=m} \t");
        rezeltat = 0;
    }           
}

Console.Clear();
Console.Write("Введите размерность массива: ");
int[] size = Console.ReadLine()!.Split().Select(x => int.Parse(x)).ToArray();
int[,] matrixx = new int[size[0], size[1]];
InputMatrix(matrixx);
Console.WriteLine();
PrintMatrix(matrixx, size[0]);
