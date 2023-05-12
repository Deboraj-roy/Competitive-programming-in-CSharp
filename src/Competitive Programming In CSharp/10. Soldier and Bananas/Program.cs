/*
string number = Console.ReadLine();
string[] numbers = number.Split(' ');
int k = numbers[0];*/

string input = Console.ReadLine();
string[] numbers = input.Split(' ');
int k = int.Parse(numbers[0]);
int n = int.Parse(numbers[1]);
int w = int.Parse(numbers[2]);

int sum = 0;
/*
int k, w, n, sum=0;
k = int.Parse(Console.ReadLine());

n = int.Parse(Console.ReadLine());

w = int.Parse(Console.ReadLine());*/


for (int i = 1; i <= w; i++)
{
    sum += i * k;

}

if(sum > n)
{
    Console.WriteLine(sum - n);

}

else
    Console.WriteLine(0);










/*https://codeforces.com/problemset/problem/546/A
      //
      //A.Soldier and Bananas
time limit per test1 second
memory limit per test256 megabytes
inputstandard input
outputstandard output
A soldier wants to buy w bananas in the shop. He has to pay k dollars for the first banana, 2k dollars for the second one and so on (in other words, he has to pay i·k dollars for the i-th banana).

He has n dollars. How many dollars does he have to borrow from his friend soldier to buy w bananas?

Input
The first line contains three positive integers k, n, w (1  ≤  k, w  ≤  1000, 0 ≤ n ≤ 109), the cost of the first banana, initial number of dollars the soldier has and number of bananas he wants.

Output
Output one integer — the amount of dollars that the soldier must borrow from his friend. If he doesn't have to borrow money, output 0.

*/