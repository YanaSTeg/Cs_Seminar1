﻿//Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

//4 -> да
//-3 -> нет
//7 -> нет

Console.WriteLine("Введие число:");
int number = Convert.ToInt32(Console.ReadLine());
int sqr = number / 2;
 if (number % 2 == 0)
 {
Console.WriteLine("Число делится на 2 без остатка");
 }
 else
 {
Console.WriteLine("Число не делится на 2");
 }

