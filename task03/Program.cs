//Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

int Read()
{
    System.Console.WriteLine("Ведите номер дня(от 1 до 7): ");
    int day = int.Parse(Console.ReadLine());
    return day;
}

int day = Read();

string weekend(int day)
{
    if (day>5) return "Выходной день";
    else return "Рабочий день";
}


System.Console.WriteLine();
if (day<1 || day>7) System.Console.WriteLine("Номер дня введен неверно!");
else System.Console.WriteLine($"{weekend(day)}");
System.Console.WriteLine();
