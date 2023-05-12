// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello Bitland, World!");


int size = int.Parse(Console.ReadLine());

int x = 0;
//string[] str= new string[size];
for (int i=0; i<size; i++)
{
    string str = Console.ReadLine();

    if (str[1] == '+')
    {
        x++;
    }
    else
    { x--;}

}
Console.WriteLine(x);
/*
input:
2
X++
--X

output:
0



*/


