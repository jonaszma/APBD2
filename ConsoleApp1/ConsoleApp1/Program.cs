// See https://aka.ms/new-console-template for more information

Console.WriteLine("Hello, User!!!!");
Console.WriteLine("Hello, User!!!!");
int[] arr = new[] { 1, 2, 3, 4 };
Console.WriteLine(GetAvg(arr));
Console.WriteLine(GetMax(arr));
static double GetAvg(int[] arr)
{
    int ssum = 0;
    foreach (var num in arr)
    {
        ssum += num;
    }

    return (double)ssum / arr.Length;
}

static double GetMax(int[] arr)
{
    int sum = arr[0];
    foreach (var num in arr)
    {
        if (num > sum)
        {
            sum = num;
        }
    }

    return (double)sum;
}
