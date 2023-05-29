/*https://codeforces.com/contest/1831/problem/0*/
 
 
    int number = int.Parse(Console.ReadLine());
 
    for (int i = 0; i < number; i++)
    {
     
        int n = int.Parse(Console.ReadLine());
     
        int[] a = new int[n];
        string[] tokens = Console.ReadLine().Split(' ');
        for (int j = 0; j < n; j++)
        {
            a[j] = int.Parse(tokens[j]);
        }
         
        int[] b = new int[n];
     
        for (int j = 0; j < n; j++)
        {
            b[j] = j + 1;
        }
         
        Array.Sort(b);
     
        for (int j = 0; j < n; j++)
        {
            Console.Write(b[j] + " ");
        }
         
        Console.WriteLine();
    } 
