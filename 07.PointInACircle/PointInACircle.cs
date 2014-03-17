using System;

class PointInACircle
{
    //Write an expression that checks if given point (x,  y) is inside a circle K({0, 0}, 2).
    static void Main(string[] args)
    {
        Console.WriteLine("Enter coordinate x of the point");
        decimal pointX = decimal.Parse(Console.ReadLine());
        Console.WriteLine("Enter coordinate y of the point");
        decimal pointY = decimal.Parse(Console.ReadLine());
        byte radius = 2;
        //Pythagorean Theorem a^2 + b^2 = c^2 ==> (x*x) + (y*y) <= radius * radius.
        //Operator * is faster than Math.Pow()
        bool isInCircle = pointX * pointX + pointY * pointY <= radius * radius;
        Console.WriteLine("Is the given point in the circle?\n{0}", isInCircle);
    }
}

