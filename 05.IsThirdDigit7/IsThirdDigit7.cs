using System;

class IsThirdDigit7
{
    //Write an expression that checks for given integer if its third digit from right-to-left is 7. 
    static void Main(string[] args)
    {
        Console.WriteLine("Enter an integer number:");
        int number = int.Parse(Console.ReadLine());
        int pathToDigit = number / 100;
        int thirdDigit = pathToDigit % 10;
        bool isSeven = thirdDigit == 7;
        Console.WriteLine("Is the third digit 7?\n" + isSeven);
    }
}

