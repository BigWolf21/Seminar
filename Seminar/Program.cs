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


int n = 2;
int m = 2;
int[,] matrix = new int[n, m];
int[,] matrix2 = new int[n, m];

FillMatrix(matrix);
Console.WriteLine();
PrintMatrix(matrix);

FillMatrix(matrix2);
Console.WriteLine();
PrintMatrix(matrix2);



int[,] Multiplication(int[,] a, int[,] b)
{
  int[,] r = new int[a.GetLength(0), b.GetLength(1)];
  if (a.GetLength(1) != b.GetLength(0))
  {
    Console.WriteLine("Матрицы нельзя перемножить");
  }
  else
  {
    
    for (int i = 0; i < a.GetLength(0); i++)
    {
      for (int j = 0; j < b.GetLength(1); j++)
      {
        for (int k = 0; k < b.GetLength(0); k++)
        {
          matrix[i, j] += a[i, k] * b[k, j];
        }
      }
    }
    
  }
  return r;
}

Console.WriteLine();
PrintMatrix(Multiplication(matrix, matrix2));
