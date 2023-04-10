using System.Collections;
using System.Runtime.CompilerServices;

Console.WriteLine("Введите длину множестваа");
int n = Int32.Parse(Console.ReadLine());
var list = new SortedSet<string>();
var list2 = new SortedSet<string>();

Console.WriteLine("Введите значения через Enter:");
for (int i = 1; i < n + 1; i++)
{
    string obj = Console.ReadLine();
    list.Add(obj);
}

while (true)
{
    Console.Clear();
    Console.WriteLine($"1.Count\n2.Clear\n3.Reverse print\n4.Max\n5.GetType\n6.Equals\n7.Remove\n8.Min\n9.Contains\nSpace.Вывод множества\n0.Выход");
    ConsoleKeyInfo key;
    key = Console.ReadKey();
    Console.Clear();
    if (key.Key == ConsoleKey.D1)
    {
        Console.WriteLine($"Длина множества:{list.Count}");
    }
    if (key.Key == ConsoleKey.D2)
    {
        list.Clear();
        Console.WriteLine("множество очищен");
    }
    if (key.Key == ConsoleKey.D3)
    {
        foreach (string i in list.Reverse())
        {
            Console.WriteLine(i);
        }

    }
    if (key.Key == ConsoleKey.D4)
    {
        Console.WriteLine($"Максимальный элемент{list.Max()}");
    }
    if (key.Key == ConsoleKey.D5)
    {
        Console.WriteLine(list.GetType());
    }
    if (key.Key == ConsoleKey.D6)
    {
        Console.WriteLine("Количество элементов нового мн-ва:");
        int r = Convert.ToInt32(Console.ReadLine());
        for (int i = 0; i < r; i++)
        {
            string value = Console.ReadLine();
            list2.Add(Console.ReadLine());
        }
        Console.WriteLine(list.Equals(list2));
    }


    if (key.Key == ConsoleKey.D7)
    {
        Console.WriteLine("Введите объект");
        string obj = Console.ReadLine();
        list.Remove(obj);
        Console.WriteLine("Объект удален");

    }
    if (key.Key == ConsoleKey.D8)
    {
        Console.WriteLine($"Минимальный элемент{list.Min()}");

    }
    if (key.Key == ConsoleKey.D9)
    {
        Console.WriteLine("Введите объект");
        string obj = Console.ReadLine();
        Console.WriteLine(list.Contains(obj));

    }
    if (key.Key == ConsoleKey.Spacebar)
    {
        foreach (string i in list)
        {
            Console.WriteLine(i);
        }

    }
    if (key.Key == ConsoleKey.D0)
    {
        break;
    }
    Console.WriteLine("Нажмите чтобы продолжить...");
    Console.ReadKey();
}

