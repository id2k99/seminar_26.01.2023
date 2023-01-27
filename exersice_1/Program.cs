Console.Clear();

Console.Write("Введите первое число ");
int a = int.Parse(Console.ReadLine());

Console.Write("Введите второе число ");
int b = int.Parse(Console.ReadLine());

if (a == b * b)
{
    Console.WriteLine($"Число {a} является квадратом числа {b}");
} 
else 
{
    Console.WriteLine($"Число {a} не является квадратом числа {b}");
} 