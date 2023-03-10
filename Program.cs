/*Console.Write("Введите число: ");
string text = Console.ReadLine()!; // можно сократить передав сразу в TryParse вместо текста
//int number = int.Parse(text); ниже сделаем правильнее
int number;
int.TryParse(text, out number);

//Console.Write(number);
//Console.Write("^2 = ");
//Console.Write(number * number);
Console.Write($"{number}^2 = {number * number}");*/

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

