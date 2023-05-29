using System;

public class MainClass
{

    public static void Main(string[] args)
    {

        // Read the number of test cases
        int t = int.Parse(Console.ReadLine());

        // Loop over the test cases
        for (int i = 0; i < t; i++)
        {

            // Read the length of the arrays
            int n = int.Parse(Console.ReadLine());

            // Read the elements of array a
            int[] a = new int[n];
            string[] tokens = Console.ReadLine().Split(' ');
            for (int j = 0; j < n; j++)
            {
                a[j] = int.Parse(tokens[j]);
            }

            // Read the elements of array b
            int[] b = new int[n];
            tokens = Console.ReadLine().Split(' ');
            for (int j = 0; j < n; j++)
            {
                b[j] = int.Parse(tokens[j]);
            }

            // Merge the arrays
            int[] c = new int[2 * n];
            int j = 0;
            int k = 0;
            while (j < n && k < n)
            {
                if (a[j] < b[k])
                {
                    c[j + k] = a[j];
                    j++;
                }
                else
                {
                    c[j + k] = b[k];
                    k++;
                }
            }

            // Find the maximum length of a subarray consisting of equal values
            int maxLen = 1;
            int currLen = 1;
            for (int l = 1; l < 2 * n; l++)
            {
                if (c[l] == c[l - 1])
                {
                    currLen++;
                }
                else
                {
                    maxLen = Math.Max(maxLen, currLen);
                    currLen = 1;
                }
            }

            // Print the maximum length
            Console.WriteLine(maxLen);
        }
    }
}
