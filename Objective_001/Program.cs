/*Задача 63: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от 1 до N.
N = 5 -> "1, 2, 3, 4, 5"
N = 6 -> "1, 2, 3, 4, 5, 6"*/

void ShowNaturalNumsFrom1toN(int n)
{
    if (n > 1)
    {
        ShowNaturalNumsFrom1toN(n - 1);
    }
    if (n < 1)
    {
        Console.Write("Incorrect input of N!");
    }
    else
    {
        if (n == 1)
            Console.Write($"{n}");
        else
        {
            Console.Write($", {n}");
        }
    }
}

Console.WriteLine("Programm will show all natural numbers from 1 till N.");
Console.WriteLine("Please, enter N:");
int number = int.Parse(Console.ReadLine()!);

Console.WriteLine("Result is:");
ShowNaturalNumsFrom1toN(number);