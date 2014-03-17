using System;

class DivideBy7And5
{
    //Write a Boolean expression that checks for given integer if it can be divided (without remainder) by 7 and 5 in the same time. 
    static void Main(string[] args)
    {
        Console.WriteLine("Enter an integer number:");
        int number = int.Parse(Console.ReadLine());
        bool isDivided = number % 35 == 0;//Least common multiple of 7 and 5 is 35.
        Console.WriteLine("Is the number divided (without remainder) by 7 and 5 in the same time?\n{0}", isDivided);
    }
}

