void InputPrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++){
            matrix[i, j] = new Random().Next(1, 11);
            Console.Write($"{matrix[i, j]} \t");
        }
        Console.WriteLine();
    }
}
void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++){
            Console.Write($"{matrix[i, j]} \t");
        }
        Console.WriteLine();
    }
}

void TrancportMatrix(int[,] matrix,int n)
{   
    int rezeltat = 0;
    for (int i = 0; i < n/2; i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++){
            rezeltat=matrix[i,j];
            matrix[i,j]=matrix[n-1 - i,j];
            matrix[n - 1 - i,j]=rezeltat;
        }
    }           
}

Console.Clear();
Console.Write("Введите размерность массива: ");
int[] size = Console.ReadLine()!.Split().Select(x => int.Parse(x)).ToArray();
int[,] matrixx = new int[size[0], size[1]];
InputPrintMatrix(matrixx);
Console.WriteLine();
TrancportMatrix(matrixx, size[0]);
PrintMatrix(matrixx);

