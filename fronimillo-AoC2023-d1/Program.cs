using System;
using System.Collections.Generic;
using static System.Net.Mime.MediaTypeNames;
using static System.Runtime.InteropServices.JavaScript.JSType;
public class Program
{
    public const string input = "1abc2\npqr3stu8vwx\na1b2c3d4e5f\ntreb7uchet";
    List<char> numbers = new() { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
    public static void Main()
    {
/*
 * read out every position of string
 * for every char do:
 *  find first digit and save its position
 *  find next digit and save its position
 *  do this until no chars that are digits are left
 *  if there is only one instance of a digit in a string
 *      duplicate it and skip last-digit indentfication
 *      digit with highest position number "wins" others are "deleted"
 *  this digit is called last digit
 *      combine first digit and last digit
 *  this Digit is called codenumber and is exactly two chars long
 *      do this for every string
 *      this is called codesum and is undefined chars long
 * add all codenumber only when all strings have been "decoded"
*/

        int i = 0;
        foreach (char code in input)
        {
            if (Char.IsNumber(code))
            {
                //foreach (char twocode in code)
                //foreach (char codes in input)
                i++;
                Console.Write($"{code}");
                if (i >= 2)
                {
                    //Console.WriteLine($"{code}");
                    Console.Write(" ");
                    i = 0;
                }

            }
            //i = 0;
        }
    }
}  