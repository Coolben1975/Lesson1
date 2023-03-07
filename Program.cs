/*---------- Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2 */

// int[] array = FillArray(4, 100, 1000);
// Print(array);
// PrintChet(array);

// void PrintChet(int[] arr)
// {
// 	int sum = 0;
// 	for (int i = 0; i < arr.Length; i++)
// 	{
// 		if (arr[i] % 2 == 0)
// 			sum += 1;
// 	}
// 	Console.Write($"{sum}");
// }

// void Print(Array arr)
// {
// 	Console.Write($"[");
// 	Console.Write($"{String.Join(", ", array)}] -> ");
// }

// int[] FillArray(int size, int min = 100, int max = 1000)
// {
// 	int[] arr = new int[size];
// 	for (int i = 0; i < size; i++)
// 		arr[i] = new Random().Next(min, max);
// 	return arr;
// }

/*-----------Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
*/

// int[] array = FillArray(4, -99, 100);
// Print(array);
// Console.Write(PrintSum(array));

// int PrintSum(int[] arr)
// {
// 	int sum = 0;
// 	for (int i = 0; i < arr.Length; i++)
// 	{
// 		if (i % 2 != 0)
// 			sum = sum + arr[i];
// 	}
// 	return sum;
// }

// void Print(Array arr)
// {
// 	Console.Write($"[");
// 	Console.Write($"{String.Join(", ", array)}] -> ");
// }

// int[] FillArray(int size, int min = -99, int max = 100)
// {
// 	int[] arr = new int[size];
// 	for (int i = 0; i < size; i++)
// 		arr[i] = new Random().Next(min, max);
// 	return arr;
// }


/* ---------- Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
[3 7 22 2 78] -> 76 */


// double[] array = FillArray(5);
// Print(array);

// double min = array[0];
// double max = array[0];

// foreach (double el in array)
// {
// 	if (min > el)
// 		min = el;
// 	if (max < el)
// 		max = el;
// }

// Console.Write($"{max - min}");

// void Print(Array arr)
// {
// 	Console.Write($"[");
// 	Console.Write($"{String.Join(", ", array)}] -> ");
// }

// double[] FillArray(int size)
// {
// 	double[] arr = new double[size];
// 	for (int i = 0; i < size; i++)
// 		arr[i] = Math.Round(new Random().NextDouble() * 100);
// 	return arr;
// }