// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
Console.Write("Введите размер двумерного массыва: ");
Console.WriteLine();
int m=Convert.ToInt32(Console.ReadLine());
int n=Convert.ToInt32(Console.ReadLine());
double[,] massiv=new double[m,n];
Napolnenie(massiv);
Print(massiv);

void Print (double[,] massiv)
{
    for (int i=0; i<massiv.GetLength(0);i++)
    {
        Console.WriteLine();
        for (int j=0;j<massiv.GetLength(1);j++)
        {
            Console.Write(massiv[i,j]);
        }
    }
}

void Napolnenie(double[,] array)
{
    Random rand = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i,j] = rand.NextDouble()*100;
        }
    }
}



