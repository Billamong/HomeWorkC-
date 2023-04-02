void InputMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(0, 11);
        }
    }
}
void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]} \t");
        }
        Console.WriteLine();
    }
}

void POybvani(int[,] matrix)
{
    int min = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = j+1; k < matrix.GetLength(1); k++){
                if (matrix[i, j] < matrix[i, k])
                {
                    min = matrix[i, j];
                    matrix[i, j] = matrix[i, k];
                    matrix[i, k] = min;
                }
            }
        }
    }
}




Console.Clear();
Console.Write("Введите размерность массива: ");
int[] size = Console.ReadLine()!.Split().Select(x => int.Parse(x)).ToArray();
int[,] matrixx = new int[size[0], size[1]];
InputMatrix(matrixx);
PrintMatrix(matrixx);
POybvani(matrixx);
Console.WriteLine();
PrintMatrix(matrixx);
