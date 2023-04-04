

void inputMatrix(int[,,] matrix, int[] array)
{
    int r=0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(2); k++)
            {
                matrix[i, j, k] = new Random().Next(10, 100);
                array[r] = matrix[i, j, k];
                r++;
            }
        }
    }
}
void SwapFirstLastString(int[,,] matrix, int[] array)
{
    int t = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(2); k++)
            {
                if (array[t] == matrix[i, j, k])
                    inputMatrix(matrix, array);
                t++;
            }
        }
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
int[] array = new int[coord * coord * coord];
inputMatrix(matrix, array);
SwapFirstLastString(matrix, array);
PrintMatrix(matrix);
Console.WriteLine();
Console.WriteLine($"Все числа: [{string.Join(", ", array)}]");