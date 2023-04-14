using System.Collections;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

Console.WriteLine("Введите длину stack");
int n = Int32.Parse(Console.ReadLine());
var list = new Stack();

Console.WriteLine("Введите значения через Enter:");
for (int i = 1; i < n + 1; i++)
{
    string obj = Console.ReadLine();
    list.Push(obj);
}

while (true)
{
    Console.Clear();
    Console.WriteLine($"1.Count\n2.Clear\n3.GetType\n4.Push\n5.Peek\n6.Contains\n7.Скобки\nSpace.Вывод stack\n0.Выход");
    ConsoleKeyInfo key;
    key = Console.ReadKey();
    Console.Clear();
    if (key.Key == ConsoleKey.D1)
    {
        Console.WriteLine($"Длина stack:{list.Count}");
    }
    if (key.Key == ConsoleKey.D2)
    {
        list.Clear();
        Console.WriteLine("stack очищен");
    }
    if (key.Key == ConsoleKey.D3)
    {

        Console.WriteLine(list.GetType());

    }
    if (key.Key == ConsoleKey.D4)
    {
        Console.WriteLine("Введите объект");
        string obj = Console.ReadLine();
        list.Push(obj);
        Console.WriteLine("Элемент добавлен");
    }
    if (key.Key == ConsoleKey.D5)
    {

        Console.WriteLine(list.Peek());
    }
    if (key.Key == ConsoleKey.D6)
    {
        Console.WriteLine("Введите объект");
        string obj = Console.ReadLine();
        Console.WriteLine(list.Contains(obj));

    }



    else if (key.Key == ConsoleKey.D7)
    {
        Console.Write("Введите последовательность: ");
        string str = Console.ReadLine();
        Stack stackhelp = new Stack();
        var slovar = new Dictionary<char, char>()
        {
            { '[', ']'},
            { '(', ')'},
            { '{', '}'}
        };
        bool usl = true;
        foreach (char ch in str)
        {
            if (slovar.ContainsKey(ch))
            {
                stackhelp.Push(ch);
            }
            else if (stackhelp.Count == 0 || slovar[Convert.ToChar(stackhelp.Pop())] != ch)
            {
                usl = false;
                break;
            }
        }
        if (usl && stackhelp.Count == 0)
        {
            Console.WriteLine("Верно");
        }
        else
        {
            Console.WriteLine("Неверно");
        }

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