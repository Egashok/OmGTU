while(true){
    Console.Clear();
    Console.WriteLine("1.Поиск стоимости бензина");
    Console.WriteLine("2.Об авторе");
    Console.WriteLine("3.Выход");
    ConsoleKeyInfo key;
    key=Console.ReadKey();
     Console.Clear();
    if(key.Key==ConsoleKey.D1){
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
double[,] matrix = new double[cityCount, cityCount];
  foreach(var k in roads){
for (int i = 0; i < cityCount; i++)
{
    for (int j = 0; j < cityCount; j++)
    {
        

         if (i+1==(int)Char.GetNumericValue(k[0])&&j+1==(int)Char.GetNumericValue(k[1])||i+1==(int)Char.GetNumericValue(k[1])&&j+1==(int)Char.GetNumericValue(k[0]))
        {
            

            matrix[i, j] = cities[i];
            
        }
         if(matrix[i,j]==0){
             matrix[i,j]=double.PositiveInfinity;
         }
     
       
       }

    }
}

for (int i = 0; i < cityCount; i++)
{
    for (int j = 0; j < cityCount; j++)
    {
        if (i != j)
        {
            for (int k = 0; k < cityCount; k++)
            {
                if (k != j)
                {
                    matrix[j, k] = Math.Min(matrix[j, i] + matrix[i, k], matrix[j, k]);
                }
            }
        }
    }
}
if(matrix[0,cityCount-1]==0){
    matrix[0,cityCount-1]=-1;
}
Console.WriteLine(matrix[0,cityCount-1]);
Console.ReadKey();
}

f.Close();

    }
    if(key.Key==ConsoleKey.D2){
        Console.WriteLine("Шохин Егор");
        Console.WriteLine("ФИТ-221");
        Console.ReadKey();
    }
     if(key.Key==ConsoleKey.D3){
        break;
    }
}