﻿using System;

class InsideCircleOutsideRectangle
{
    //Write an expression that checks for given point (x, y) if it is within the circle K({1, 1}, 1.5) and out of the rectangle 
    //R(top=1, left=-1, width=6, height=2). 
    static void Main(string[] args)
    {
        Console.WriteLine("Enter coordinate x of the point");
        decimal pointX = decimal.Parse(Console.ReadLine());
        Console.WriteLine("Enter coordinate y of the point");
        decimal pointY = decimal.Parse(Console.ReadLine());
        decimal radius = 1.5m;
        //Pythagorean Theorem a^2 + b^2 = c^2 ==> (x*x) + (y*y) <= radius * radius.
        //Operator * is faster than Math.Pow()
        bool isInCircle = (pointX - 1) * (pointX - 1) + (pointY - 1) * (pointY - 1) <= radius * radius;
        //Every y below 1 is in the rectangle or outside the circle, or both.
        if (isInCircle && pointY > 1)
        {
            Console.WriteLine("YES");
        }
        else
        {
            Console.WriteLine("NO");
        }
    }
}

