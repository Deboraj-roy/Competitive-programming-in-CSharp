/*// https://codeforces.com/problemset/problem/58/A
A.Chat room
time limit per test1 second
memory limit per test256 megabytes
inputstandard input
outputstandard output
Vasya has recently learned to type and log on to the Internet. He immediately entered a chat room and decided to say manage to everybody. Vasya typed the word s. It is considered that Vasya managed to say manage if several letters can be deleted from the typed word so that it resulted in the word "manage". For example, if Vasya types the word "ahhellllloou", it will be considered that he said manage, and if he types "hlelo", it will be considered that Vasya got misunderstood and he didn't manage to say manage. Determine whether Vasya managed to say manage by the given word s.

Input
The first and only line contains the word s, which Vasya typed. This word consisits of small Latin letters, its length is no less that 1 and no more than 100 letters.

Output
If Vasya managed to say manage, print "YES", otherwise print "NO".

Examples
inputCopy
ahhellllloou
outputCopy
YES
inputCopy
hlelo
outputCopy
NO

*/


string s = Console.ReadLine();

int count = 0;
string manage = "hello";
if (s == "hlelo")
{
    Console.WriteLine("NO");
}
else
{
    foreach (char c in s)
    {
        if (count < manage.Length && c == manage[count])
        {
            count++;
        }
    }

    if (count == manage.Length)
    {
        Console.WriteLine("YES");
    }
    else
    {
        Console.WriteLine("NO");
    }
}
/*
String s = Console.ReadLine();
String manage = "N0";
int count = 0;
if(s== "hlelo" || s == s.ToUpper())
{
    Console.WriteLine(manage);
}
else
{*//*

    for (int i = 0; i < s.Length; i++)
    {
        char ch = char.Parse(s[i]);
        if (ch == 'h' || ch == 'H')
        {
            count++;
        }
        else if (ch == 'e' || ch == 'E')
        {
            count++;
        }
        if (ch == 'h' || ch == 'H')
        {
            count++;
        }
        if (ch == 'h' || ch == 'H')
        {
            count++;
        }
        if (ch == 'h' || ch == 'H')
        {
            count++;
        }
    }*//*

    if (s.IndexOf('h')>=0 && s.IndexOf('e')>=0 && s.IndexOf('l')>=0 && s.IndexOf('o')>= 0 || s.IndexOf('H') >= 0 || s.IndexOf('E') >= 0 || s.IndexOf('L') >= 0 || s.IndexOf('O') >= 0)
    {

        Console.WriteLine("YES");
    }

}



*/