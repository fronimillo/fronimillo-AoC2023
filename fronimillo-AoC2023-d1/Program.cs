using System;
using System.Collections.Generic;
using static System.Net.Mime.MediaTypeNames;
using static System.Runtime.InteropServices.JavaScript.JSType;

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
public class Program
{
    // fix later
    public static char[] digits = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
    public static string input = "1abc2\npqr3stu8vwx\na1b2c3d4e5f\ntreb7uchet";
    public static void Main()
    {
        var splitinput = input.Split('\n');
        var resultList = new List<int>();
        foreach (var line in splitinput)
        {
            int digitFirst = line.IndexOfAny(digits);
            int digitLast = line.LastIndexOfAny(digits);
            var lineResult = $"{digitFirst}{digitLast}";
            var numberResult = int.Parse(lineResult);
            resultList.Add(numberResult);
            Console.WriteLine(numberResult);
        }
    }
}