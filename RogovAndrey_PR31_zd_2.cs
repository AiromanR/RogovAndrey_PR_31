int n = int.Parse(Console.ReadLine());

for (int i = 0; i < n; i++)
{
    string word = Console.ReadLine();
    string upperWord = word.ToUpper();
    bool isPalindrome = true;

    for (int j = 0; j < upperWord.Length / 2; j++)
    {
        if (upperWord[j] != upperWord[upperWord.Length - 1 - j])
        {
            isPalindrome = false;
            break;
        }
    }

    Console.WriteLine(isPalindrome ? "YES" : "NO");
}