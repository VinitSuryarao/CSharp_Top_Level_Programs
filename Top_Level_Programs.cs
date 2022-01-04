using System;

Console.WriteLine("Welcome to C# 9 ");
Console.WriteLine("Please enter the counter :-");
int n = int.Parse(Console.ReadLine());

Calculation(n);

void Calculation(int n)
{
    for (int i = 0; i <= n; i++)
    {
        Console.WriteLine($"{n} * {i} = {n*i}");
    }
}

Console.ReadLine();