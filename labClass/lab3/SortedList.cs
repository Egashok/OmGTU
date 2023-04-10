using System.Collections;
using System.Runtime.CompilerServices;

Console.WriteLine("Введите длину листа");
int n = Int32.Parse(Console.ReadLine());
var list = new SortedList();

Console.WriteLine("Введите значения через Enter:");
for (int i = 1; i < n + 1; i++)
{
    string obj = Console.ReadLine();
    list.Add(obj.Split()[0], obj.Split()[1]);
}

while (true)
{
    Console.Clear();
    Console.WriteLine($"1.Count\n2.Clear\n3.SetByIndex\n4.GetValueList\n5.GetType\n6.GetKeyList\n7.RemoveAt\n8.Contains key\n9.Contains Value\nSpace.Вывод лист\n0.Выход");
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
        Console.WriteLine("Укажите индекс");
        var index = int.Parse(Console.ReadLine());
        Console.WriteLine("Укажите значение");
        list.SetByIndex(index, Console.ReadLine());
    }
    if (key.Key == ConsoleKey.D4)
    {
        foreach (var k in list.GetValueList())
        {
            Console.WriteLine(k);
        }
    }
    if (key.Key == ConsoleKey.D5)
    {
        Console.WriteLine(list.GetType());
    }
    if (key.Key == ConsoleKey.D6)
    {
        foreach (var k in list.GetValueList())
        {
            Console.WriteLine(k);
        }
    }

    if (key.Key == ConsoleKey.D7)
    {
        Console.WriteLine("Укажите индекс");
        list.RemoveAt(Convert.ToInt32(Console.ReadLine()));
        Console.WriteLine("Элемент удален");

    }
    if (key.Key == ConsoleKey.D8)
    {
        Console.WriteLine("Введите ключ:");
        string obj = Console.ReadLine();
        Console.WriteLine(list.ContainsKey(obj));

    }
    if (key.Key == ConsoleKey.D9)
    {
        Console.WriteLine("Введите значение:");
        string obj = Console.ReadLine();
        Console.WriteLine(list.ContainsValue(obj));
    }
    if (key.Key == ConsoleKey.Spacebar)
    {
        for (int i = 0; i < list.Count; i++)
        {
            Console.Write("\t({0} : {1})", list.GetKey(i), list.GetByIndex(i));
        }

    }
    if (key.Key == ConsoleKey.D0)
    {
        break;
    }
    Console.WriteLine("Нажмите чтобы продолжить...");
    Console.ReadKey();
}

