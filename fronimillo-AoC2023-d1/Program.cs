using System;
using System.Collections.Generic;
using static System.Net.Mime.MediaTypeNames;
using static System.Runtime.InteropServices.JavaScript.JSType;
public class Program
{
    public static char[] numDigits = { '1', '2', '3', '4', '5', '6', '7', '8', '9' };
    public static string[] alphaDigits = { "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
    public static string[] fileInput = File.ReadAllLines(@"C:\Users\hess.camillo\Documents\puzzleinput.txt");
    public static void Main()
    {
        // Part 2 of Day
        foreach (string line in fileInput)
        // (char line in fileInput)
        {
            /*Instructions         
            // if string contains alphaDigits then convert to numDigits:
            // if line contains any alpha digits then get Index number for every alphaDigit in line
            // Alpha Digits with highest or lowest will get converted
            // Conversion :
            // * find string in alphaDigit --> get Index --> index matches with 
            // * id first and last digit via index
            // * -->
            // Convert to "new" Digit Last and First accordingly
            // do old code
            // if their the Index is value less than of numericDigits in string line --> Firstdigit
            // if the last alphaDigit in fileInput is the LastIndexofAny 
            // mistake here : looking at searchstring not input string --> double output & no first and last digits
            */
            foreach (string searchString in alphaDigits)
            {
                if (line.Contains(searchString))
                {
                    Console.WriteLine($"{line} {searchString}");
                    // get index of number that is in alphaDigits (which equals) searchString 
                    var getIndex = line.IndexOf(searchString);
                    var getAlphaIndex = Array.IndexOf(alphaDigits, searchString);
                    var numValue = getAlphaIndex + 1;
                    Console.WriteLine(numValue);
                    numValue.ToString($"numValue");
                    Console.WriteLine(numValue);
                    // to string numValue --> corrected Value
                    // instert corrected Value into line via its index from getIndex
                    // 
                    // new Idea for Solution
                    // put extracted numValue "back" to line Index "position" (line 5 would be at index 22)
                    // --> hcpjssql4kjhbcqzkvr2fivebpllzqbkhg turns into --> hcpjssql4kjhbcqzkvr25ivebpllzqbkhg  
                    // adapt to work with old code
                }
            }
            //foreach (string lastString in alphaDigits)
        }
        // Part 1 of Day 1
        int sumNumber = 0;
        var resultList = new List<int>();
        foreach (var line in fileInput)
        {
            int digitFirst = line.IndexOfAny(numDigits);
            int digitLast = line.LastIndexOfAny(numDigits);
            var lineResult = $"{line[digitFirst]}{line[digitLast]}";
            var numberResult = int.Parse(lineResult);
            resultList.Add(numberResult);
            sumNumber = sumNumber + numberResult;
        }
        Console.WriteLine(sumNumber);
    }
}