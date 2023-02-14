/* -------------- Задача 2:
Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

a = 5; b = 7 -> max = 7
a = 2 b = 10 -> max = 10
a = -9 b = -3 -> max = -3 */

/* 
int number1;
int number2;
Console.Write("Введите первое число: ");

int.TryParse(Console.ReadLine()!, out number1);
Console.Write("Введите второе число: ");

int.TryParse(Console.ReadLine()!, out number2);

if (number1 < number2)
	Console.Write($"max = {number2}");

else
	Console.Write($"max = {number1}");
*/

/* ------------ Задача 4:
Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

/*
int number, max = 0;

for (int i = 1; i <= 3; i++)
{
	Console.Write($"Введите число - {i} подтверждаете <Enter>: ");
	int.TryParse(Console.ReadLine()!, out number);

	if (number > max)
		max = number;
}

Console.Write($"max = {max}");
*/

/* -------------- Задача 6: 
Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

*/

/*
int number;
Console.Write("Введите число: ");

int.TryParse(Console.ReadLine()!, out number);
if (number % 2 == 0)
	Console.Write($"{number} -> Да");
else
	Console.Write($"{number} -> Нет");
*/


/* ----------- Задача 8: 
Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
*/

/*
int N, i = 2;
Console.Write("Введите число: ");
int.TryParse(Console.ReadLine()!, out N);

N = N < 0 ? N * -1 : N;

while (i <= N)
{
	if (i % 2 == 0)
		Console.Write($"{i}, ");
	i += 2;
}
*/