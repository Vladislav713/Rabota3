//Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Console.WriteLine("Введите размеры матриц и диапазон случайных значений:");
Console.WriteLine("Введите количество строк первой матрицы: ");
int m = Convert.ToInt32(Console.ReadLine());   
Console.WriteLine("Введите количество столбцов первой матрицы (одновременно такое же количество строк задаётся для второй матрицы): ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число столбцов второй матрицы: ");
int p = Convert.ToInt32(Console.ReadLine()); 

int[,] pervayamatrica = new int[m, n];
Napolnenie(pervayamatrica);
Console.WriteLine("Первая матрица:");
Print(pervayamatrica);

int[,] vtorayamatrica = new int[n, p];
Napolnenie(vtorayamatrica);
Console.WriteLine("Вторая матрица:");
Print(vtorayamatrica);

int[,] result = new int[m,p];
Proizvedene (pervayamatrica, vtorayamatrica);
Console.WriteLine("Произведение матриц:");
Print(result);

void Proizvedene (int[,] pervayamatrica, int[,] vtorayamatrica)
{
  for (int i = 0; i < result.GetLength(0); i++)
  {
    for (int j = 0; j < result.GetLength(1); j++)
    {
      int sum = 0;
      for (int k = 0; k < vtorayamatrica.GetLength(0); k++)
      {
        sum = sum + pervayamatrica[i,k] * vtorayamatrica[k,j];
      }
      result[i,j] = sum;
    }
  }
}

void Napolnenie (int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      array[i, j] = new Random().Next(1,10);
    }
  }
}

void Print (int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      Console.Write(array[i,j] + " ");
    }
    Console.WriteLine();
  }
}