string[] words = Console.ReadLine().Split();
string[] words2 = new string[words.Length];

words2[0] = words[words.Length / 2];

int k = 1;
for (int i = words.Length / 2 - 1; i >= 0; i--)
{
    words2[k] = words[i];
    k = k + 2;
}

k = 2;
for (int i = words.Length / 2 + 1; i < words.Length; i++)
{
    words2[k] = words[i];
    k = k + 2;
}

for (int i = 0; i < words2.Length; i++)
{
    string word = words2[i];
    string newword = "";

    newword += word[word.Length / 2];
    for (int j = 0; j < word.Length / 2; j++)
    {
        newword += word[word.Length / 2 - j - 1];
        if (word.Length / 2 + j < word.Length)
        {
            newword += word[word.Length / 2 + j + 1];
        }
    }
    words2[i] = newword;
}

foreach (string c in words2)
{
    Console.Write(c + " ");

}