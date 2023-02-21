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

/* ----------------------------
Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12
*/

// int number;
// int res = 0;
// Console.Write("Введите число: ");
// int.TryParse(Console.ReadLine()!, out number);
// Console.Write($"{number} -> ");
// while (number != 0)
// {
// 	res += number % 10;
// 	number = number / 10;
// }

// Console.WriteLine($"{res}");


/*---------------------------
Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

6, 1, 33 -> [6, 1, 33]
*/

// int[] array = new int[8];

// void FillArray(int[] collection)

// {
// 	for (int i = 0; i < collection.Length; i++)
// 	{
// 		int number = new Random().Next(0, 10);
// 		Console.Write($"{number}");
// 		array[i] = number;
// 		if (i < collection.Length - 1)
// 			Console.Write($", ");
// 		else Console.Write($" -> ");
// 	}
// }

// void PrintArray(int[] collection)
// {
// 	Console.Write($"[");
// 	for (int i = 0; i < collection.Length; i++)
// 	{
// 		Console.Write($"{collection[i]}");
// 		if (i < collection.Length - 1)
// 			Console.Write($", ");
// 		else Console.Write($"]");
// 	}
// }

// FillArray(array);
// PrintArray(array);




