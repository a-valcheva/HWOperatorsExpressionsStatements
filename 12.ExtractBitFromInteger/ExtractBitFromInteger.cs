using System;

class ExtractBitFromInteger
{
    //Write an expression that extracts from given integer n the value of given bit at index p. 
    static void Main(string[] args)
    {
        Console.WriteLine("Enter integer number n");
        int numberN = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter index p");
        int indexP = int.Parse(Console.ReadLine());
        Console.WriteLine("Binary representation of n");
        Console.WriteLine(Convert.ToString(numberN, 2).PadLeft(16, '0'));
        int moveNumberN = numberN >> indexP;
        int bit = moveNumberN & 1;
        Console.WriteLine("The value of the given bit at index p is");
        Console.WriteLine(Convert.ToString(bit, 2));
    }
}

