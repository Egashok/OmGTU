List<int> cities = new List<int>();
List<string> roads = new List<string>();
StreamReader f = new StreamReader("input.txt");
while (!f.EndOfStream)
{
    int cityCount = Convert.ToInt32(f.ReadLine());
    string cityStr = f.ReadLine();
    foreach (int i in Enumerable.Range(0, cityCount))
    {
        cities.Add(Convert.ToInt32(cityStr.Split()[i]));
    }
    int roadCount = Convert.ToInt32(f.ReadLine());
    string roadStr = f.ReadLine();
    int nowRoad = 0;
    foreach (int i in Enumerable.Range(0, roadCount))
    {
        roads.Add(roadStr.Split()[nowRoad] + roadStr.Split()[nowRoad + 1]);
        nowRoad += 2;
    }
    int a = Convert.ToInt32(Console.ReadLine());
    int b = Convert.ToInt32(Console.ReadLine());

}
f.Close();
