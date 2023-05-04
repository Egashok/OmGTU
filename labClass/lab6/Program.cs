
Console.WriteLine("Сколько объектов");
int objCount = Convert.ToInt32(Console.ReadLine());
MainClass<int> main = new MainClass<int>(3);
foreach (var i in Enumerable.Range(0, objCount))
{
}


public class MainClass<T>
{
    public T[] arr;
    public MainClass(int size)
    {
        arr = new T[size];
    }

    public void Set(int index, T value)
    {
        arr[index] = value;
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