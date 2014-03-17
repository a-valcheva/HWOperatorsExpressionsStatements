using System;

class CheckBitAtPosition
{
    //Write a Boolean expression that returns if the bit at position p (counting from 0, starting from the right) in given 
    //integer number n has value of 1. 
    static void Main(string[] args)
    {
        Console.WriteLine("Enter integer number n");
        int numberN = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter index p");
        int indexP = int.Parse(Console.ReadLine());

        Console.WriteLine("Binary representation of n");
        Console.WriteLine(Convert.ToString(numberN, 2).PadLeft(16, '0'));

        int moveNumberN = numberN >> indexP;
        bool isBitValue1 = (moveNumberN & 1) == 1;

        Console.WriteLine("Does the bit at position p have value 1?");
        Console.WriteLine(isBitValue1);
    }
}

