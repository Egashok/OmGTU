using System.Collections;
Console.WriteLine("Введите длину листа");
int n = Int32.Parse(Console.ReadLine());
var list = new ArrayList();

Console.WriteLine("Введите значения через Enter:");
for (int i = 1; i < n + 1; i++)
{
    list.Add(Console.ReadLine());
}

while (true)
{
    Console.Clear();
    Console.WriteLine($"1.Countt\n2.Clear\n3.IndexOf\n4.LastIndexOf\n5.GetType\n6.Reverse\n7.RemoveAt\n8.Contains\n9.Sort\nSpace.Вывод листа\n0.Выход");
    ConsoleKeyInfo key;
    key = Console.ReadKey();
    Console.Clear();
    if (key.Key == ConsoleKey.D1)
    {
        Console.WriteLine($"Длина листа:{list.Count}");
    }
    if (key.Key == ConsoleKey.D2)
    {
        list.Clear();
        Console.WriteLine("лист очищен");
    }
    if (key.Key == ConsoleKey.D3)
    {
        Console.WriteLine("Введите объект:");
        string obj = Console.ReadLine();
        Console.WriteLine($"Индекc:{list.IndexOf(obj)}");
    }
    if (key.Key == ConsoleKey.D4)
    {
        Console.WriteLine("Введите объект:");
        string obj = Console.ReadLine();
        Console.WriteLine($"Индекc:{list.IndexOf(obj)}");
    }
    if (key.Key == ConsoleKey.D5)
    {
        Console.WriteLine(list.GetType());
    }
    if (key.Key == ConsoleKey.D6)
    {
        list.Reverse();
        Console.WriteLine("лист расположен в обратном порядке");
    }

    if (key.Key == ConsoleKey.D7)
    {
        Console.WriteLine("Укажите индекс");
        list.RemoveAt(Convert.ToInt32(Console.ReadLine()));
        Console.WriteLine("Элемент удален");

    }
    if (key.Key == ConsoleKey.D8)
    {
        Console.WriteLine("Введите объект:");
        string obj = Console.ReadLine();
        Console.WriteLine(list.Contains(obj));

    }
    if (key.Key == ConsoleKey.D9)
    {
        list.Sort();
        Console.WriteLine("лист отсортирован");
    }
    if (key.Key == ConsoleKey.Spacebar)
    {
        foreach (string x in list)
        {
            Console.WriteLine(x);
        }

    }
    if (key.Key == ConsoleKey.D0)
    {
        break;
    }
    Console.WriteLine("Нажмите чтобы продолжить...");
    Console.ReadKey();
}

