// See https://aka.ms/new-console-template for more information

Console.WriteLine("Hello, World!");
Console.WriteLine("Hello, World!");

Console.WriteLine("Hello, World!");
Console.WriteLine("Hello, World!");

int[] arr = { 1, 2, 3, 4, 5 };
Console.WriteLine(CalculateAverage(arr));


static double CalculateAverage(int[] values)
{
    double average = 0.0;

    for (int i = 0; i < values.Length; i++)
    {
        average += values[i];
    }

    return average / values.Length;

}