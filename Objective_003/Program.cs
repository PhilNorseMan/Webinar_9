/*Objective_003
Задача 67: Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.
453 -> 12
45 -> 9*/

int RecursionSumOfNumbersInNumber(int number)
{
    if (number == 0)
        return 0;

    return number % 10 + (RecursionSumOfNumbersInNumber(number / 10));
}

Console.WriteLine("Programm will show sum of numbers in your number.");
Console.WriteLine("Please, enter your number:");
int num = int.Parse(Console.ReadLine()!);

Console.WriteLine($"Result is: {RecursionSumOfNumbersInNumber(num)}");