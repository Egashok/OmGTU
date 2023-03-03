string path = "C:/Users/djego/OneDrive/Рабочий стол/csharp/lab02.02/input.txt";
using (StreamReader reader = new StreamReader(path))
{
    string? line = "";
    line = await reader.ReadLineAsync();
    string[] s = line.Split(' ');
    int n = Convert.ToInt32(s[0]);
    int m = Convert.ToInt32(s[1]);

    line = await reader.ReadLineAsync();
    string[] pos = line.Split(' ');
    int tmp = 0;
    int xPos = Convert.ToInt32(pos[0]);
    int yPos = Convert.ToInt32(pos[1]);
    int zPos = Convert.ToInt32(pos[2]);

    for (int i = 0; i < m; i++)
    {
        line = await reader.ReadLineAsync();
        string[] rot = line.Split(' ');
        string axis = rot[0];
        int cord = Convert.ToInt32(rot[1]);
        int dir = Convert.ToInt32(rot[2]);

        if (axis == "X")
        {
            if (xPos == cord)
            {
                if (dir > 0)
                {
                    tmp = zPos;
                    zPos = n + 1 - yPos;
                    yPos = tmp;
                }
                else
                {
                    tmp = yPos;
                    yPos = n + 1 - zPos;
                    zPos = tmp;
                }

            }
        }
        if (axis == "Y")
        {
            if (yPos == cord)
            {
                if (dir > 0)
                {
                    tmp = zPos;
                    zPos = n + 1 - xPos;
                    xPos = tmp;
                }
                else
                {
                    tmp = xPos;
                    xPos = n + 1 - zPos;
                    zPos = tmp;
                }
            }
        }
        if (axis == "Z")
        {
            if (zPos == cord)
            {
                if (dir > 0)
                {
                    tmp = yPos;
                    yPos = n + 1 - xPos;
                    xPos = tmp;
                }
                else
                {
                    tmp = xPos;
                    xPos = n + 1 - yPos;
                    yPos = tmp;
                }
            }
        }
    }
    Console.WriteLine($"{xPos};{yPos};{zPos}");
    using (StreamWriter writer = new StreamWriter("C:/Users/djego/OneDrive/Рабочий стол/csharp/lab02.02/output.txt", true))
    {
        await writer.WriteAsync($"{xPos};{yPos};{zPos}");
    }
}

