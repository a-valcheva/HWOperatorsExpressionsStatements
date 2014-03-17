using System;

class OddOrEven
{
    //Write an expression that checks if given integer is odd or even. 
    static void Main(string[] args)
    {
        Console.WriteLine("Enter an integer number:");
        int number = int.Parse(Console.ReadLine());
        if (number % 2 == 0)
        {
            Console.WriteLine("{0} is even.", number);
        }
        else
        {
            Console.WriteLine("{0} is odd.", number);
        }
    }
}

