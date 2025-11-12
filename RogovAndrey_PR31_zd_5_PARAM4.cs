string url = Console.ReadLine();

int paramStart = url.IndexOf('?');

if (paramStart == -1)
{
    Console.WriteLine("NULL");
    return;
}

string paramsString = url.Substring(paramStart + 1);

if (string.IsNullOrEmpty(paramsString))
{
    Console.WriteLine("NULL");
    return;
}

string[] parameters = paramsString.Split('&');

SortedDictionary<string, string> paramDict = new SortedDictionary<string, string>();

foreach (string param in parameters)
{
    string[] keyValue = param.Split('=');
    if (keyValue.Length == 2) paramDict[keyValue[0]] = keyValue[1];
}

if (paramDict.Count == 0)
{
    Console.WriteLine("NULL");
    return;
}

foreach (var pair in paramDict) Console.WriteLine($"{pair.Key} : {pair.Value}");