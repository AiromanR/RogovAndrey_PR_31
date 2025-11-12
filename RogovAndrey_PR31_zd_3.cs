int n = int.Parse(Console.ReadLine());
string[] input = Console.ReadLine().Split();
int count = 2 * n;
int[] diameters = new int[count];

for (int i = 0; i < count; i++)
{
    diameters[i] = int.Parse(input[i]);
}

int[] index = new int[count];
for (int i = 0; i < count; i++)
{
    index[i] = i + 1;
}

for (int i = 0; i < count - 1; i++)
{
    for (int j = 0; j < count - i - 1; j++)
    {
        if (diameters[j] > diameters[j + 1])
        {
            (diameters[j], diameters[j + 1]) = (diameters[j + 1], diameters[j]);
            (index[j], index[j + 1]) = (index[j + 1], index[j]);
        }
    }
}

for (int i = 0; i < n; i++)
{
    int bigIndex = index[count - 1 - 2 * i];
    int smallIndex = index[2 * i];
    Console.WriteLine($"{bigIndex} {smallIndex}");
}