using System;

class FourDigitNumberV2
{
/*     Write a program that takes as input a four-digit number in format abcd (e.g. 2011) and performs the following:
        •	Calculates the sum of the digits (in our example 2+0+1+1 = 4).
        •	Prints on the console the number in reversed order: dcba (in our example 1102).
        •	Puts the last digit in the first position: dabc (in our example 1201).
        •	Exchanges the second and the third digits: acbd (in our example 2101).
       The number has always exactly 4 digits and cannot start with 0. 
*/

    static void Main(string[] args)
    {
        Console.WriteLine("Enter four-digit number:");
        string number = Console.ReadLine();
        while (number.StartsWith("0") || number.Length != 4)
        {
            Console.WriteLine("The number must be exactly 4 digits and cannot start with 0. Please, try again!");
            number = Console.ReadLine();
        }
        int sum = 0;
        string numReverse = "r";
        for (int i = 0; i < number.Length; i++)
        {
            sum += int.Parse(number[i].ToString());
            numReverse = numReverse.Insert(0, number[i].ToString());
        }
        numReverse = numReverse.Remove(4, 1);
        Console.WriteLine(sum);
        Console.WriteLine(numReverse);
        string lastAtFirstPosition = (number.Insert(0, number[3].ToString())).Remove(4);
        Console.WriteLine(lastAtFirstPosition);
        string exchangeSecondThird = (number.Insert(1, number[2].ToString())).Remove(3,1);
        Console.WriteLine(exchangeSecondThird);
        
    }
}

