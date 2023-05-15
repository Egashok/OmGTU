Console.WriteLine("Количество вершин:");
int n = Convert.ToInt32(Console.ReadLine());
double[,] matrix = new double[n, n];
for (int i = 0; i < n; i++)
{
    for (int j = 0; j < n; j++)
    {
        Console.Write($"Значение {i + 1}-> {j + 1} : ");
        matrix[i, j] = Convert.ToDouble(Console.ReadLine());
        if (matrix[i, j] == 0)
        {

            matrix[i, j] = double.PositiveInfinity;
        }
    }
}
for (int i = 0; i < n; i++)
{
    for (int j = 0; j < n; j++)
    {
        if (i != j)
        {
            for (int k = 0; k < n; k++)
            {
                if (k != j)
                {
                    matrix[j, k] = Math.Min(matrix[j, i] + matrix[i, k], matrix[j, k]);
                }
            }
        }
    }
}
for (int i = 0; i < n; i++)
{
    for (int j = 0; j < n; j++)
    {

        Console.Write(matrix[i, j] + " ");
    }
    Console.WriteLine();
}
