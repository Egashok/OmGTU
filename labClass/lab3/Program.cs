Console.WriteLine("Введите длину массива");
int n = Int32.Parse(Console.ReadLine());
var mas = new string[n];

Console.WriteLine("Введите значения через Enter:");
for (int i = 0; i < mas.Length; i++)
{
    mas[i] = Console.ReadLine();
}

while (true)
{
    Console.Clear();
    Console.WriteLine($"1.Lenght\n2.Clear\n3.IndexOf\n4.LastIndexOf\n5.Resize\n6.Reverse\n7.Fill\n8.BinarySearch\n9.Sort\nSpace.Вывод массива\n0.Выход");
    ConsoleKeyInfo key;
    key = Console.ReadKey();
    Console.Clear();
    if (key.Key == ConsoleKey.D1)
    {
        Console.WriteLine($"Длина массива:{mas.Length}");
    }
    if (key.Key == ConsoleKey.D2)
    {
        Array.Clear(mas);
        Console.WriteLine("Массив очищен");
    }
    if (key.Key == ConsoleKey.D3)
    {
        Console.WriteLine("Введите объект:");
        string obj = Console.ReadLine();
        Console.WriteLine($"Индекc:{Array.IndexOf(mas, obj)}");
    }
    if (key.Key == ConsoleKey.D4)
    {
        Console.WriteLine("Введите объект:");
        string obj = Console.ReadLine();
        Console.WriteLine($"Индекc:{Array.LastIndexOf(mas, obj)}");
    }
    if (key.Key == ConsoleKey.D5)
    {
        Console.WriteLine("Введите новую длину массива:");
        int k = Int32.Parse(Console.ReadLine());
        Array.Resize(ref mas, k);
    }
    if (key.Key == ConsoleKey.D6)
    {
        Array.Reverse(mas);
        Console.WriteLine("Массив расположен в обратном порядке");
    }

    if (key.Key == ConsoleKey.D7)
    {
        Console.WriteLine("Введите объект:");
        string newObj = Console.ReadLine();
        Array.Fill(mas, newObj);
    }
    if (key.Key == ConsoleKey.D8)
    {
        Console.WriteLine("Введите объект:");
        string obj = Console.ReadLine();
        Console.WriteLine($"Индекc:{Array.BinarySearch(mas, obj)}");

    }
    if (key.Key == ConsoleKey.D9)
    {
        Array.Sort(mas);
        Console.WriteLine("Массив отсортирован");
    }
    if (key.Key == ConsoleKey.Spacebar)
    {
        for (int i = 0; i < mas.Length; i++)
        {
            Console.WriteLine(mas[i]);
        }

    }
    if (key.Key == ConsoleKey.D0)
    {
        break;
    }
    Console.WriteLine("Нажмите чтобы продолжить...");
    Console.ReadKey();
}

