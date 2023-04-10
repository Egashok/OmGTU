List<string> words = new List<string>();
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
