/*// See https://aka.ms/new-console-template for more information



// C# program to Convert a string
// to a Character array
// using Naive Approach

using System;

public class GFG
{

    static public void Main()
    {
        string str = "GeeksForGeeks";

        // Creating array of string length
        char[] ch = new char[str.Length];

        // Copy character by character into array
        for (int i = 0; i < str.Length; i++)
        {
            ch[i] = str[i];
        }

        // Printing content of array
        foreach (char c in ch)
        {
            Console.WriteLine(c);
        }
    }
}

*/

//Console.WriteLine("Hello Assignment 01, World!");
int size = int.Parse(Console.ReadLine());
string[] input = new string[size];
for (int i = 0; i < size; i++)
{
    input[i] = Console.ReadLine();
}

int len = 0;

for (int i = 0; i < size; i++)
{
    if (input[i].Length>10)
    {

        len = input[i].Length - 2;
        string str = input[i];
        Console.WriteLine($"{str[0]}{len}{str[len + 1]}");
        //Console.WriteLine($"{input[0][0]}{len}{input[0][len + 1]}");
    }
    else
    {
        Console.WriteLine(input[i]);
    }
}
/*

Way Too Long Words
  
    input

    4
word
localization
internationalization
pneumonoultramicroscopicsilicovolcanoconiosis

    output

    word
l10n
i18n
p43s
*/