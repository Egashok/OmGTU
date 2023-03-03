//1.Ввод вершин
//2.Ввод ребер  
//3.Ввод весов
List<string> peaksSet = new List<string>();
peaksSet.AddRange(Console.ReadLine().Split());
List<string> ribrSet = new List<string>();
ribrSet.AddRange(Console.ReadLine().Split());
List<string> weiSet = new List<string>();
weiSet.AddRange(Console.ReadLine().Split());
double score = 0;
string tmp = "";
List<string> conRibr = new List<string>();
List<string> conPeak = new List<string>();
List<int> opWei = new List<int>();
List<int> opRibr = new List<int>();
int a;

conPeak.Add(peaksSet[0]);
while (conPeak.Count != peaksSet.Count)
{
    foreach (string i in ribrSet)
    {
        foreach (string j in conPeak)
        {
            tmp = i;
            if (i.Contains(j) && !conPeak.Contains(tmp.Replace(j, "")))
            {

                opRibr.Add(ribrSet.IndexOf(i));
                opWei.Add(Convert.ToInt32(weiSet[ribrSet.IndexOf(i)]));
            }
        }
    }
    a = opRibr[opWei.IndexOf(opWei.Min())];

    foreach (char q in ribrSet[a])
    {
        if (!conPeak.Contains(Convert.ToString(q)))
        {
            conPeak.Add(Convert.ToString(q));
            score += Convert.ToDouble(weiSet[a]);
        }
    }

    opRibr.Clear();
    opWei.Clear();

}
Console.WriteLine(score);