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



/* Задача 38: Задайте массив !!! НАТУРАЛЬНЫХ как я вижу!!!!!! чисел. Найдите разницу между максимальным и минимальным элементов массива.
[3 7 22 2 78] -> 76 */

int[] array = FillArray(5, 0, 100);
Print(array);

int min = SendIndex(array, 0);
int max = SendIndex(array, 1);
Console.Write($"{max - min}");

int SendIndex(int[] array, int index)
{
	int ind = index;
	if (index == 0)
	{
		foreach (int el in array)
		{
			if (ind < el)
				ind = el;
		}

	}
	if (index == 1)
	{
		foreach (int el in array)
		{
			if (ind > el)
				ind = el;
		}

	}
	return ind;
}

void Print(Array arr)
{
	Console.Write($"[");
	Console.Write($"{String.Join(", ", array)}] -> ");
}

int[] FillArray(int size, int min = 0, int max = 100)
{
	int[] arr = new int[size];
	for (int i = 0; i < size; i++)
		arr[i] = new Random().Next(min, max);
	return arr;
}