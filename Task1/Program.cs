﻿{
    int a,b;
    Console.WriteLine("Введите числа :");
    a = Convert.ToInt32(Console.ReadLine());
    b = Convert.ToInt32(Console.ReadLine());
    if (a>b)
    {
        Console.WriteLine(" наибольшее число, a");
    }
    else
    {
        Console.WriteLine(" наибольшее число, b");
    }
}