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
        int speed = int.Parse(Console.ReadLine());
        int lightCount = int.Parse(Console.ReadLine());
        
        // Create List to store string array inputs
        List<string[]> inputsLST = new List<string[]>();
        
        // Read inputs and add them to list
        for (int i = 0; i < lightCount; i++)
        {
            string[] inputs = Console.ReadLine().Split(' ');
            inputsLST.Add(inputs);
        }
        
        // Read each distance and duration and test if the speed can pass all the lights
        for (int i = 0; i < lightCount; i++)
        {
            
            int distance = int.Parse(inputsLST[i][0]);
            int duration = int.Parse(inputsLST[i][1]);
            
            // The formula below is from Rober Eisele's blog 
            // https://www.xarg.org/puzzle/codingame/aneo-sponsored-puzzle/
            // t = distance / ((1000/3600) * speed) = (18 * distance / 5 * speed) % 2*duration
            // (18 * distance) % (2 * 5 * speed * duration) < 5 * speed * duration
            if ((18 * distance) % (10 * speed * duration) >= (5 * speed * duration)) {
                speed--; // Reduce speed
                i = -1; // Start the loop again
            }
            
        }
        
        Console.WriteLine(speed);

    }
}
