
/*
https://codeforces.com/problemset/problem/617/A
      //A.Elephant
time limit per test1 second
memory limit per test256 megabytes
inputstandard input
outputstandard output
An elephant decided to visit his friend. It turned out that the elephant's house is located at point 0 and his friend's house is located at point x(x > 0) of the coordinate line. In one step the elephant can move 1, 2, 3, 4 or 5 positions forward. Determine, what is the minimum number of steps he need to make in order to get to his friend's house.

Input
The first line of the input contains an integer x (1 ≤ x ≤ 1 000 000) — The coordinate of the friend's house.

Output
Print the minimum number of steps that elephant needs to make to get from point 0 to point x.

Examples
inputCopy
5
outputCopy
1
inputCopy
12
outputCopy
3
Note
In the first sample the elephant needs to make one step of length 5 to reach the point x.

In the second sample the elephant can get to point x if he moves by 3, 5 and 4. There are other ways to get the optimal answer but the elephant cannot reach x in less than three moves.

*/
 /*long l = long.Parse(Console.ReadLine());

int count = 1;
if (l> 5)
{

    for ( long i = 0; i < l ; i++)
    {
        if (l >= 5)
        {if (l == 5)
            {
                count++;
                break;
            }

             else
                l -= 5; 
                count++;
        }
        else if (l >= 4)
        {
            if (l == 4)
            {
                count++;
                break;
            }
            else
                l -= 4; 
                count++;
        }
        else if (l >= 3)
        {
            if (l == 3)
            {
                count++;
                break;
            }
            else
                l -= 3; 
                count++;
        }

        else if (l >= 2)
        {
            if (l == 2)
            {
                count++;
                break;
            }
            else
                l -= 2;
                count++;
        }
        else if (l >= 1)
        {
            if (l == 1)
            {
                count++;
                break;
            }
            l -= 1;

            count++;

        }

    }
}*/

int input = int.Parse(Console.ReadLine());
int[] step = new int[] {5, 4, 3, 2, 1};
int count = 1;
if (input > 5)
{
    if (input%5!=0)
    {
        count= input/5 + 1;   
    }

    else
    {
        count= input/5;
    }

}
Console.WriteLine(count);