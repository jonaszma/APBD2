// See https://aka.ms/new-console-template for more information

Console.WriteLine("Hello, User!!!!");
Console.WriteLine("Hello, User!!!!");
int[] arr = new[] { 1, 2, 3, 4 };
Console.WriteLine(GetAvggg(arr));
Console.WriteLine(GetMax(arr));
static double GetAvggg(int[] arr)
{
    int summ = 0;
    foreach (var num in arr)
    {
        summ += num;
    }

    return (double)summ / arr.Length;
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
