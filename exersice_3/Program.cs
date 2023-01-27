Console.Clear();
Console.Write(" Введите номер дня недели: ");
int numberDayOfWeek = int.Parse(Console.ReadLine());

string a = " Понедельник";
string b = " Вторник";
string c = " Среда";
string d = " Четверг";
string e = " Пятница";
string f = " Суббота";
string g = " Воскресенье";

if (numberDayOfWeek < 1 || numberDayOfWeek > 7)
{
    Console.Write(" Введено неверное число: ");
    return;
}

if (numberDayOfWeek == 1)
{
    Console.WriteLine(a);
}

if (numberDayOfWeek == 2)
{
    Console.WriteLine(b);
}

if (numberDayOfWeek == 3)
{
    Console.WriteLine(c);
}

if (numberDayOfWeek == 4)
{
    Console.WriteLine(d);
}

if (numberDayOfWeek == 5)
{
    Console.WriteLine(e);
}

if (numberDayOfWeek == 6)
{
    Console.WriteLine(f);
}

if (numberDayOfWeek == 7)
{
    Console.WriteLine(g);
}