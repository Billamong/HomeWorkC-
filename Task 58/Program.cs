
void inputMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(1, 11); // [1, 10]
        }
        Console.WriteLine();
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

void ProizveDenie(int[,] matrix1, int[,] matrix2, int[,] matrix3){
    for (int i = 0; i < matrix1.GetLength(0); i++)
    {
        for (int j = 0; j < matrix1.GetLength(1); j++)
        {
            for(int k=0; k < matrix3.GetLength(0); k++){
                matrix3[i,j] += matrix1[i,k]*matrix2[k,j];
            }
        }
    }
}

Console.Clear();
Console.Write("Введите размеры матрицы: ");
int coord = Convert.ToInt32(Console.ReadLine());
int[,] matrixA = new int[coord, coord];
int[,] matrixB = new int[coord, coord];
int[,] matrixC = new int[coord, coord];
inputMatrix(matrixA);
inputMatrix(matrixB);
PrintMatrix(matrixA);
Console.WriteLine();
PrintMatrix(matrixB);
Console.WriteLine();
ProizveDenie(matrixA, matrixB, matrixC);
PrintMatrix(matrixC);