
using System.ComponentModel;
using System.Net.NetworkInformation;

Console.Write("Ведите колво маршрутов:");
int n = int.Parse(Console.ReadLine()!);
Minibuse[] minibuse = new Minibuse[n];
for (int i = 0; i < n; i++)
{
    Console.Write("Введите номер маршрута:");
    minibuse[i].num = double.Parse(Console.ReadLine()!);
    Console.Write("Введите пункт назначения: ");
    minibuse[i].dest = Console.ReadLine()!;
    Console.Write("Введите время выездна на маршруте в виде hh:mm:ss");
    minibuse[i].detime = TimeOnly.Parse(Console.ReadLine()!);
    Console.Write("Введите время пребывания в назначенный пункт:");
    minibuse[i].artime = TimeOnly.Parse(Console.ReadLine()!);
    Console.Write("Введите затраченная время на маршруте:");
    minibuse[i].period = int.Parse(Console.ReadLine()!);
    Console.WriteLine();
    Console.WriteLine();


}
Console.Write("Введите начало интервала времени:");
TimeOnly t1 = TimeOnly.Parse(Console.ReadLine()!);
Console.Write("Введите конец интервала времени:");
TimeOnly t2 = TimeOnly.Parse(Console.ReadLine()!);
Console.WriteLine();
Console.WriteLine();

Console.Write("Вам подходит маршруты:");

for (int i = 0; i < n; i++)

{
    if (minibuse[i].period <= 10 && minibuse[i].detime >= t1 && minibuse[i].artime <= t2)
    {
       

        Console.WriteLine(minibuse[i].num);

    }
}

struct Minibuse
{
    public double num;
    public string dest;
    public TimeOnly detime;
    public TimeOnly artime;
    public int period;
}

