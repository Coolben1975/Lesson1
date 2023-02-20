/*
Урок 4.Функции
Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4-> 16
*/

// int A, B;
// Console.Write($"Введите число A: ");
// int.TryParse(Console.ReadLine()!, out A);
// Console.Write($"Введите число B: ");
// int.TryParse(Console.ReadLine()!, out B);

// int number = A;

// for (int i = 1; i < B; i++)
// {
// 	number *= A;
// }
// Console.WriteLine($"{A}, {B} -> {number}");

/* ---------------
Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12
*/

int number;
int res = 0;
Console.Write("Введите число: ");
int.TryParse(Console.ReadLine()!, out number);

while (number > 1)
{
	res += number % 10;
	number /= number;
}

Console.Write($"{res}");






