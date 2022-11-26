/*Objective_002
Задача 65: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
M = 1; N = 5 -> "1, 2, 3, 4, 5"
M = 4; N = 8 -> "4, 5, 6, 7, 8"*/

void ShowNaturalNumsFromMtoN(int m, int n)
{
    if (n > m)
    {
        ShowNaturalNumsFromMtoN(m, n - 1);
    }
    if (n < m)
    {
        Console.Write("Incorrect input of values!");
    }
    else
    {
        if (n == m)
            Console.Write($"{n}");
        else
        {
            Console.Write($", {n}");
        }
    }
}

Console.WriteLine("Programm will show all natural numbers from M till N.");
Console.WriteLine("Please, enter M:");
int numberStart = int.Parse(Console.ReadLine()!);
Console.WriteLine("Please, enter N:");
int numberFinish = int.Parse(Console.ReadLine()!);

Console.WriteLine("Result is:");
ShowNaturalNumsFromMtoN(numberStart, numberFinish);