using System;

class Trapezoids
{
    //Write an expression that calculates trapezoid's area by given sides a and b and height h. 
    static void Main(string[] args)
    {
        Console.WriteLine("Enter side a:");
        decimal sideA = decimal.Parse(Console.ReadLine());
        Console.WriteLine("Enter side b:");
        decimal sideB = decimal.Parse(Console.ReadLine());
        Console.WriteLine("Enter height h:");
        decimal heightH = decimal.Parse(Console.ReadLine());
        decimal area = ((sideA + sideB) / 2) * heightH;
        Console.WriteLine("The trapezoid's area is: " + area);
    }
}

