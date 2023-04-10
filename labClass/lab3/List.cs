using System.Collections;
using System.Runtime.CompilerServices;

Console.WriteLine("Введите длину листа");
int n = Int32.Parse(Console.ReadLine());
var list = new List<string>();

Console.WriteLine("Введите значения через Enter:");
for (int i = 1; i < n + 1; i++)
{
    string obj = Console.ReadLine();
    list.Add(obj);
}

while (true)
{
    Console.Clear();
    Console.WriteLine($"1.Count\n2.Clear\n3.Reverse print\n4.Max\n5.GetType\n6.Sort\n7.Remove\n8.Min\n9.Contains\nSpace.Вывод лист\n0.Выход");
    ConsoleKeyInfo key;
    key = Console.ReadKey();
    Console.Clear();
    if (key.Key == ConsoleKey.D1)
    {
        Console.WriteLine($"Длина лист:{list.Count}");
    }
    if (key.Key == ConsoleKey.D2)
    {
        list.Clear();
        Console.WriteLine("лист очищен");
    }
    if (key.Key == ConsoleKey.D3)
    {
        list.Reverse();
        Console.WriteLine("лист перевернут");

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
        list.Sort();
        Console.WriteLine("Лист отсортирован");
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

