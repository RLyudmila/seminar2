// See https://aka.ms/new-console-template for more information

//Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.


Random random = new Random();
int number = random.Next(10,100000);
Console.WriteLine(number);

if (number <= 99 & number >= 10)
{
   Console.WriteLine("Двухзначное число");
}

else
{
if (number > 100 & number <= 999)
{
int twonumber= number/10;
int secondnumber = twonumber % 10;
Console.WriteLine(secondnumber);
}
  else
  {
   if (number >= 1000)
   {
      
       while (number > 999)
       {
         number = number / 10;
       }
       int result = number % 10;
       Console.WriteLine(result);


   }
  }  
}
 
   