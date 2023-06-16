/*
Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

*/

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


