
// // ----------------Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// // Например, задан массив:
// // 1 4 7 2
// // 5 9 2 3
// // 8 4 2 4
// // В итоге получается вот такой массив:
// // 7 4 2 1
// // 9 5 3 2
// // 8 4 4 2

// int[,] table = new int[3, 4];
// FillArrayRandom(table);
// PrintArray(table);
// SortToLower(table);
// Console.WriteLine();
// PrintArray(table);


// // Функция заполнения массива рандомно числами от 1 до 9
// void FillArrayRandom(int[,] array)
// {
// 	for (int i = 0; i < array.GetLength(0); i++)
// 	{
// 		for (int j = 0; j < array.GetLength(1); j++)
// 		{
// 			array[i, j] = new Random().Next(1, 10);
// 		}
// 	}
// }

// // Функция сортировки элементов в строке двумерного массива, по убыванию
// void SortToLower(int[,] array)
// {
// 	for (int i = 0; i < array.GetLength(0); i++)
// 	{
// 		for (int j = 0; j < array.GetLength(1); j++)
// 		{
// 			for (int k = 0; k < array.GetLength(1) - 1; k++)
// 			{
// 				if (array[i, k] < array[i, k + 1])
// 				{
// 					int temp = array[i, k + 1];
// 					array[i, k + 1] = array[i, k];
// 					array[i, k] = temp;
// 				}
// 			}
// 		}
// 	}
// }

// // Функция вывода двумерного массива
// void PrintArray(int[,] array)
// {
// 	for (int i = 0; i < array.GetLength(0); i++)
// 	{
// 		for (int j = 0; j < array.GetLength(1); j++)
// 		{
// 			Console.Write($"{array[i, j]} ");
// 		}
// 		Console.WriteLine();
// 	}
// }

// // ---------------------------------------------
// // -------------Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// // Например, задан массив:
// // 1 4 7 2
// // 5 9 2 3
// // 8 4 2 4
// // 5 2 6 7

// // Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

// int[,] table = new int[4, 4];
// FillArrayRandom(table);
// PrintArray(table);
// Console.WriteLine();
// NumberRowMinSumElements(table);


// // Функция вывода номера строки (не индекса) с наименьшей суммой элементов 
// void NumberRowMinSumElements(int[,] array)
// {
// 	int minRow = 0;
// 	int minSumRow = 0;
// 	int sumRow = 0;
// 	for (int i = 0; i < table.GetLength(1); i++)
// 	{
// 		minRow += table[0, i];
// 	}
// 	for (int i = 0; i < table.GetLength(0); i++)
// 	{
// 		for (int j = 0; j < table.GetLength(1); j++) sumRow += table[i, j];
// 		if (sumRow < minRow)
// 		{
// 			minRow = sumRow;
// 			minSumRow = i;
// 		}
// 		sumRow = 0;
// 	}
// 	Console.Write($"{minSumRow + 1} строка");
// }

// // Функция вывода двумерного массива
// void PrintArray(int[,] array)
// {
// 	for (int i = 0; i < array.GetLength(0); i++)
// 	{
// 		for (int j = 0; j < array.GetLength(1); j++)
// 		{
// 			Console.Write($"{array[i, j]} ");
// 		}
// 		Console.WriteLine();
// 	}
// }

// // Функция заполнения массива рандомно числами от 1 до 9
// void FillArrayRandom(int[,] array)
// {
// 	for (int i = 0; i < array.GetLength(0); i++)
// 	{
// 		for (int j = 0; j < array.GetLength(1); j++)
// 		{
// 			array[i, j] = new Random().Next(1, 10);
// 		}
// 	}
// }


// // ------------------------------------------------
// // -------------Задача 58: Задайте две матрицы. Напишите программу, 
// // которая будет находить произведение двух матриц.

// // Например, заданы 2 массива:
// // 1 4 7 2
// // 5 9 2 3
// // 8 4 2 4
// // 5 2 6 7
// // и
// // 1 5 8 5
// // 4 9 4 2
// // 7 2 2 6
// // 2 3 4 7
// // Их произведение будет равно следующему массиву:
// // 1 20 56 10
// // 20 81 8 6
// // 56 8 4 24
// // 10 6 24 49

// Console.WriteLine("Введите размеры матриц и диапазон случайных значений:");
// int m = InputNumbers("Введите число строк 1-й матрицы: ");
// int n = InputNumbers("Введите число столбцов 1-й матрицы (и строк 2-й): ");
// int p = InputNumbers("Введите число столбцов 2-й матрицы: ");
// int range = InputNumbers("Введите диапазон случайных чисел: от 1 до ");

// int[,] firstMartrix = new int[m, n];
// CreateArray(firstMartrix);
// Console.WriteLine($"Первая матрица:");
// WriteArray(firstMartrix);

// int[,] secomdMartrix = new int[n, p];
// CreateArray(secomdMartrix);
// Console.WriteLine($"Вторая матрица:");
// WriteArray(secomdMartrix);

// int[,] resultMatrix = new int[m, p];

// MultiplyMatrix(firstMartrix, secomdMartrix, resultMatrix);
// Console.WriteLine($"Произведение первой и второй матриц:");
// WriteArray(resultMatrix);

// void MultiplyMatrix(int[,] firstMartrix, int[,] secomdMartrix, int[,] resultMatrix)
// {
// 	for (int i = 0; i < resultMatrix.GetLength(0); i++)
// 	{
// 		for (int j = 0; j < resultMatrix.GetLength(1); j++)
// 		{
// 			int sum = 0;
// 			for (int k = 0; k < firstMartrix.GetLength(1); k++)
// 			{
// 				sum += firstMartrix[i, k] * secomdMartrix[k, j];
// 			}
// 			resultMatrix[i, j] = sum;
// 		}
// 	}
// }

// int InputNumbers(string input)
// {
// 	Console.Write(input);
// 	int output = Convert.ToInt32(Console.ReadLine());
// 	return output;
// }

// void CreateArray(int[,] array)
// {
// 	for (int i = 0; i < array.GetLength(0); i++)
// 	{
// 		for (int j = 0; j < array.GetLength(1); j++)
// 		{
// 			array[i, j] = new Random().Next(range);
// 		}
// 	}
// }

// void WriteArray(int[,] array)
// {
// 	for (int i = 0; i < array.GetLength(0); i++)
// 	{
// 		for (int j = 0; j < array.GetLength(1); j++)
// 		{
// 			Console.Write(array[i, j] + " ");
// 		}
// 		Console.WriteLine();
// 	}
// }



// -----------------------------------
// -----------Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)


int[,,] array3D = new int[2, 2, 2];
FillArray(array3D);
PrintIndex(array3D);


// Функция вывода индекса элементов 3D массива
void PrintIndex(int[,,] arr)
{
	for (int i = 0; i < array3D.GetLength(0); i++)
	{
		for (int j = 0; j < array3D.GetLength(1); j++)
		{
			Console.WriteLine();
			for (int k = 0; k < array3D.GetLength(2); k++)
			{
				Console.Write($"{array3D[i, j, k]}({i},{j},{k}) ");
			}
		}
	}
}

// Функция заполнения 3D массива не повторяющимеся числами
void FillArray(int[,,] arr)
{
	int count = 10;
	for (int i = 0; i < arr.GetLength(0); i++)
	{
		for (int j = 0; j < arr.GetLength(1); j++)
		{
			for (int k = 0; k < arr.GetLength(2); k++)
			{
				arr[k, i, j] += count;
				count += 3;
			}
		}
	}
}