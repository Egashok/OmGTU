
while (true)
{
    Console.Clear();
    Console.WriteLine("1.+");
    Console.WriteLine("2.-");
    Console.WriteLine("3./");
    Console.WriteLine("4.*");

    int key = Convert.ToInt32(Console.ReadLine());
    Console.Clear();
    Console.WriteLine("Введите первое число:");
    int a = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите второе число:");
    int b = Convert.ToInt32(Console.ReadLine());
    Console.Clear();

    if (key == 1)
    {
        imath.x = a;
        imath.y = b;
        Operation operation = imath.Add;
        int result = operation(a, b);
        Console.WriteLine(result);
    }
    if (key == 2)
    {
        Operation operation = imath.Diff;
        int result = operation(a, b);
        Console.WriteLine(result);
    }
    if (key == 3)
    {
        if (b == 0)
        {
            Console.WriteLine("Нельзя делить на ноль!");
            continue;
        }
        Operation operation = imath.Division;
        int result = operation(a, b);
        Console.WriteLine(result);
    }
    if (key == 4)
    {
        Operation operation = imath.Multiply;
        int result = operation(a, b);
        Console.WriteLine(result);
    }

    Console.ReadLine();
}
delegate int Operation(int x, int y);
interface imath
{
    static int x;
    static int y;
    static int Add(int x, int y)
    {
        { return x + y; }
    }
    static int Diff(int x, int y)
    {
        return x - y;
    }
    static int Multiply(int x, int y)
    {
        return x * y;
    }
    static int Division(int x, int y)
    {
        return x / y;
    }

}
