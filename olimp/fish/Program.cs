string[] f = File.ReadAllLines("input.txt");
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

Dictionary<string, int> comb = new Dictionary<string, int>();
foreach (string word in words)
{
    if (FirstChar.ContainsKey((Convert.ToString(word[0]))) && LastChar.ContainsKey((Convert.ToString(word[word.Length - 1]))))
    {
        string key = Convert.ToString(word[0]) + Convert.ToString(word[word.Length - 1]);
        if (comb.ContainsKey(key))
        {
            comb[key]++;
        }
        else
        {
            comb.Add(key, 1);
        }
    }
}

int Count = 0;
bool Flag = true;
while (comb.Count > 0 && Flag)
{
    Flag = false;

    foreach (var combination in comb)
    {
        string key = combination.Key;

        int minn = Math.Min(FirstChar[Convert.ToString(key[0])], LastChar[Convert.ToString(key[1])]);

        if (combination.Value < minn)
        {
            Count++;
            FirstChar[Convert.ToString(key[0])]--;
            LastChar[Convert.ToString(key[1])]--;
            comb[key]--;
        }
        if (comb[key] == 0 || FirstChar[Convert.ToString(key[0])] == 0 || LastChar[Convert.ToString(key[1])] == 0)
        {
            comb.Remove(key);
        }
        if (comb.ContainsKey(key) && comb[key] != combination.Value)
        {
            Flag = true;
        }
    }
}


while (comb.Count > 0)
{

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
            if (minn != 0 && minn > key_value && comb.ContainsKey(all_key))
            {
                key = all_key;
                key_value = minn;
            }
        }
    }
    if(key == "")
    {
        key = key = comb.FirstOrDefault(x => x.Value == comb.Values.Max()).Key;
    }
    if (comb[key] > 0 && FirstChar[Convert.ToString(key[0])] > 0 && LastChar[Convert.ToString(key[1])] > 0)
    {
        Count++;
        FirstChar[Convert.ToString(key[0])]--;
        LastChar[Convert.ToString(key[1])]--;
        comb[key]--;
    }
    if (comb[key] == 0 || FirstChar[Convert.ToString(key[0])] == 0 || LastChar[Convert.ToString(key[1])] == 0)
    {
        comb.Remove(key);
    }
}


while(comb.Count > 0)
{
    foreach (var combination in comb)
    {
        string key = combination.Key;
        if (comb[key] > 0 && FirstChar[Convert.ToString(key[0])] > 0 && LastChar[Convert.ToString(key[1])] > 0)
        {
            Count++;
            FirstChar[Convert.ToString(key[0])]--;
            LastChar[Convert.ToString(key[1])]--;
            comb[key]--;
        }
        if (comb[key] == 0 || FirstChar[Convert.ToString(key[0])] == 0 || LastChar[Convert.ToString(key[1])] == 0)
        {
            comb.Remove(key);
        }
    }
}
Console.WriteLine(Count);