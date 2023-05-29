using System;

class Program
{
    static long[] factorial;

    static void Main(string[] args)
    {
        int t = int.Parse(Console.ReadLine());

        // Precompute factorials modulo 998244353
        ComputeFactorials();

        for (int i = 0; i < t; i++)
        {
            string[] input = Console.ReadLine().Split(' ');
            int n = int.Parse(input[0]);
            int k = int.Parse(input[1]);

            int[][] intervals = new int[k][];
            for (int j = 0; j < k; j++)
            {
                string[] interval = Console.ReadLine().Split(' ');
                int l = int.Parse(interval[0]);
                int r = int.Parse(interval[1]);
                intervals[j] = new int[] { l, r };
            }

            long result = CountHyperregularBracketSequences(n, intervals);
            Console.WriteLine(result);
        }
    }

    static long CountHyperregularBracketSequences(int n, int[][] intervals)
    {
        long[] dp = new long[n + 1];
        dp[0] = 1;

        for (int i = 1; i <= n; i++)
        {
            for (int j = 0; j < intervals.Length; j++)
            {
                int l = intervals[j][0];
                int r = intervals[j][1];
                if (i - l >= 0)
                {
                    dp[i] = (dp[i] + dp[i - l]) % 998244353;
                    if (i - r - 1 >= 0)
                    {
                        dp[i] = (dp[i] - dp[i - r - 1] + 998244353) % 998244353;
                    }
                }
            }
        }

        return dp[n];
    }

    static void ComputeFactorials()
    {
        int maxN = 3 * 105;
        factorial = new long[maxN + 1];
        factorial[0] = 1;

        for (int i = 1; i <= maxN; i++)
        {
            factorial[i] = (factorial[i - 1] * i) % 998244353;
        }
    }
}
