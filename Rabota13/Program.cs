Console.WriteLine("Введите натуральное число больше 1:");
int number1 = int.Parse(Console.ReadLine());
            
void NumberCounter(int number)
    {
    if (number == 0) return;
    NumberCounter(number - 1);
    Console.WriteLine(" "+number);
    }

 NumberCounter(number1);