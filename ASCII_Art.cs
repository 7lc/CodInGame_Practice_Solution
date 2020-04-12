// Puzzle Solved by Longchang Cui
// 04-11-2020

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;

/**
 * Auto-generated code below aims at helping you parse
 * the standard input according to the problem statement.
 **/
class Solution
{
    static void Main(string[] args)
    {
        int L = int.Parse(Console.ReadLine());
        int H = int.Parse(Console.ReadLine());
        string T = Console.ReadLine();
        
        Dictionary<char,int> dict = new Dictionary<char,int>()
        {
            {'a',1},
            {'b',2},
            {'c',3},
            {'d',4},
            {'e',5},
            
            {'f',6},
            {'g',7},
            {'h',8},
            {'i',9},
            {'j',10},
            
            {'k',11},
            {'l',12},
            {'m',13},
            {'n',14},
            {'o',15},
            
            {'p',16},
            {'q',17},
            {'r',18},
            {'s',19},
            {'t',20},
            
            {'u',21},
            {'v',22},
            {'w',23},
            {'x',24},
            {'y',25},
            {'z',26},
        };
        
        // Convert string to character array
        char[] char_arr = T.ToLower().ToCharArray();
        // Index for alphabet and question mark
        int idx = 0;
        
        for (int i = 0; i < H; i++)
        {
            // Read ASCII art input
            string ROW = Console.ReadLine();
            
            // Convert ASCII string to character array
            char[] char_row = ROW.ToCharArray();
            
            // Print each character line
            for(int j = 0; j < char_arr.Length;j++)
            {
                // if the input character is in dictionary ([a-z],[A-Z])
                //, assign the location to idx variable and multiply the Width of the Row ASCII input
                if(dict.ContainsKey(char_arr[j]) == true)
                    idx = dict[char_arr[j]] * L;
                
                // else assign the question mark index to idx
                else
                    idx = 27 * L;
                
                // Print the ASCII alphabet row
                for(int k = L; k >= 1; k--)
                {
                   Console.Write(char_row[idx-k]);
                }
            }
            // Print next line
            Console.Write("\n");
        }

    }
}
