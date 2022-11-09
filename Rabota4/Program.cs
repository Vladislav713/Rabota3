// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.


Console.Write("Введите количество чисел: ");
int razmer = int.Parse(Console.ReadLine());
int[] array =new int [razmer];
for (int i=0; i<array.Length; i++)
{
    Console.Write($"Введите число под индексом {i}: ");
    array[i]=int.Parse(Console.ReadLine());
}


Console.WriteLine($"Количество положительных: {Pologitel(array)}");


// Считаем количество положительных чисел.

int Pologitel(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0)
        {
            count++;
        }

    }
    return count;
}
