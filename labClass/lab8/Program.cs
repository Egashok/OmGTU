Calculator calculator = new Calculator();
calculator.AddHandlerAdd((a, b) => Console.WriteLine($"{a} + {b} = {a + b}"));
calculator.AddHandlerSubtract((a, b) => Console.WriteLine($" {a} - {b} = {a - b}"));
calculator.AddHandlerMultiply((a, b) => Console.WriteLine($"{a} * {b} = {a * b}"));
calculator.AddHandlerDivide((a, b) => Console.WriteLine($"{a} / {b} = {a / b}"));

calculator.Add(2, 3);
calculator.Substract(5, 2);
calculator.Multiply(2, 4); 
calculator.Devide(10, 2); 


class Calculator
{
    public delegate void Operation(double a, double b);

    public event Operation AddEvent;
    public event Operation SubtractEvent ;
    public event Operation MultiplyEvent;
    public event Operation DivideEvent;

     public void Add(double a, double b)
    {
       
        AddEvent?.Invoke(a, b);
    }
     public void Substract(double a, double b)
    {
      
        SubtractEvent?.Invoke(a, b);
    }
     public void Multiply(double a, double b)
    {
    
        MultiplyEvent?.Invoke(a, b);
    }
     public void Devide(double a, double b)
    {
        if(b!=0){

        
        Console.WriteLine($"{a} / {b} = {a / b}");
        DivideEvent?.Invoke(a, b);
        }
        else{
            Console.WriteLine("На ноль нельзя делить");
        }
    }
    public void AddHandlerAdd(Operation handler)
    {
        AddEvent += handler;
    }

    public void RemoveHandlerAdd(Operation handler)
    {
        AddEvent -= handler;
    }

    public void AddHandlerSubtract(Operation handler)
    {
        SubtractEvent += handler;
    }

    public void RemoveHandlerSubtract(Operation handler)
    {
        SubtractEvent -= handler;
    }

    public void AddHandlerMultiply(Operation handler)
    {
        MultiplyEvent += handler;
    }

    public void RemoveHandlerMultiply(Operation handler)
    {
        MultiplyEvent -= handler;
    }

    public void AddHandlerDivide(Operation handler)
    {
        DivideEvent += handler;
    }

    public void RemoveHandlerDivide(Operation handler)
    {
        DivideEvent -= handler;
    }
}