List<string> method = new List<string>();
StreamReader f = new StreamReader("input.txt");
string text = "";
while (!f.EndOfStream)
{
    method.Add(f.ReadLine());

}
f.Close();
List<string> chMethod = new List<string>();

foreach (string i in method)
{

    text = "";
    if (i.Split()[0] == "DUST")
    {
        string[] substr = i.Split();
        substr = substr.Skip(1).ToArray();
        foreach (string j in substr)
        {
            if (int.TryParse(j, out int number))
            {
                text += chMethod[Convert.ToInt32(j) - 1];
            }
            else
            {
                text += j;
            }
        }
        chMethod.Add($"DT{text}TD");
    }
    else if (i.Split()[0] == "MIX")
    {
        string[] substr = i.Split();
        substr = substr.Skip(1).ToArray();
        foreach (string j in substr)
        {
            if (int.TryParse(j, out int number))
            {
                text += chMethod[Convert.ToInt32(j) - 1];
            }
            else
            {
                text += j;
            }
        }
        chMethod.Add($"MX{text}XM");
    }
    else if (i.Split()[0] == "WATER")
    {
        string[] substr = i.Split();
        substr = substr.Skip(1).ToArray();
        foreach (string j in substr)
        {
            if (int.TryParse(j, out int number))
            {

                text += chMethod[Convert.ToInt32(j) - 1];
            }
            else
            {
                text += j;
            }
        }
        chMethod.Add($"WT{text}TW");
    }
    else if (i.Split()[0] == "FIRE")
    {
        string[] substr = i.Split();
        substr = substr.Skip(1).ToArray();
        foreach (string j in substr)
        {
            if (int.TryParse(j, out int number))
            {
                text += chMethod[Convert.ToInt32(j) - 1];
            }
            else
            {
                text += j;
            }
        }
        chMethod.Add($"FR{text}RF");
    }

}
Console.WriteLine(chMethod[chMethod.Count - 1]);