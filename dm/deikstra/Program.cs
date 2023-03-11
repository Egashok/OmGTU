string[] peaks = Console.ReadLine().Split();
var ribrs = new Dictionary<string, int>();
string[] inpRibr = Console.ReadLine().Split();
ribrs.Add(inpRibr[0], Convert.ToInt32(inpRibr[1]));
string firstPeak = Console.ReadLine();
string lastPeak = Console.ReadLine();
List<string> opRibrs = new List<string>();
List<string> conPeaks = new List<string>();
conPeaks.Add(firstPeak);

while (!conPeaks.Contains(lastPeak))
{



}