using System;
using System.Collections.Generic;
public class Program
{
    public const string input = "1abc2\npqr3stu8vwx\na1b2c3d4e5f\ntreb7uchet";
    List<char> numbers = new() { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
    public static void Main()
    {
        
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