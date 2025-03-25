using System;
using System.Collections.Generic;
using static System.Net.Mime.MediaTypeNames;
using static System.Runtime.InteropServices.JavaScript.JSType;

public class Program
{
    public static char[] numDigits = { '1', '2', '3', '4', '5', '6', '7', '8', '9' };
    public static string[] alphaDigits = { "one", "two", "nthree", "nfour", "five", "six", "nseven", "eight", "nine" };
    public static string[] fileInput = File.ReadAllLines(@"C:\Users\hess.camillo\Documents\puzzleinput.txt");
    public static void Main()
    {
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
        //////////////////////////////////////////////////////////////////////////////
        // Part 2 of Day 1
        foreach ( var line in fileInput)
        {
            
        }
    }
}