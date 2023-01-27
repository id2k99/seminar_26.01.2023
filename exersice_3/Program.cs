Console.Clear();
Console.Write(" Введите номер дня недели: ");
int number = int.Parse(Console.ReadLine());

string a = " Понедельник";
string b = " Вторник";
string c = " Среда";
string d = " Четверг";
string e = " Пятница";
string f = " Суббота";
string g = " Воскресенье";

if (number == 1)
{
    Console.WriteLine(a);
}

if (number == 2)
{
    Console.WriteLine(b);
}

if (number == 3)
{
    Console.WriteLine(c);
}

if (number == 4)
{
    Console.WriteLine(d);
}

if (number == 5)
{
    Console.WriteLine(e);
}

if (number == 6)
{
    Console.WriteLine(f);
}

if (number == 7)
{
    Console.WriteLine(g);
}

