using Class;
List<Ribr> ribrs = new List<Ribr>();
Console.WriteLine("Введите ребра и их вес,чтобы закончить вводите нулевые ребра");
while (true)
{
    Ribr ribr = new Ribr();
    string value = Console.ReadLine();
    string[] setValue = value.Split();
    if (setValue[0] == "0" || setValue[1] == "0")
    {
        break;
    }
    else
    {
        ribr.U = setValue[0];
        ribr.V = setValue[1];
        ribr.Weight = Convert.ToDouble(setValue[2]);
    }

    ribrs.Add(ribr);
}
for (int k = 0; k < ribrs.Count - 1; k++)
{
    for (int i = 0; i < ribrs.Count - 1; i++)
    {
        if (ribrs[i].Weight > ribrs[i + 1].Weight)
        {
            var tmp = ribrs[i];
            ribrs[i] = ribrs[i + 1];
            ribrs[i + 1] = tmp;
        }
    }
}


double weightWay = 0;
int index = 0;

List<string> conPeak = new List<string>();
List<Ribr> conRibrs = new List<Ribr>();
List<Ribr> opRibrs = new List<Ribr>();


foreach (Ribr r in ribrs)
{
    if (!conPeak.Contains(r.U) || !conPeak.Contains(r.V))
    {
        if (!conPeak.Contains(r.U) && !conPeak.Contains(r.V))
        {
            conRibrs.Add(r);
            weightWay += r.Weight;
            conPeak.Add(r.U);
            opRibrs.Add(r);
            conPeak.Add(r.V);
        }
        else
        {
            if (conPeak.Contains(r.U) && !conPeak.Contains(r.V))
            {
                weightWay += r.Weight;
                conRibrs.Add(r);
                opRibrs.Add(r);
                conPeak.Add(r.V);

            }
            if (!conPeak.Contains(r.U) && conPeak.Contains(r.V))
            {
                weightWay += r.Weight;
                conRibrs.Add(r);
                opRibrs.Add(r);
                conPeak.Add(r.U);
            }
            else
            {
                opRibrs.Add(r);
            }
        }
    }


}
string way = "";
List<string> ways = new List<string>();

int z = conRibrs.Count;
List<Ribr> usR = new List<Ribr>();
var firstSet = conRibrs.ToHashSet();
firstSet.SymmetricExceptWith(usR);
var diff = firstSet.ToList();


while (z > 0)
{
    firstSet = conRibrs.ToHashSet();
    firstSet.SymmetricExceptWith(usR);
    diff = firstSet.ToList();
    way += diff[0].U;
    way += diff[0].V;

    foreach (Ribr r in diff)
    {
        if (way.Contains(r.U) || way.Contains(r.V))
        {

            way += r.U;
            way += r.V;
            usR.Add(r);
            z--;

        }

    }
    ways.Add(way);
    way = "";

}
string us = "";
string lway = "";

for (int i = 1; i < ways.Count; i++)
{

    foreach (string k in ways)
    {

        foreach (Ribr c in ribrs)
        {


            if (!k.Contains(lway) && (!lway.Contains(k)))
            {

                if ((k.Contains(c.U) && lway.Contains(c.V)) || (k.Contains(c.V) && lway.Contains(c.U)))
                {
                    weightWay += c.Weight;
                    index = ways.IndexOf(k);
                    us = "";
                    us += c.U;
                    us += c.U;
                    break;

                }
            }

        }

        lway = k;

    }
}


Console.WriteLine($"Итог:{weightWay}");

