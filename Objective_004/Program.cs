/*Задача 69: Напишите программу, которая на вход принимает два числа A и B, и возводит число А в целую степень B с помощью рекурсии.
A = 3; B = 5 -> 243 (3⁵)
A = 2; B = 3 -> 8*/

int RecursionDegreeNumber(int number, int degree)
{
    if (degree == 0)
        return 1;
    return number * RecursionDegreeNumber(number, degree - 1);
}

Console.WriteLine("Programm will degree your number.");
Console.WriteLine("Please, enter your number:");
int num = int.Parse(Console.ReadLine()!);

Console.WriteLine("Please, enter degree:");
int deg = int.Parse(Console.ReadLine()!);

Console.WriteLine($"Result is: {RecursionDegreeNumber(num, deg)}.");