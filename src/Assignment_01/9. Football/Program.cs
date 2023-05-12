String str = Console.ReadLine();
int count0 = 0;
int count1 = 0;
String situation = "NO";

for (int i = 0; i < str.Length; i++)
{
    if (str[i] == '1')
    {
        if (i > 0)
        {
            if (str[i]=='1' && str[i - 1] == '1')
            {
                count1++;
                if (count1 >= 7)
                {
                    situation = "YES";
                }
            }
            else
            {
                count1 = 1;
            }
        }
        else
        {

            count1 = 1;
        }
    }


    else
    {
        if (i > 0)
        {
            if (str[i] == '0' && str[i - 1] == '0')
            {
                count0++;
                if (count0 >= 7)
                {
                    situation = "YES";
                }
            }
            else
            {
                count0 = 1;
            }
        }
        else
        {

            count0 = 1;
        }

    }
//    else if (str[i].Equals("0"))
/*
    else if (str[i]=='0')
 {
        if (i > 0)
        {
            if (str[i] == '0' && str[i - 1] == '0')
            {
                count0++;

                if (count0 >= 7)
                {
                    situation = "YES";
                }
            }
            else
            {
                count0 = 1;
            }
        }

        count0 = 1;
    }*/


}
Console.WriteLine(situation);

/*Solved
 * 
 * 
Petya loves football very much. One day, as he was watching a football match, he was writing the players' current positions on a piece of paper. To simplify the situation he depicted it as a string consisting of zeroes and ones. A zero corresponds to players of one team; a one corresponds to players of another team. If there are at least 7 players of some team standing one after another, then the situation is considered dangerous. For example, the situation 00100110111111101 is dangerous and 11110111011101 is not. You are given the current situation. Determine whether it is dangerous or not.

Input
The first input line contains a non-empty string consisting of characters "0" and "1", which represents players. The length of the string does not exceed 100 characters. There's at least one player from each team present on the field.

Output
Print "YES" if the situation is dangerous. Otherwise, print "NO".

 solved
 */