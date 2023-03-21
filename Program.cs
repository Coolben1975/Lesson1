// ------------ Lesson 7 Двухмерные массивы
/* -------------Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9
*/

// double[,] array = new double[3, 4];

// for (int i = 0; i < array.GetLength(0); i++) // строки
// {
// 	for (int j = 0; j < array.GetLength(1); j++) //столбцы
// 	{
// 		array[i, j] = Math.Round((new Random().NextDouble() * 2 - 1), 1);
// 	}
// 	Console.WriteLine();
// }

// PrintArray(array);

// void PrintArray(Array arr)   //Печать массива
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


/* ------------ Задача 50**. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
17 -> такого числа в массиве нет
*/

// int[,] array = new int[5, 5];  //определение массива

// FillArray(array);

// int row, col;

// Console.Write($"Введите номер строки массива: ");
// int.TryParse(Console.ReadLine()!, out row);

// Console.Write($"Введите номер столбца массива: ");
// int.TryParse(Console.ReadLine()!, out col);

// PrintArray(array);

// if(row > array.GetLength(0) || col > array.GetLength(1) || row < 0 || col < 0)
// 	Console.Write($"нет такого элемента в массиве");
// 	else
// 		Console.WriteLine($"Значение элемента массива = {array.GetValue(row, col)}");

// void FillArray(Array arr) // заполняем массив
// {
// 	for (int i = 0; i < array.GetLength(0); i++) // строки
// 	for (int j = 0; j < array.GetLength(1); j++) //столбцы
// 		array[i, j] = new Random().Next(1, 10);
// }

// void PrintArray(Array arr)   //Печать массива
// {
// 	switch (arr.Rank)  //проверка на мерность массив
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


/* ------------Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3
*/

int[,] array = new int[3, 4];
FillArray(array);
PrintArray(array);
SummColArrey(array);

void SummColArrey(Array arr)
{
double sum;
Console.Write($"Среднее арифметическое каждого столбца: ");	
for (int i = 0; i < array.GetLength(1); i++) //бежим по столбцам
{
	sum = 0;
	for (int j = 0; j < array.GetLength(0); j++) 
	{
		sum = sum + (array[j, i]);
	}
	Console.Write($"{sum / i}; ");	
}
}

void FillArray(Array arr) // заполняем массив
{
	for (int i = 0; i < array.GetLength(0); i++) // строки
	for (int j = 0; j < array.GetLength(1); j++) //столбцы
		array[i, j] = new Random().Next(1, 10);
}

void PrintArray(Array arr)   //Печать массива
{

	switch (arr.Rank) // проверка на мерность массив
	{
		case 1:
			for (int i = 0; i < arr.GetLength(0); i++) //строка одномерного массива
				Console.Write($"{arr.GetValue(i)} ");
			break;

		case 2:
			for (int i = 0; i < arr.GetLength(0); i++) // строки
			{
				for (int j = 0; j < arr.GetLength(1); j++) //столбцы
				{
					Console.Write($"{arr.GetValue(i, j)} ");
				}
				Console.WriteLine();
			}
			break;

		case 3:
			for (int i = 0; i < arr.GetLength(0); i++)  // строки
			{
				for (int j = 0; j < arr.GetLength(1); j++) //столбцы
				{
					for (int k = 0; k < arr.GetLength(2); k++) //3 измерение
					{
						Console.Write($"{arr.GetValue(i, j, k)} ");
					}
					Console.WriteLine();
				}
				Console.WriteLine();
			}
			break;
	}
}

