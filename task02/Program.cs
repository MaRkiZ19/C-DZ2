// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

int Read()
{
    System.Console.WriteLine("Ведите трёхзначное число: ");
    int number = int.Parse(Console.ReadLine());
    return number;
}

int number = Read();

int ThirdNum(int number)
{
    while (number > 999) number = number/10;
    number = number % 10;
    return number;
}

System.Console.WriteLine();
if (number<100) System.Console.WriteLine("Третья цифра отсутсвует");
else System.Console.WriteLine($"Третье цифра = {ThirdNum(number)}");
System.Console.WriteLine();
