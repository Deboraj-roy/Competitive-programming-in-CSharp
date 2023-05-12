int kg = int.Parse(Console.ReadLine());
if(kg > 2)
{
    if (kg % 2 == 0)
    {
        Console.WriteLine("YES");
    }
    else
    {
        Console.WriteLine("NO");
    }
}
else
{
    Console.WriteLine("NO");
}

/*
https://codeforces.com/problemset/problem/4/A

ne hot summer day Pete and his friend Billy decided to buy a watermelon. They chose the biggest and the ripest one, in their opinion. After that the watermelon was weighed, and the scales showed w kilos. They rushed home, dying of thirst, and decided to divide the berry, however they faced a hard problem.

Pete and Billy are great fans of even numbers, that's why they want to divide the watermelon in such a way that each of the two parts weighs even number of kilos, at the same time it is not obligatory that the parts are equal. The boys are extremely tired and want to start their meal as soon as possible, that's why you should help them and find out, if they can divide the watermelon in the way they want. For sure, each of them should get a part of positive weight.

Input
The first (and the only) input line contains integer number w (1 ≤ w ≤ 100) — the weight of the watermelon bought by the boys.

Output
Print YES, if the boys can divide the watermelon into two parts, each of them weighing even number of kilos; and NO in the opposite case.


*/

/*
To check if a letter is present in an input string in C#, you can use the IndexOf method of the string class. Here's an example:

csharp
Copy code
using System;

namespace LetterCheckExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a string: ");
            string input = Console.ReadLine();

            Console.WriteLine("Enter a letter to search for: ");
            char letter = Console.ReadKey().KeyChar;

            if (input.IndexOf(letter) >= 0)
            {
                Console.WriteLine("The letter was found in the input string.");
            }
            else
            {
                Console.WriteLine("The letter was not found in the input string.");
            }
        }
    }
}
In this example, the user is prompted to enter a string and a letter. The code then checks if the input string contains the letter by calling the IndexOf method and printing a message accordingly. If the IndexOf method returns a value greater than or equal to 0, it means that the letter was found in the input string.

*/

