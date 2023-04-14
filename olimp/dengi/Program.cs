var failA = new List<int>();
var failB = new List<int>();
var cish = new List<int>();
var con = new List<int>();
StreamReader f = new StreamReader("input.txt");
string s = f.ReadLine();
int nish = Convert.ToInt32(s.Split()[0]);
for (int i = 1; i < nish; i++)
{

    cish.Add(Convert.ToInt32(s.Split()[i]));
}
s = f.ReadLine();
int kish = Convert.ToInt32(s.Split()[0]);
for (int i = 0; i < kish; i++)
{
    failA.Add(Convert.ToInt32(s.Split()[i + 1]));
}
s = f.ReadLine();
int ncon = Convert.ToInt32(s.Split()[0]);
for (int i = 1; i < ncon; i++)
{
    con.Add(Convert.ToInt32(s.Split()[i]));
}
s = f.ReadLine();
int kcon = Convert.ToInt32(s.Split()[0]);
for (int i = 0; i < kcon; i++)
{
    failB.Add(Convert.ToInt32(s.Split()[i]));
}
s = f.ReadLine();
int ei = Convert.ToInt32(s[0]);
int fi = Convert.ToInt32(s[1]);

f.Close();
