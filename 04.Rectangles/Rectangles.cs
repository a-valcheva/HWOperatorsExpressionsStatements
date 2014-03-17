using System;

class Rectangles
{
    //Write an expression that calculates rectangle’s perimeter and area by given width and height. 
    static void Main(string[] args)
    {
        Console.WriteLine("Enter the rectangle's width:");
        decimal width = decimal.Parse(Console.ReadLine());
        Console.WriteLine("Enter the rectangle's height:");
        decimal height = decimal.Parse(Console.ReadLine());

        decimal area = width * height;
        decimal perimeter = 2 * (width + height);

        //Two separated methods to check before printing if floating point needed.
        PrintPerimeter(perimeter);
        PrintArea(area);
    }

    private static void PrintArea(decimal area)
    {
        int testArea = (int)area;
        if (area > testArea)
        {
            Console.WriteLine("Area: " + area);
        }
        else
        {
            Console.WriteLine("Area: " + testArea);
        }
    }

    private static void PrintPerimeter(decimal perimeter)
    {
        int testPerimeter = (int)perimeter;
        if (perimeter > testPerimeter)
        {
            Console.WriteLine("Perimeter: " + perimeter);
        }
        else
        {
            Console.WriteLine("Perimeter: " + testPerimeter);
        }
    }
}

