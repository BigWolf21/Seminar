// Программа перемножения  матриц


// Создание матрицы


void FillMatrix(int[,] matr)
{
  for (int i = 0; i < matr.GetLength(0); i++)
  {
    for (int j = 0; j < matr.GetLength(1); j++)
    {
      matr[i, j] = new Random().Next(1, 10);
    }
  }
}

void PrintMatrix(int[,] matr)
{
  for (int i = 0; i < matr.GetLength(0); i++)
  {
    for (int j = 0; j < matr.GetLength(1); j++)
    {
      Console.Write($"{matr[i, j]} ");
    }
    Console.WriteLine();
  }
}


int n = 10;
int m = 10;
int[,] matrix = new int[n, m];
int[,] matrix2 = new int[n, m];

FillMatrix(matrix);
Console.WriteLine();
PrintMatrix(matrix);

FillMatrix(matrix2);
Console.WriteLine();
PrintMatrix(matrix2);

int[,] matrix3 = new int[n, m];
void Gemm(int M, int N, int K,) 
for (int i = 0; i < n - 1; i++)
{
  for (int j = 0; j < m - 1; j++)
  {
    matrix3[i * m + j] = 0;
    for (int k = 0; k < n - 1; k++)
    {

    }
  }
}

