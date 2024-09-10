
int sockMerchant(int n, List<int> ar)
{
    int pairCount = ar.GroupBy(x => x).Select(g => new { g.Key, pair = (int)g.Count() / 2 }).Sum(x => x.pair);
    return pairCount;
}

int n = 9;
List<int> ar = [10, 20, 20, 10, 10, 30, 50, 10, 20];

Console.WriteLine(sockMerchant(n, ar));
Console.ReadLine();