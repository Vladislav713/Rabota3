// Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.

void Print (int[,] array)
{
    for (int i=0; i < array.GetLength(0);i++)
    {
        Console.WriteLine();
        for (int j=0; j < array.GetLength(1);j++)
        {
            Console.Write(array[i,j]+" ");
        }
    }  
}

void Napolnenie(int[,] array)
{
    for (int i=0; i< array.GetLength(0); i++)
    {
        for (int j=0; j< array.GetLength(1); j++)
        {
            array[i,j]=new Random().Next(1,10);
        }
    }
}

void Rasstanovka(int[,] array)
{
    for (int i=0;i<array.GetLength(0);i++)
    {
        for (int j=0;j<array.GetLength(1);j++)
        {
            for (int k=j+1; k<array.GetLength(1);k++)
            {
                int temp=0;
                if (array[i,j]<array[i,k])
                {
                    temp=array[i,k];
                    array[i,k]=array[i,j];
                    array[i,j]=temp;
                }
            }

        }
    }
}




int[,] massiv=new int[4,6];
Napolnenie(massiv);
Print(massiv);
Console.WriteLine();
Rasstanovka(massiv);
Print(massiv);