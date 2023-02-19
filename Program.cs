int number;
Console.Write("Введите число: ");

int.TryParse(Console.ReadLine()!, out number);

Console.Write($"{number}^2 = {number * number}");