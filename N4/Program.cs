﻿int a, b;
a = 1;
Console.WriteLine("Введи любое число: ");
b = Convert.ToInt32(Console.ReadLine());

for (int i = a; i <= b; i++)
{
    if (i % 2 == 0) 
    {
        Console.Write( i );
    }  
}
