Console.Write("Введите число: ");
int a = int.Parse(Console.ReadLine()!);
//Вариант 2 - Математический 
//int sqr = a * a;
//Console.WriteLine ($"Квадрат числа {a} равен {sqr}");

//Вариант 3 -  Библиотека
int sqr1 = Convert.ToInt32(Math.Pow(a, 2));
Console.WriteLine ($"Квадрат числа {a} равен {sqr1}");