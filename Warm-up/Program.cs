// sockMerchant --------------------------------------------------------------------------------------------------------------

int n = 9;
List<int> ar = [10, 20, 20, 10, 10, 30, 50, 10, 20];
Console.WriteLine(sockMerchant(n, ar));

int sockMerchant(int n, List<int> ar)
{
    int pairCount = ar.GroupBy(x => x).Select(g => new { g.Key, pair = (int)g.Count() / 2 }).Sum(x => x.pair);
    return pairCount;
}


// countingValleys -------------------------------------------------------------------------------------------------------------- 
int steps = 8;
string path = "UDDDUDUU";

int countingValleys(int steps, string path)
{
    int up = 0, down = 0, current = 0;

    foreach (char c in path)
    {


        if (c == 'U')
        {
            current++;
            if (current == 0)
                down++;
        }

        if (c == 'D')
        {
            current--;
            if (current == 0)
                up++;
        }

    }

    return down;
}

Console.WriteLine(countingValleys(steps, path));






// -------------------------------------------------------------------------------------------------------------- 
Console.ReadLine();