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
class Player
{
    static void Main(string[] args)
    {
        string[] inputs;
        inputs = Console.ReadLine().Split(' ');
        int W = int.Parse(inputs[0]); // width of the building.
        int H = int.Parse(inputs[1]); // height of the building.
        int N = int.Parse(Console.ReadLine()); // maximum number of turns before game over.
        inputs = Console.ReadLine().Split(' ');
        int X0 = int.Parse(inputs[0]);
        int Y0 = int.Parse(inputs[1]);

        //2D bisection formula: (x,y)=(x_1+1/2*(x_2 − x_1),y_1+1/2*(y_2 − y_1))
        //x_1 = 0, y_1 = 0, x_2 = W−1,y_2 = H−1
        
        int batX = 0;
        int batY = 0;
        
        int biX = W-1;
        int biY = H-1;
        
        int moveX = X0;
        int moveY = Y0;
        
        
        // game loop
        while (true)
        {
            string bombDir = Console.ReadLine(); // the direction of the bombs from batman's current location (U, UR, R, DR, D, DL, L or UL)
          
            // Write an action using Console.WriteLine()
            // To debug: Console.Error.WriteLine("Debug messages...");
            
            if(bombDir.Contains("U"))
            {
                biY = moveY - 1;
            }
            
            else if(bombDir.Contains("D"))
            {
                batY = moveY + 1;
            }
            
            if(bombDir.Contains("L"))
            {
                biX = moveX - 1;
            }
            
            else if(bombDir.Contains("R"))
            {
                batX = moveX + 1;
            }
            
            //Console.WriteLine(W.ToString()+H.ToString()+N.ToString());
            moveX = batX + (biX-batX)/2;
            moveY = batY + (biY-batY)/2;

            // the location of the next window Batman should jump to.
            Console.WriteLine(moveX.ToString()+" "+moveY.ToString());
        }
    }
}
