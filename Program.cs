/*
Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

*/

Console.WriteLine("input number ");
int number = Convert.ToInt32(Console.ReadLine());;
if (number > 99 && number < 1000)
{
    int numbertemp = number / 10;
    int digit2 = numbertemp % 10;
    Console.WriteLine("second digit is " + digit2);
}
else
{
    Console.WriteLine("input 3-digit number");
}

