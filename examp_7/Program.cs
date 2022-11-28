// See https://aka.ms/new-console-template for more information
// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
//456 -> 5
//782 -> 8
//918 -> 1


Random random = new Random();
int number = random.Next(100,999);
Console.WriteLine(number);

int twonumber= number/10;
int secondnumber = twonumber % 10;

Console.WriteLine(secondnumber);
