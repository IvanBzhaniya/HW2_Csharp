/*
Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.



Console.WriteLine("input number ");
int number = Convert.ToInt32(Console.ReadLine());;
if (number > 99 && number < 1000)
{
    int digit2 = number / 10 % 10;
    Console.WriteLine("second digit is " + digit2);
}
else
{
    Console.WriteLine("input 3-digit number");
}


//Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

*/

Console.WriteLine("input number ");
int number = Convert.ToInt32(Console.ReadLine());;
if (number > 99 && number < 1000)
{
    int number1;
    number1 = number % 10;
    Console.WriteLine(number1);
}
    

else if (number > 999 && number < 10000)
{
    int number2;
    number2 = number / 10 % 10;
    Console.WriteLine(number2);
}

else if (number > 9999 && number < 100000)
{
    int number3;
    number3 = number / 10 / 10 % 10;
    Console.WriteLine(number3);
}

else if (number > 99999)
{
    Console.WriteLine("input 5-digit number or less");
}

else
{
    Console.WriteLine("третьей цифры нет");
}