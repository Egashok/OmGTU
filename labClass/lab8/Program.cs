class Calculator
{
    public delegate void Operation(double a, double b);

    public event Operation AddEvent;
    public event Operation SubtractEvent ;
    public event Operation MultiplyEvent;
    public event Operation DivideEvent;

     public void Add(double a, double b)
    {
        Console.WriteLine($"{a} + {b} = {a + b}");
        AddEvent?.Invoke(a, b);
    }
     public void Substract(double a, double b)
    {
        Console.WriteLine($"{a} - {b} = {a - b}");
        SubtractEvent?.Invoke(a, b);
    }
     public void Multiply(double a, double b)
    {
        Console.WriteLine($"{a} + {b} = {a + b}");
        MultiplyEvent?.Invoke(a, b);
    }
     public void Devide(double a, double b)
    {
        Console.WriteLine($"{a} + {b} = {a + b}");
        DivideEvent?.Invoke(a, b);
    }
}