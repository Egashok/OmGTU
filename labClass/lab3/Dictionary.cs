using System.Collections;
using System.Runtime.CompilerServices;

Console.WriteLine("Введите длину словарьа");
int n = Int32.Parse(Console.ReadLine());
var list = new Dictionary<string, string>();

Console.WriteLine("Введите значения через Enter:");
for (int i = 1; i < n + 1; i++)
{
    string obj = Console.ReadLine();
    list.Add(obj.Split()[0], obj.Split()[1]);
}

while (true)
{
    Console.Clear();
    Console.WriteLine($"1.Count\n2.Clear\n3.GetType\n4.ContainsValue\n5.Remove\n6.ContainsKey\nSpace.Вывод словарь\n0.Выход");
    ConsoleKeyInfo key;
    key = Console.ReadKey();
    Console.Clear();
    if (key.Key == ConsoleKey.D1)
    {
        Console.WriteLine($"Длина словарь:{list.Count}");
    }
    if (key.Key == ConsoleKey.D2)
    {
        list.Clear();
        Console.WriteLine("словарь очищен");
    }
    if (key.Key == ConsoleKey.D3)
    {

        Console.WriteLine(list.GetType());

    }
    if (key.Key == ConsoleKey.D4)
    {
        Console.WriteLine("Введите объект");
        string obj = Console.ReadLine();
        Console.WriteLine(list.ContainsValue(obj));
    }
    if (key.Key == ConsoleKey.D5)
    {
        Console.WriteLine("Укажите ключ");
        list.Remove(Console.ReadLine());
    }
    if (key.Key == ConsoleKey.D6)
    {
        Console.WriteLine("Введите объект");
        string obj = Console.ReadLine();
        Console.WriteLine(list.ContainsKey(obj));

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
        list.ContainsValue(obj);

    }
    if (key.Key == ConsoleKey.Spacebar)
    {
        foreach (var i in list)
        {
            Console.WriteLine($"{i.Key}:{i.Value}");
        }

    }
    if (key.Key == ConsoleKey.D0)
    {
        break;
    }
    Console.WriteLine("Нажмите чтобы продолжить...");
    Console.ReadKey();
}

