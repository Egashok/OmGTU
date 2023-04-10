double[,] array = new double[5, 5] {
{double.PositiveInfinity, 1.0, double.PositiveInfinity, double.PositiveInfinity, 3.0 },
{double.PositiveInfinity, double.PositiveInfinity, 8.0, 7.0,1.0},
{double.PositiveInfinity, double.PositiveInfinity, 8.0, 7.0, 1.0 },
{double.PositiveInfinity, double.PositiveInfinity,2.0, double.PositiveInfinity, double.PositiveInfinity },
{double.PositiveInfinity,double.PositiveInfinity, double.PositiveInfinity, 4.0, double.PositiveInfinity }};

int xStart = Convert.ToInt32(Console.ReadLine()) - 1;



double[,] tbl = new double[5, 5];
for (int i = 0; i < 5; i++)
{

    for (int j = 0; j < 5; j++)
    {
        if (i != xStart)
        {
            tbl[i, j] = double.PositiveInfinity;
        }
        else
        {
            tbl[i, j] = 0;
        }
    }
}
for (int k = 1; k < 5; k++)
{

    for (int i = 0; i < 5; i++)
    {

        if (i == xStart)
        {

            tbl[i, k] = 0;
        }
        else
        {
            for (int j = 0; j < 5; j++)
            {
                tbl[i, k] = double.Min(tbl[i, k], tbl[j, k - 1] + array[j, i]);
            }
        }



    }
}
for (int i = 0; i < 5; i++)
{
    for (int j = 0; j < 5; j++)
    {
        Console.Write(tbl[i, j] + "\t");
    }
    Console.WriteLine();
}