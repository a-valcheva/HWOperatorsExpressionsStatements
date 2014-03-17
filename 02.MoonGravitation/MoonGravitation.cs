using System;

class MoonGravitation
{
    //The gravitational field of the Moon is approximately 17% of that on the Earth. Write a program that calculates the 
    //weight of a man on the moon by a given weight on the Earth.
    static void Main(string[] args)
    {
        Console.WriteLine("Enter man's weight on the Earth:");
        decimal earthWeight = decimal.Parse(Console.ReadLine());
        decimal moonWeight = earthWeight * 0.17m;
        Console.WriteLine("The man's weight on th Moon will be:\n" + moonWeight);
    }
}

