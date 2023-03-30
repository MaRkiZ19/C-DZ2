//Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

int Read()
{
    System.Console.WriteLine("Ведите трёхзначное число: ");
    int number = int.Parse(Console.ReadLine());
    return number;
}

int number = Read();

int Average(int number)
{
    number = number / 10;
    int Average = number % 10;
    return Average;
}

System.Console.WriteLine();
if (number>999 || number<100) System.Console.WriteLine("Неверное число! Введите ТРЁХ значное число!");
else System.Console.WriteLine($"Вторая цифра 3х значного числа =  {Average(number)}");
System.Console.WriteLine();
