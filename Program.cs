/*
Задача 19
Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да
*/
/*
Console.Write("Введите число из 5 цифр: ");

string str1 = Console.ReadLine()!;

int count = str1.Length;

if (count == 5)
{
	if (str1[0] == str1[4] && str1[1] == str1[3])
		Console.WriteLine($"{str1} -> да");
	else Console.WriteLine($"{str1} -> нет");
}
else Console.WriteLine($"Введено не 5 цифр");
*/

/*------------------
Задача 21
Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53
*/
/*
double[] A = new double[3];
double[] B = new double[3];

Console.Write($"Введите координату x - точки A: ");
double.TryParse(Console.ReadLine()!, out A[0]);
Console.Write($"Введите координату y - точки A: ");
double.TryParse(Console.ReadLine()!, out A[1]);
Console.Write($"Введите координату z - точки A: ");
double.TryParse(Console.ReadLine()!, out A[2]);

Console.Write($"Введите координату x - точки B: ");
double.TryParse(Console.ReadLine()!, out B[0]);
Console.Write($"Введите координату y - точки B: ");
double.TryParse(Console.ReadLine()!, out B[1]);
Console.Write($"Введите координату z - точки B: ");
double.TryParse(Console.ReadLine()!, out B[2]);

double Xdist = Math.Pow((B[0] - A[0]), 2);
double Ydist = Math.Pow((B[1] - A[1]), 2);
double Zdist = Math.Pow((B[2] - A[2]), 2);

double abDist = Math.Sqrt(Xdist + Ydist + Zdist);
abDist = Math.Round(abDist, 2);

Console.WriteLine($"A ({A[0]}, {A[1]}, {A[2]}); B ({B[0]}, {B[1]}, {B[2]}) -> {abDist}");
*/

/* Решение через описание переменных, используя stuct */

// point A;
// point B;

// Console.Write($"Введите координату x - точки A: ");
// double.TryParse(Console.ReadLine()!, out A.x);
// Console.Write($"Введите координату y - точки A: ");
// double.TryParse(Console.ReadLine()!, out A.y);
// Console.Write($"Введите координату z - точки A: ");
// double.TryParse(Console.ReadLine()!, out A.z);

// Console.Write($"Введите координату x - точки B: ");
// double.TryParse(Console.ReadLine()!, out B.x);
// Console.Write($"Введите координату y - точки B: ");
// double.TryParse(Console.ReadLine()!, out B.y);
// Console.Write($"Введите координату z - точки B: ");
// double.TryParse(Console.ReadLine()!, out B.z);

// double Xdist = Math.Pow((B.x - A.x), 2);
// double Ydist = Math.Pow((B.y - A.y), 2);
// double Zdist = Math.Pow((B.z - A.z), 2);

// double abDist = Math.Sqrt(Xdist + Ydist + Zdist);
// abDist = Math.Round(abDist, 2);

// Console.WriteLine($"A ({A.x}, {A.y}, {A.z}); B ({B.x}, {B.y}, {B.z}) -> {abDist}");

// struct point
// {
// 	public double x;
// 	public double y;
// 	public double z;
// }


/*------------------------
Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
6 -> да
7 -> да
1 -> нет
*/

// Console.Write("Введите число: ");
// int number;
// int.TryParse(Console.ReadLine()!, out number);
// if (number < 6 && number > 0) Console.Write($"{number} -> нет");
// if (number == 6 || number == 7) Console.Write($"{number} -> да");

