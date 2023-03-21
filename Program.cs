﻿/*-----------------Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3
*/

// Console.Write("Введите элементы(через пробел): ");
// int[] arr = Array.ConvertAll(Console.ReadLine()!.Split(), int.Parse);
// int count = 0;

// for (int i = 0; i < arr.Length; i++)

// int number;
// Console.Write("Введите число: ");
//string text = Console.ReadLine()!; // можно сократить передав сразу в TryParse вместо текста
//int number = int.Parse(text); ниже сделаем правильнее

// int.TryParse(Console.ReadLine()!, out number);

//Console.Write(number);
//Console.Write("^2 = ");
//Console.Write(number * number);
// Console.Write($"{number}^2 = {number * number}");

// ------------ Lesson 6 
/*     ------   задача 39:** Напишите программу, которая перевернет одномерный массив (последний 
элемент будет на первом месте, а первый на последнем и т.д.)
[1 2 3 4 5] -> [5 4 3 2 1]
[6 7 3 6] -> [6 3 7 6]
*/

// int[] array = FillArray(10);

// Console.WriteLine(String.Join(", ", array));

// for (int i = 0; i < array.Length / 2; i++)
// {
// 	int rev = array.Length - i - 1;                  // вычисление обратного элемента 
// 	(array[i], array[rev]) = (array[rev], array[i]); // смена пары элементов
// }

// int[] FillArray(int size, int min = 0, int max = 10)
// {
// 	int[] arr = new int[size];
// 	for (int i = 0; i < size; i++)
// 		arr[i] = new Random().Next(min, max);
// 	return arr;
// }

// Console.WriteLine(String.Join(", ", array));

/* ----------   задача 40:** Напишите программу, которая принимает на вход три числа и 
проверяет, может ли существовать треугольник с соронами такой длины)
*/

// int[] array = new int[3];

// string[] str_nums = Console.ReadLine()!.Split(' ', ',', '.');


// for (int i = 0; i < array.Length; i++)
// 	array[i] = int.Parse(str_nums[i]);

// if (array[0] + array[1] > array[2] && array[1] + array[2] > array[0] && array[0] + array[2] > array[1])
// 	Console.Write($"Треугольник существует ");
// else
// 	Console.Write($"Треугольника не существует ");

/* А можно и так!!!!!!!!!!!	

int[] array = Console.ReadLine()!.Split(' ', ',', '.').Where(i => int.TryParse(i, out _)).Select(int.Parse).ToArray();

if (array[0] + array[1] > array[2] && array[1] + array[2] > array[0] && array[0] + array[2] > array[1])
	Console.Write($"Треугольник существует ");
else
	Console.Write($"Треугольника не существует ");
*/


/*   ------------- Задача 42:** Напишите программу, которая будет преобразовывать десятичное число в двоичное.
45 -> 101101
3 -> 11
2 -> 10
*/


// ------------ Lesson 7 Двухмерные массивы
/* ------------Задача 46:** Задайте двуменрый массив размером mxn, заполненный случайными числами.

!!!Понакрутили с проверкой при печати с 3-х менрым
m=3, n=4
*/

// int[,] array = new int[5, 3];

// for (int i = 0; i < array.GetLength(0); i++) // строки
// {
// 	for (int j = 0; j < array.GetLength(1); j++) //столбцы
// 	{
// 		array[i, j] = new Random().Next(10);
// 		Console.Write($"{array[i, j]} ");
// 	}
// 	Console.WriteLine();
// }

// PrintArray(array);


// void PrintArray(Array arr)   //Для печати
// {

// 	switch (arr.Rank) // проверка на мерность массив
// 	{
// 		case 1:
// 			for (int i = 0; i < arr.GetLength(0); i++) //строка одномерного массива
// 				Console.Write($"{arr.GetValue(i)} ");
// 			break;

// 		case 2:
// 			for (int i = 0; i < arr.GetLength(0); i++) // строки
// 			{
// 				for (int j = 0; j < arr.GetLength(1); j++) //столбцы
// 				{
// 					Console.Write($"{arr.GetValue(i, j)} ");
// 				}
// 				Console.WriteLine();
// 			}
// 			break;

// 		case 3:
// 			for (int i = 0; i < arr.GetLength(0); i++)  // строки
// 			{
// 				for (int j = 0; j < arr.GetLength(1); j++) //столбцы
// 				{
// 					for (int k = 0; k < arr.GetLength(2); k++) //3 измерение
// 					{
// 						Console.Write($"{arr.GetValue(i, j, k)} ");
// 					}
// 					Console.WriteLine();
// 				}
// 				Console.WriteLine();
// 			}
// 			break;
// 	}
// }

/*
Для "Зубчатых" массивов (массивов разных длинн строк), возможно использовать структуру:
!!!! Доп вопрос
*/
// List<List<int>> array = new List<List<int>>();

// array.Add(new List<int>());
// array[0].Add(5);
// array[0].Add(1);
// array[0].Add(4);
// array.Add(new List<int>());
// array[1].Add(5);
// array.Add(new List<int>());
// array[2].Add(5);
// array[2].Add(1);

// for (int i = 0; i < array.Count; i++) //Строки
// {
// 	for (int j = 0; j < array[i].Count; j++) //столбцы
// 	{
// 		Console.Write($"{array[i][j]} ");
// 	}
// 	Console.WriteLine();
// }


/* ------------Задача :48** 

*/