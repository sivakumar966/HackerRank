// sockMerchant --------------------------------------------------------------------------------------------------------------

using System.Linq;

int n = 9;
List<int> ar = [10, 20, 20, 10, 10, 30, 50, 10, 20];
Console.WriteLine($"sockMerchant : {sockMerchant(n, ar)}");

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

Console.WriteLine($"countingValleys : {countingValleys(steps, path)}");

// jumpingOnClouds -------------------------------------------------------------------------------------------------------------- 

List<int> clouds1 = [0, 0, 1, 0, 0, 1, 0]; // 4
List<int> clouds2 = [0, 0, 0, 0, 1, 0]; // 3
List<int> clouds3 = [0, 0, 0, 0, 1, 0, 1]; // 3

int jumpingOnClouds(List<int> c)
{
    int jumpCount = 0;
    for (int i = 0; i < c.Count - 1;)
    {
        if (i + 2 < c.Count && c[i + 2] == 0)
        {
            jumpCount++;
            i += 2;
        }
        else if (i + 1 < c.Count && c[i + 1] == 0)
        {
            jumpCount++;
            i++;
        }
        else
        {
            i++;
        }



    }
    return jumpCount;
}

Console.WriteLine($"jumpingOnClouds - clouds1: {jumpingOnClouds(clouds1)}");
Console.WriteLine($"jumpingOnClouds - clouds2: {jumpingOnClouds(clouds2)}");
Console.WriteLine($"jumpingOnClouds - clouds3: {jumpingOnClouds(clouds3)}");

// -------------------------------------------------------------------------------------------------------------- 
Console.ReadLine();