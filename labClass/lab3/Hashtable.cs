using System.Collections;
using System.Runtime.CompilerServices;

Console.WriteLine("Введите длину хэша");
int n = Int32.Parse(Console.ReadLine());

var list = new Hashtable();
var list2 = new Hashtable();

Console.WriteLine("Введите значения через Enter:");
for (int i = 1; i < n + 1; i++)
{

    string obj = Console.ReadLine();
    list.Add(obj.Split()[0], obj.Split()[1]);
}

while (true)
{
    Console.Clear();
    Console.WriteLine($"1.Count\n2.Clear\n3.Contains Value\n4.Equals Value\\n5.GetType\n6.GetHashCode\n7.Remove\n8.Contains key \nSpace.Вывод хэша\n0.Выход");
    ConsoleKeyInfo key;
    key = Console.ReadKey();
    Console.Clear();
    if (key.Key == ConsoleKey.D1)
    {
        Console.WriteLine($"Длина хэша:{list.Count}");
    }
    if (key.Key == ConsoleKey.D2)
    {
        list.Clear();
        Console.WriteLine("хэш очищен");
    }

    if (key.Key == ConsoleKey.D4)
    {
        Console.WriteLine("Количество элементов нового хэша:");
        int r = Convert.ToInt32(Console.ReadLine());
        for (int i = 0; i < r; i++)
        {
            string value = Console.ReadLine();
            list2.Add(value.Split()[0], value.Split()[1]);
        }
        Console.WriteLine(list.Equals(list2));
    }
    if (key.Key == ConsoleKey.D5)
    {
        Console.WriteLine(list.GetType());
    }
    if (key.Key == ConsoleKey.D6)
    {
        Console.WriteLine(list.GetHashCode());
    }

    if (key.Key == ConsoleKey.D7)
    {
        Console.WriteLine("Укажите индекс");
        list.Remove(Console.ReadLine());
        Console.WriteLine("Элемент удален");

    }
    if (key.Key == ConsoleKey.D8)
    {
        Console.WriteLine("Введите ключ:");
        string obj = Console.ReadLine();
        Console.WriteLine(list.ContainsKey(obj));

    }
    if (key.Key == ConsoleKey.D3)
    {
        Console.WriteLine("Введите значение:");
        string obj = Console.ReadLine();
        Console.WriteLine(list.ContainsValue(obj));
    }
    if (key.Key == ConsoleKey.Spacebar)
    {

        foreach (var x in list.Keys)
        {
            Console.Write("\t({0}, {1})", x, list[x]);
        }
        Console.WriteLine();

    }
    if (key.Key == ConsoleKey.D0)
    {
        break;
    }
    Console.WriteLine("Нажмите чтобы продолжить...");
    Console.ReadKey();
}

