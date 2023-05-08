/*List<string> words = new List<string>();
List<string> wordStart = new List<string>();
List<string> wordEnd = new List<string>();
StreamReader f = new StreamReader("input.txt");

int n = Convert.ToInt32(f.ReadLine());
while (n != 0)
{
    words.Add(f.ReadLine());
    n--;
}
int k = Convert.ToInt32(f.ReadLine());
while (k != 0)
{
    wordStart.Add(f.ReadLine());
    k--;
}
int l = Convert.ToInt32(f.ReadLine());
while (l != 0)
{
    wordEnd.Add(f.ReadLine());
    l--;
}
f.Close();
*/
string[] f = File.ReadAllLines(@"D:\Золотая рыбка\input_s1_12.txt");
int n = int.Parse(f[0]);
string[] words = new string[n];

for (int i = 0; i < n; i++)
{
    words[i] = f[i + 1];
}

Dictionary<string, int> FirstChar = new Dictionary<string, int>();
int n1 = int.Parse(f[n + 1]);
for (int i = n + 2; i < n + 2 + n1; i++)
{
    string[] str = f[i].Split();
    FirstChar.Add(str[0], int.Parse(str[1]));
}

Dictionary<string, int> LastChar = new Dictionary<string, int>();
int n2 = int.Parse(f[n + n1 + 2]);
for (int i = n + n1 + 3; i < n + n2 + 3 + n1; i++)
{
    string[] str = f[i].Split();
    LastChar.Add(str[0], int.Parse(str[1]));
}

Dictionary<string, int> combinations = new Dictionary<string, int>();
foreach (string word in words)
{
    if (FirstChar.ContainsKey((Convert.ToString(word[0]))) && LastChar.ContainsKey((Convert.ToString(word[word.Length - 1]))))
    {
        string key = Convert.ToString(word[0]) + Convert.ToString(word[word.Length - 1]);
        if (combinations.ContainsKey(key))
        {
            combinations[key]++;
        }
        else
        {
            combinations.Add(key, 1);
        }
    }
}

int Count = 0;
bool Flag = true;
while (combinations.Count > 0 && Flag)
{
    Flag = false;
    Console.WriteLine("------------------");
    foreach (var combination in combinations)
    {
        string key = combination.Key;
        Console.Write($"key: {key}");
        int minn = Math.Min(FirstChar[Convert.ToString(key[0])], LastChar[Convert.ToString(key[1])]);
        Console.WriteLine($" value: {combinations[key]}  {key[0]}:{FirstChar[Convert.ToString(key[0])]} {key[1]}:{LastChar[Convert.ToString(key[1])]} {Count}");
        if (combination.Value < minn)
        {
            Count++;
            FirstChar[Convert.ToString(key[0])]--;
            LastChar[Convert.ToString(key[1])]--;
            combinations[key]--;
        }
        if (combinations[key] == 0 || FirstChar[Convert.ToString(key[0])] == 0 || LastChar[Convert.ToString(key[1])] == 0)
        {
            combinations.Remove(key);
        }
        if (combinations.ContainsKey(key) && combinations[key] != combination.Value)
        {
            Flag = true;
        }
    }
}

Console.WriteLine(Count);
Console.WriteLine(combinations.Count);
while (combinations.Count > 0)
{
    //string key = combinations.FirstOrDefault(x => x.Value == combinations.Values.Max()).Key;
    string key = "";
    int key_value = 0;
    foreach (var first in FirstChar)
    {
        string key_first = first.Key;
        foreach (var last in LastChar)
        {
            string key_last = last.Key;
            string all_key = key_first + key_last;
            int minn = Math.Min(first.Value,last.Value);
            if (minn != 0 && minn > key_value && combinations.ContainsKey(all_key))
            {
                key = all_key;
                key_value = minn;
            }
        }
    }
    if(key == "")
    {
        key = key = combinations.FirstOrDefault(x => x.Value == combinations.Values.Max()).Key;
    }
    if (combinations[key] > 0 && FirstChar[Convert.ToString(key[0])] > 0 && LastChar[Convert.ToString(key[1])] > 0)
    {
        Count++;
        FirstChar[Convert.ToString(key[0])]--;
        LastChar[Convert.ToString(key[1])]--;
        combinations[key]--;
    }
    if (combinations[key] == 0 || FirstChar[Convert.ToString(key[0])] == 0 || LastChar[Convert.ToString(key[1])] == 0)
    {
        combinations.Remove(key);
    }
}

Console.WriteLine(Count);
Console.WriteLine(combinations.Count);
while(combinations.Count > 0)
{
    foreach (var combination in combinations)
    {
        string key = combination.Key;
        if (combinations[key] > 0 && FirstChar[Convert.ToString(key[0])] > 0 && LastChar[Convert.ToString(key[1])] > 0)
        {
            Count++;
            FirstChar[Convert.ToString(key[0])]--;
            LastChar[Convert.ToString(key[1])]--;
            combinations[key]--;
        }
        if (combinations[key] == 0 || FirstChar[Convert.ToString(key[0])] == 0 || LastChar[Convert.ToString(key[1])] == 0)
        {
            combinations.Remove(key);
        }
    }
}
Console.WriteLine(Count);