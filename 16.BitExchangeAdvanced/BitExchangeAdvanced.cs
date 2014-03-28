using System;

class BitExchangeAdvanced
{
    //Write a program that exchanges bits {p, p+1, …, p+k-1} with bits {q, q+1, …, q+k-1} of a given 32-bit unsigned integer. 
    //The first and the second sequence of bits may not overlap. 
    static void Main(string[] args)
    {
        Console.WriteLine("Enter an integer");
        string num = Console.ReadLine();
        uint number;
        if (!uint.TryParse(num, out number))
        {
            Console.WriteLine("out of range");
        }
        else
        {
            EnterWriteData(number);
        }
    }

    private static void EnterWriteData(uint number)
    {
        Console.WriteLine("Enter bit p");
        int bitP = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter bit q");
        int bitQ = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter the length of the sequence");
        int lengthK = int.Parse(Console.ReadLine());

        if (bitP < 0 || bitQ < 0 || lengthK < 0)
        {
            Console.WriteLine("out of range");
        }
        else if (Math.Abs(bitP - bitQ) < lengthK)
        {
            Console.WriteLine("overlapping");
        }
        else if (bitQ + lengthK > 32 || bitP + lengthK > 32)
        {
            Console.WriteLine("out of range");
        }
        else
        {
            uint result = ExchangeBits(number, bitP, bitQ, lengthK);
            Console.WriteLine("Binary result");
            Console.WriteLine(Convert.ToString(result, 2).PadLeft(32, '0'));
            Console.WriteLine("Decimal result");
            Console.WriteLine(result);
        }
    }

    private static uint ExchangeBits(uint number, int bitP, int bitQ, int lengthK)
    {
        uint result = number;
        for (int position = bitP; position < bitP + lengthK; position++)
        {
            uint maskSmall;
            uint maskBig;
            uint moveSmallBit = number >> position;
            uint smallBit = moveSmallBit & 1;
            uint moveBigBit = number >> bitQ;
            uint bigBit = moveBigBit & 1;

            if (smallBit != bigBit)
            {
                if (smallBit == 0)
                {
                    maskSmall = (uint)(1 << position);
                    result = result | maskSmall;
                }
                else
                {
                    maskSmall = (uint)(~(1 << position));
                    result = result & maskSmall;
                }

                if (bigBit == 0)
                {
                    maskBig = (uint)(1 << bitQ);
                    result = result | maskBig;
                }
                else
                {
                    maskBig = (uint)(~(1 << bitQ));
                    result = result & maskBig;
                }
            }
            bitQ++;
        }
        return result;
    }
}

