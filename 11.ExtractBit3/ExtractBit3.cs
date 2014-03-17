using System;

class ExtractBit3
{
    //Using bitwise operators, write an expression for finding the value of the bit #3 of a given unsigned integer. The bits are 
    //counted from right to left, starting from bit #0. The result of the expression should be either 1 or 0. 
    static void Main(string[] args)
    {
        Console.WriteLine("Enter an unsigned integer");
        uint number = uint.Parse(Console.ReadLine());
        uint moveNumber = number >> 3;
        uint bit = moveNumber & 1;
        Console.WriteLine("The value of the bit #3 is:");
        Console.WriteLine(Convert.ToString(bit, 2));
    }
}

