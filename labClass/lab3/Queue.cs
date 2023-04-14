using System.Collections;
using System.Runtime.CompilerServices;

Console.WriteLine("Введите длину queue");
int n = Int32.Parse(Console.ReadLine());
var list = new Queue();

Console.WriteLine("Введите значения через Enter:");
for (int i = 1; i < n + 1; i++)
{
    string obj = Console.ReadLine();
    list.Enqueue(obj);
}

while (true)
{
    Console.Clear();
    Console.WriteLine($"1.Count\n2.Clear\n3.GetType\n4.Peek\n5.Dequeue\n6.Contains\nSpace.Вывод queue\n0.Выход");
    ConsoleKeyInfo key;
    key = Console.ReadKey();
    Console.Clear();
    if (key.Key == ConsoleKey.D1)
    {
        Console.WriteLine($"Длина queue:{list.Count}");
    }
    if (key.Key == ConsoleKey.D2)
    {
        list.Clear();
        Console.WriteLine("queue очищен");
    }
    if (key.Key == ConsoleKey.D3)
    {

        Console.WriteLine(list.GetType());

    }
    if (key.Key == ConsoleKey.D4)
    {

        Console.WriteLine(list.Peek());
    }
    if (key.Key == ConsoleKey.D5)
    {

        Console.WriteLine(list.Dequeue());
    }
    if (key.Key == ConsoleKey.D6)
    {
        Console.WriteLine("Введите объект");
        string obj = Console.ReadLine();
        Console.WriteLine(list.Contains(obj));

    }



    if (key.Key == ConsoleKey.D8)
    {


    }

    if (key.Key == ConsoleKey.Spacebar)
    {
        foreach (var i in list)
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