
MainClass<int> intArray = new MainClass<int>(0);
while (true){
    Console.Clear();
    Console.WriteLine("1.Добавить элемент");
    Console.WriteLine("2.Удалить элемент");
    Console.WriteLine("3.Получить по индексу");
    Console.WriteLine("Space.Вывод элементов");
    Console.WriteLine("4.Выход");
    ConsoleKeyInfo key;
    key=Console.ReadKey();
    Console.Clear();
    if(key.Key==ConsoleKey.D1){
        Console.WriteLine("Введите объект:");
        intArray.Add(Convert.ToInt32(Console.ReadLine()));

    }
    if(key.Key==ConsoleKey.D2){
        Console.WriteLine("Введите индекс:");
        intArray.Delete(Convert.ToInt32(Console.ReadLine()));

    }
    if(key.Key==ConsoleKey.D3){
        Console.WriteLine("Введите индекс:");
        Console.WriteLine(intArray.Get(Convert.ToInt32(Console.ReadLine())));

    }
    if(key.Key==ConsoleKey.Spacebar){
        foreach(var i in intArray.arr){
            Console.WriteLine(i);
        }
        Console.ReadKey();
    }
    if(key.Key==ConsoleKey.D4){
        break;

    }


}




public class MainClass<T>
{
    public T[] arr;
    public MainClass(int size){
        arr=new T[size];
    }
  
    public T Get(int index)
    {
        return arr[index];
    }
    public void Add(T value)
    {
        Array.Resize(ref arr, arr.Length + 1);
        arr[arr.Length - 1] = value;

    }
    public void Delete(int index)
    {
        for (int i = index; i < arr.Length - 1; i++)
        {
            arr[i] = arr[i + 1];
        }
        Array.Resize(ref arr, arr.Length - 1);
    }
}