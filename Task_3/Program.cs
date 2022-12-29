/*
Задача 19
Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да
*/

Console.WriteLine ("Введите пятизначное число: ");
string A = Console.ReadLine();
string rev_A = string.Concat (A.Reverse());
if (A == rev_A)
{
    Console.WriteLine ($" число {A} палиндром ");
}
else 
{
    Console.WriteLine ($" Число {A} не палиндром ");
}
