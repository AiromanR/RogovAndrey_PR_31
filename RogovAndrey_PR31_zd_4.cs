string[] sizes = Console.ReadLine().Split();
int noteLength = int.Parse(sizes[0]);
int newspaperLength = int.Parse(sizes[1]);

string note = Console.ReadLine();
string newspaper = Console.ReadLine();

string[] noteWords = note.Split(' ');
string[] newspaperWords = newspaper.Split(' ');


Dictionary<string, int> wordCount = new Dictionary<string, int>();

foreach (string word in newspaperWords)
{
    if (wordCount.ContainsKey(word)) wordCount[word]++;
    else wordCount[word] = 1;
}

foreach (string word in noteWords)
{
    if (wordCount.ContainsKey(word) && wordCount[word] > 0) wordCount[word]--;
    
    else
    {
        Console.WriteLine(word);
        return;
    }
}

Console.WriteLine("GOOD NOTE");