/* Найти сумму положительных и отрицательных элементов массива
Например: [12 элементов] */

/*
int[] array = FillArray(12, -9, 10);
Print(array);
Console.Write($"{String.Join(", ", array)}\n"); // вывод с String.Join

int pos = 0;
int neg = 0;

// for (int i = 0; i < array.Length; i++)  // вывод с for
// {
//  if (array[i] > 0)
//      pos += array[i];
//  else
//      neg += array[i];

// }

foreach (int el in array)  // вывод с foreach но он не меняет значения массива
{
	pos += el > 0 ? el : 0;  //тернарный оператор вместо if
	neg += el < 0 ? el : 0;
	// if (el > 0)
	//  pos += el;
	// else
	//  neg += el;
}

Console.Write($"pos sum = {pos}\nneg sum = {neg}");

// double[] array2 = new double[12]; // массив с double
// Print(array2);                    // массив с double

void Print(Array arr)
{
	for (int i = 0; i < arr.Length; i++)
		Console.Write($"{arr.GetValue(i)} ");
	Console.WriteLine();
}

int[] FillArray(int size, int min = 0, int max = 10)
{
	int[] arr = new int[size];
	for (int i = 0; i < size; i++)
		arr[i] = new Random().Next(min, max);
	return arr;
}
*/

/* Дан массив, изменить положительные элементы на отрицательные и наоборот
[-4, -8, 8, 2] -> [4, 8, -8, -2] */

// int[] array = FillArray(12, -9, 10);

// Console.Write($"{String.Join(", ", array)}\n"); // вывод с String.Join
// InverseElements(array);
// Console.Write($"{String.Join(", ", array)}\n");

// void InverseElements(int[] arr)
// {
// 	for (int i = 0; i < array.Length; i++)
// 		arr[i] *= -1;
// }

// int[] FillArray(int size, int min = 0, int max = 10)
// {
// 	int[] arr = new int[size];
// 	for (int i = 0; i < size; i++)
// 		arr[i] = new Random().Next(min, max);
// 	return arr;
// }



/* Парой считаем первый и последний элемент, второй и предпоследний и т.д.
Результат – в новом массиве.
[1 2 3 4 5] -> 5 8 3
[6 7 3 6] -> 36 21 */


// int[] array = FillArray(7, 0, 10);
// int[] pairs = new int[array.Length / 2 + array.Length % 2];

// Console.Write($"{String.Join(", ", array)}\n");
// MuliplyPairs(array, pairs);

// Console.Write($"{String.Join(", ", pairs)}\n");
// void MuliplyPairs(int[] arr, int[] pair)
// {
// 	int size = arr.Length;
// 	int pairSize = pair.Length;

// 	for (int i = 0; i < size / 2; i++)
// 	{
// 		int rev = size - i - 1;
// 		pair[i] = arr[i] * arr[rev];
// 	}
// 	if (size % 2 != 0)
// 		pair[pairSize - 1] = arr[pairSize - 1];
// }

// int[] FillArray(int size, int min = 0, int max = 10)
// {
// 	int[] arr = new int[size];
// 	for (int i = 0; i < size; i++)
// 		arr[i] = new Random().Next(min, max);
// 	return arr;
// }