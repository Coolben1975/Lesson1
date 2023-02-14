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
