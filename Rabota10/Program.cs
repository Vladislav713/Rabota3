// Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

Console.Write("Введите размер двумерного массыва: ");
Console.WriteLine();
int m=Convert.ToInt32(Console.ReadLine());
int n=Convert.ToInt32(Console.ReadLine());
int[,] massiv=new int[m,n];
Napolnenie(massiv);
Print(massiv);
Console.WriteLine();
Console.WriteLine();
double[] arr=new double[m];
arr=Srednee(massiv);
Console.WriteLine();
Print2(arr);
Console.WriteLine();
MinimalSum(arr);

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

void Print2 (double[] massiv)
{
    for (int j=0;j<massiv.Length;j++)
    {
            Console.Write("   "+massiv[j]);
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

double[] Srednee(int[,] array)
{
   
    for (int i = 0; i < array.GetLength(0); i++)
    {
        double sum=0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sum=sum+array[i,j];
        }
        
        sum=sum/array.GetLength(1);
        arr[i]=sum;
        
        
    }
    return arr;
}
void MinimalSum (double[] array)
{
    int min=0;
    double mini=array[0];
    for (int i=0; i< array.Length ; i++)
    {
        if (array[i]<mini)
        {
            min=i;
            
        }
    }
    Console.WriteLine($"Строка под индексом {min} имеет наименьшую сумму элементов");
}
