// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

Console.Write("Введите размер двумерного массыва: ");
Console.WriteLine();
int m=Convert.ToInt32(Console.ReadLine());
int n=Convert.ToInt32(Console.ReadLine());
int[,] massiv=new int[m,n];
Napolnenie(massiv);
Print(massiv);
Console.WriteLine();
Console.WriteLine();
Srednee(massiv);

void Print (int[,] massiv)
{
    for (int i=0; i<massiv.GetLength(0);i++)
    {
        Console.WriteLine();
        for (int j=0;j<massiv.GetLength(1);j++)
        {
            Console.Write(" "+massiv[i,j]);
        }
    }
}

void Napolnenie(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i,j] = new Random().Next(1,10);
        }
    }
}
void Srednee(int[,] array)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        double sum=0;
        for (int i = 0; i < array.GetLength(0); i++)
        {
            sum=sum+array[i,j];
        }
    sum=sum/array.GetLength(0);
    Console.Write(" "+sum);
    }
}