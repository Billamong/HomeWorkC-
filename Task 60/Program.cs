
void inputMatrix(int[,,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k =0; k < matrix.GetLength(2); k++){
                matrix[i, j, k] = new Random().Next(0, 100);
            }
        }
        Console.WriteLine();
    }
}

void PrintMatrix(int[,,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(2); k++)
            {
                Console.Write($"{matrix[i, j, k]}({i},{j},{k})\t");
            }
            Console.WriteLine();
        }
    }
}

Console.Clear();
Console.Write("Введите размеры матрицы: ");
int coord = Convert.ToInt32(Console.ReadLine());
int[,,] matrix = new int[coord, coord, coord];
inputMatrix(matrix);
PrintMatrix(matrix);
Console.WriteLine();
