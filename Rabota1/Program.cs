// Печать массива
void Print(int[] massiv)
{
    int dlina=massiv.Length;
    for (int i=0; i<dlina; i++)
    {
        Console.Write($"{massiv[i]} ");
    }
    Console.WriteLine(); 
}   
//Создание массива
int[] Create(int dlina2)
{
    return new int[dlina2];
}
//Наполнение массива
void Napolnenie(int[] massiv2)
{
    int dlina2=massiv2.Length; 
    for (int i=0; i<dlina2;i++)
    {
        massiv2[i]=new Random().Next(100,1000);
    }
}
//Подсчёт чётных
int Podschet(int[] massiv3)
{
    int kolchet=0;
    int dlina3=massiv3.Length;
    for  (int i = 0; i< dlina3; i++)
    {
        if ( massiv3[i] % 2 ==0 ) kolchet++;
    }
    return kolchet;
}
//Ввод данных
int dlina1=10;
int[] massiv1=Create(dlina1);
Napolnenie(massiv1);
int col=Podschet(massiv1);
Print(massiv1);
Console.WriteLine("Количество чётных чисел "+col);