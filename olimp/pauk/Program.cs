string path = "C:/Users/djego/OneDrive/Рабочий стол/csharp/olimp/pauk/input.txt";
using (StreamReader reader = new StreamReader(path))
{
    string? line = "";
    line = await reader.ReadLineAsync();
    string[] s = line.Split(' ');
    int a = Convert.ToInt32(s[0]);
    int b = Convert.ToInt32(s[1]);
    int c = Convert.ToInt32(s[1]);

    line = await reader.ReadLineAsync();
    int Sx = Convert.ToInt32(line.Split(' ')[0]);
    int Sy = Convert.ToInt32(line.Split(' ')[1]);
    int Sz = Convert.ToInt32(line.Split(' ')[2]);

    line = await reader.ReadLineAsync();
    int Fx = Convert.ToInt32(line.Split(' ')[0]);
    int Fy = Convert.ToInt32(line.Split(' ')[1]);
    int Fz = Convert.ToInt32(line.Split(' ')[2]);
    int fRibr = 0;
    int tRibr = 0;


    if (Sx != Fx && (Sx == a || Sx == 0) && (Fx == a || Fx == 0))
    {
        fRibr = Math.Min(Math.Abs(Sy + Fy), Math.Abs((a - Sy) + (a - Fy))) + Math.Abs(Sx - Fx);
        tRibr = Math.Abs(Sz - Fz);
    }
    else if (Sy != Fy && (Sy == b || Sy == 0) && (Fy == b || Fy == 0))
    {
        fRibr = Math.Min(Math.Abs(Sx + Fx), Math.Abs((a - Sx) + (a - Fx))) + Math.Abs(Sy - Fy);
        tRibr = Math.Abs(Sz - Fz);

    }
    else if (Sz != Fx && (Sz == c || Sz == 0) && (Fz == c || Fz == 0))
    {
        fRibr = Math.Min(Math.Abs(Sz + Fz), Math.Abs((c - Sx) + (c - Fz))) + Math.Abs(Sy - Fy);
        tRibr = Math.Abs(Sx - Fx);

    }
    else if ((Sx == 0 || Sx == a) && (Fy == 0 || Fy == b) || (Fx == 0 || Fx == a) && (Sy == 0 || Sy == b))
    {
        fRibr = Math.Abs(Sx - Fx) + Math.Abs(Sy - Fy);
        tRibr = Math.Abs(Sz - Fz);

    }
    else if ((Sy == 0 || Sy == b) && (Fz == 0 || Fz == c) || (Fy == 0 || Fy == b) && (Sz == 0 || Sz == c))
    {
        fRibr = Math.Abs(Sz - Fz) + Math.Abs(Sy - Fy);
        tRibr = Math.Abs(Sx - Fx);

    }

    else
    {
        fRibr = Math.Abs(Sx - Fx) + Math.Abs(Sz - Fz);
        tRibr = Math.Abs(Sy - Fy);

    }


    double itog;
    itog = Math.Pow((Math.Pow(fRibr, 2) + Math.Pow(tRibr, 2)), (1 / 2.0));

    Console.WriteLine(itog);
}
