﻿/*
 * https://codeforces.com/problemset/problem/122/A
 * 
 * A.Lucky Division
time limit per test2 seconds
memory limit per test256 megabytes
inputstandard input
outputstandard output
Petya loves lucky numbers. Everybody knows that lucky numbers are positive integers whose decimal representation contains only the lucky digits 4 and 7. For example, numbers 47, 744, 4 are lucky and 5, 17, 467 are not.

Petya calls a number almost lucky if it could be evenly divided by some lucky number. Help him find out if the given number n is almost lucky.

Input
The single line contains an integer n (1 ≤ n ≤ 1000) — the number that needs to be checked.

Output
In the only line print "YES" (without the quotes), if number n is almost lucky. Otherwise, print "NO" (without the quotes).

Examples
inputCopy
47
outputCopy
YES
inputCopy
16
outputCopy
YES
inputCopy
78
outputCopy
NO
Note
Note that all lucky numbers are almost lucky as any number is evenly divisible by itself.

In the first sample 47 is a lucky number. In the second sample 16 is divisible by 4.

*/



int input = int.Parse(Console.ReadLine());
if (input % 4 == 0 || input % 7 == 0 || input % 74 == 0 || input % 47 == 0 || input % 474 == 0 || input % 447 == 0 || input % 477 == 0 || input % 744 == 0)
{
    Console.WriteLine("YES");
}
else
{
    Console.WriteLine("NO");
}