// See https://aka.ms/new-console-template for more information

// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
//6 -> да
//7 -> да   1 -> нет

Random random = new Random();
int numberday = random.Next(0,8);
Console.WriteLine(numberday);

if (numberday < 1 | numberday >7)
{
    Console.WriteLine("Такого дня недели нет");
}
else
{
    if (numberday == 6 | numberday == 7)
    {
        Console.WriteLine("Да");
    }
    else
    {
        Console.WriteLine("Нет");
    }
}