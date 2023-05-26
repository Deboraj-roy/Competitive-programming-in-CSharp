internal class Program
{
    private static void Main(string[] args)
    {
        string[] input = Console.ReadLine().Split(' ');
        long A = long.Parse(input[0]);
        long B = long.Parse(input[1]);
        long result = A / B;
        if (A%B != 0)
        {
            result += 1;
        }
        Console.WriteLine(result);
    }
}