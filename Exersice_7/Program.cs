﻿/*
// Первый метод 

Console.Clear();
Console.WriteLine(" Введите 3-х значное число: ");
int num = int.Parse(Console.ReadLine());


if (num < 100 || num > 999)
{
    Console.WriteLine(" Число не трёхзначное");
    return;
}

int otvet = num % 10;

Console.WriteLine($" третья цифра: {otvet}"); */


// Второй метод

Console.Clear();
Console.WriteLine(" Введите 3-х значное число: ");
string number = Console.ReadLine();
string otvet = Convert.ToString(number[2]);
Console.WriteLine($" третья цифра: {otvet}");