
Console.WriteLine("Введите первое число: ");
int first = int.Parse(Console.ReadLine()!);

Console.Write("Введите второе число: ");
int second = int.Parse(Console.ReadLine()!);

if (first == Convert.ToInt32(Math.Pow(second, 2)))
{
    Console.WriteLine($"Число {first} является квадратом числа {second}");
}
else Console.WriteLine($"Число {first} не является квадратом числа {second}");