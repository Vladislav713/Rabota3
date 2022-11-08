//Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

// Печать массива.
void Print(int[] array)
{
    for (int i=0;i<array.Length;i++)
        Console.Write($"{array[i]} ");
    Console.WriteLine();
}
// Создание массива.
int[] Create(int razmer)
{
    return new int[razmer];
}
// Наполнение.
void Napolnenie(int[] array)
{
    for (int i=0;i<array.Length; i++)
    {
        array[i]=new Random().Next(1,10);
    }
}
// Сумма элементов, стоящих на нечётных позициях.
int Summa(int[] array)
{
    int sum=0;
    for (int i=0;i<array.Length;i++)
    {
        if (i % 2 == 0)
        {
            sum=sum+array[i];
        }
    }
    return sum;
}
int len= 5;
int[] array=Create(len);
Napolnenie(array);
Print(array);
Console.WriteLine();
int sum2=Summa(array);
Console.WriteLine("Сумма элементов, стоящих на нечётных позициях="+sum2);