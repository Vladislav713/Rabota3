// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
// и возвращает значение этого элемента или же указание, что такого элемента нет.


void Napolnenie(int [,] array)
{
    for (int i = 0 ; i < array.GetLength(0) ; i++)
    {
        for (int j = 0 ; j < array.GetLength(1) ; j++)
            array[i,j]=new Random().Next(1,10);
    }
}
void Print(int [,] array)
{
    for (int i=0; i<array.GetLength(0); i++)
    {
        Console.WriteLine();
        for (int j=0; j< array.GetLength(1); j++)
            Console.Write(array[i,j]);
    }
}
void Vosvrat(int [,] array, int a, int b)
{
    if ( array.GetLength(0) < a  || array.GetLength(1) < b )
    {
        Console.WriteLine("Такого элемента нет");          
    }
    else 
    {
        Console.WriteLine("Значение элемента: "+array[a-1,b-1]);
    }
}

Console.WriteLine("Введите размер двумерного массиве:");
int m=Convert.ToInt32(Console.ReadLine());
int n=Convert.ToInt32(Console.ReadLine());
int[,] massiv=new int[m,n];
Napolnenie(massiv);
Print(massiv);
Console.WriteLine();
Console.WriteLine("Введите требуемую позицию элемента в массиве (строка, столбец):");
int x=Convert.ToInt32(Console.ReadLine());
int y=Convert.ToInt32(Console.ReadLine());
Vosvrat(massiv,x,y);
