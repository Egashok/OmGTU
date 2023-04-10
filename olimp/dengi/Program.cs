var failA = new List<int>();
var failB = new List<int>();
var f = new List<int>();
StreamReader f = new StreamReader("input.txt");
string s = f.ReadLine();
int nish = Convert.ToInt32(s[0]);
int cish = Convert.ToInt32(s[1]);
s = f.ReadLine();
int kish = Convert.ToInt32(s[0]);
for (int i = 1; i < s.Split().Length - 1; i++)
{
    failA.Add(Convert.ToInt32(s.Split()[i]));
}
s = f.ReadLine();
int ncon = Convert.ToInt32(s[0]);
int ccon = Convert.ToInt32(s[1]);
s = f.ReadLine();
int kcon = Convert.ToInt32(s[0]);
for (int i = 1; i < s.Split().Length - 1; i++)
{
    failB.Add(Convert.ToInt32(s.Split()[i]));
}
s = f.ReadLine();
int e = Convert.ToInt32(s[0]);
for (int i = 1; i < s.Split().Length - 1; i++)
{
    failB.Add(Convert.ToInt32(s.Split()[i]));
}


f.Close();
