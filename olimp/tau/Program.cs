string[] words = Console.ReadLine().Split();
string[] words2 = new string[words.Length];

words2[0] = words[words.Length / 2];
for (int i = 1; i <= words.Length / 2; i++)
{
    words2[i * 2 - 1] = words[words.Length / 2 - i];
    if (words.Length / 2 + i < words.Length)
    {
        words2[i * 2] = words[words.Length / 2 + i];
    }
}

for (int i = 0; i < words2.Length; i++)
{
    string word = words2[i];
    string newword = "";

    newword += word[word.Length / 2];
    for (int j = 1; j <= word.Length / 2; j++)
    {
        newword += word[word.Length / 2 - j];
        if (word.Length / 2 + j < word.Length)
        {
            newword += word[word.Length / 2 + j];
        }
    }
    words2[i] = newword;
}

foreach (string word in words2)
{
    Console.Write(word + " ");
}