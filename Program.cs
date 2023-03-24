/*-----------------Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
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


/* ------------Задача :48** Задайте двумерный массив размера m на n, каждый элемент в массиве находится по формуле:
Aij = i+j
Выведите полученный массив на экран 
m = 3, n = 4
0 1 2 3 
1 2 3 4 
2 3 4 5
*/

// int[,] array = new int[3, 4];

// for (int i = 0; i < array.GetLength(0); i++) // Заполнение массива - строки
// {
// 	for (int j = 0; j < array.GetLength(1); j++) //столбцы
// 		array[i, j] = i + j;
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


/* ------------Задача :51** Задайте двумерный массив. Найдите сумму элементов, находящихся на главной диагонали (с индексами
(0,0); (1,1) и т.д.)
Пример:
1 4 7 2
5 9 2 3 
8 4 2 4
Сумма элементов главной диагонали: 1+9+2 = 12
*/

/*  это первый вариант - ниже лучше и проще
int sum = 0;
for (int i = 0; i < array.GetLength(0); i++)
{
	for (int j = 0; j < array.GetLength(1); j++)
		if (i == j)
		{
			Console.Write($"{array[i, j]} ");
			sum += array[i, j];
		}
}
*/

// int sum = 0;
// int border = array.GetLength(0) < array.GetLength(1) ? border = array.GetLength(0) : border = array.GetLength(1); //ищем наименьщую сторону массива

// for (int i = 0; i < border; i++)
// {
// 	Console.Write($"{array[i, i]} ");
// 	sum += array[i, i];
// }

// Console.WriteLine($"\nsum = {sum}");

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

// ******************
// ------------ Lesson 8 Двухмерные массивы продолжение
/* ------------Задача 53:** Задайте двумерный массив. Напишите программу, которая поменяет местами первую и последнюю строку массива.
1 4 7 2
5 9 2 3
8 4 2 4

8 4 2 4
5 9 2 3
1 4 7 2  */

// int[,] array = new int[3, 4];

// for (int i = 0; i < array.GetLength(0); i++)  // заполняем  и выводим
// {
// 	for (int j = 0; j < array.GetLength(1); j++)
// 	{
// 		array[i, j] = new Random().Next(10);
// 		Console.Write($"{array[i, j]}");
// 	}
// 	Console.WriteLine();
// }

// int lastRow = array.GetLength(0) - 1;  // создаем переменную последнего элемента строки

// for (int i = 0; i < array.GetLength(1); i++)  // бежим по столбцам!!!
// 	(array[0, i], array[lastRow, i]) = (array[lastRow, i], array[0, i]); // меняем элементы строк

// Console.WriteLine();

// for (int i = 0; i < array.GetLength(0); i++)   // выводим полученный массив
// {
// 	for (int j = 0; j < array.GetLength(1); j++)
// 		Console.Write($"{array[i, j]}");

// 	Console.WriteLine();
// }


// ----------2 вариант с динамическим массивом

List<List<int>> array = new List<List<int>>();

for (int i = 0; i < array.Count; i++)  // заполняем  и выводим
{
	array.Add(new List<int>());
	for (int j = 0; j < array[i].Count; j++)  //!!!!!!!!!! array[i].Count
	{
		array[i].Add(new Random().Next(10));
		Console.Write($"{array[i][j]} "); 
	}
	Console.WriteLine();
}

int lastRow = array.Count - 1;

// for (int i = 0; i < array[0].Count; i++)
// 	(array[0][i], array[lastRow][i]) = (array[lastRow][i], array[0][i]);

// (array[0], array[lastRow]) = (array[lastRow], array[0]);

Console.WriteLine();

// for (int i = 0; i < array.Count; i++)   // выводим полученный массив
// {
// 	for (int j = 0; j < array[i].Count; j++)
// 		Console.Write($"{array[i][j]} ");

// 	Console.WriteLine();
// }


/* ------------Задача 55:** Задайте двумерный массив. Напишите программу, которая заменяем строки на столбцы.
В случае, если это невозможно, программа должна вывести сообщение для пользователя.
!!!!! Расмотреть задачу на списках.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7

1 5 8 5
4 9 4 2
7 2 2 6
2 3 4 7 */