/*Console.Write("Введите число: ");
string text = Console.ReadLine()!; // можно сократить передав сразу в TryParse вместо текста
//int number = int.Parse(text); ниже сделаем правильнее
int number;
int.TryParse(text, out number);

//Console.Write(number);
//Console.Write("^2 = ");
//Console.Write(number * number);
Console.Write($"{number}^2 = {number * number}");*/

int number;
Console.Write("Введите число: ");
//string text = Console.ReadLine()!; // можно сократить передав сразу в TryParse вместо текста
//int number = int.Parse(text); ниже сделаем правильнее

int.TryParse(Console.ReadLine()!, out number);

//Console.Write(number);
//Console.Write("^2 = ");
//Console.Write(number * number);
Console.Write($"{number}^2 = {number * number}");