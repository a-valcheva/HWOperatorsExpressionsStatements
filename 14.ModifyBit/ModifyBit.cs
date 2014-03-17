using System;

class ModifyBit
{
    //We are given an integer number n, a bit value v (v=0 or 1) and a position p. Write a sequence of operators (a few lines of 
    //C# code) that modifies n to hold the value v at the position p from the binary representation of n while preserving 
    //all other bits in n. 
    static void Main(string[] args)
    {
        Console.WriteLine("Enter integer number n");
        int numberN = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter index p");
        int indexP = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter value 0 or 1 for the bit at index p");
        int bitValue = int.Parse(Console.ReadLine());

        Console.WriteLine("Binary representation of n");
        Console.WriteLine(Convert.ToString(numberN, 2).PadLeft(16,'0'));

        int mask = bitValue << indexP;
        int result = numberN | mask;
        if (bitValue == 0)
        {
            mask = ~(1 << indexP);
            result = numberN & mask;
        }
        
        Console.WriteLine("Binary result");
        Console.WriteLine(Convert.ToString(result, 2).PadLeft(16, '0'));
        Console.WriteLine("Decimal result");
        Console.WriteLine(result);
    }
}

