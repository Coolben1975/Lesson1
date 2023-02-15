/*-----------------------
Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
456 -> 5
782 -> 8
918 -> 1
*/

/* Console.Write("Введите трехначное число: ");

int number;
int.TryParse(Console.ReadLine()!, out number);

int number2 = number / 10 % 10;

Console.Write($"{number} -> {number2}"); */

/*-------------------
Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6
*/

/*
Console.Write("Введите трехначное число: ");
int number;
int.TryParse(Console.ReadLine()!, out number);

if (number < 100) Console.Write($"{number} -> третьей цифры нет");
else
{
	int number2 = number / 100 % 10;
	Console.Write($"{number} -> {number2}");
}
*/

/*---------------
Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
6 -> да
7 -> да
1 -> нет
*/

/*
Console.Write("Введите число: ");
int number;
int.TryParse(Console.ReadLine()!, out number);

if (number < 6 && number > 0) Console.Write($"{number} -> нет");
if (number == 6 || number == 7) Console.Write($"{number} -> да");
*/
