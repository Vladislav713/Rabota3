// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

// Cоздание массива.
double[] Create(int razmer)
{
    return new double[razmer];
}

// Наполнение массива рандомными значениями.
void Napolnenie(double[] array)
{
    Random rand = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rand.NextDouble()*100;
    }
}

//Печать массива. 

void Print (double[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
}

// Нахождение максимального элемента в массиве.

double Max (double[] array)
{
    double max = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > max)
        {
            max = array[i];
        }
    }
    return max;
}

// Нахождение минимального элемента в массиве.

double Min(double[] array)
{
    double min = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < min)
        {
            min = array[i];
        }
    }
    return min;
}


Console.Write("Введите размер массива:");
int razm = Convert.ToInt32(Console.ReadLine());
double[] arr = Create(razm);
Napolnenie(arr);
Print(arr);
Console.WriteLine();
double maxx=Max(arr);
double minn=Min(arr);
double znachenie=maxx-minn;
Console.WriteLine("Разницу между максимальным и минимальным значение элементов массива:"+znachenie);