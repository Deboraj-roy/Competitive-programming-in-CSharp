using System;

class Program
{
    static void Main(string[] args)
    {
        // Read input
        string[] input = Console.ReadLine().Split();
        int H = int.Parse(input[0]);
        int W = int.Parse(input[1]);

        string[] grid = new string[H];
        for (int i = 0; i < H; i++)
        {
            grid[i] = Console.ReadLine();
        }

        // Find the positions of 's', 'n', 'u', 'k', and 'e'
        int[] dr = { 0, 1, 1, 1 }; // row directions
        int[] dc = { 1, -1, 0, 1 }; // column directions

        for (int r = 0; r < H; r++)
        {
            for (int c = 0; c < W; c++)
            {
                if (grid[r][c] != 's')
                    continue;

                for (int i = 0; i < 4; i++)
                {
                    int rr = r;
                    int cc = c;
                    string result = $"{rr + 1} {cc + 1}";

                    for (int j = 1; j < 5; j++)
                    {
                        rr += dr[i];
                        cc += dc[i];
                        if (rr < 0 || rr >= H || cc < 0 || cc >= W || grid[rr][cc] != "nuke"[j])
                            break;

                        if (j == 4)
                            Console.WriteLine(result);
                    }
                }
            }
        }
    }
}
