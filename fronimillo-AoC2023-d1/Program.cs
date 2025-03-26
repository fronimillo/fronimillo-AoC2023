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
        {
            // if string contains alphaDigits then convert to numDigits
            // if their the Index is value less than of numericDigits in string line --> Firstdigit
            // if the last alphaDigit in fileInput is the LastIndexofAny 
            foreach (string searchString in alphaDigits)
            {
                if (line.Contains(searchString))
                {
                    string extractedString = line.Substring(line.IndexOf(searchString), searchString.Length);
                    //string[] strArry = extractedString.ToArray();
                    char[] charArray = extractedString.ToCharArray();
                    int digitAlpha = line.IndexOfAny(charArray);
                    char[] charArrayLast = extractedString.ToCharArray();
                    int digitLastAlpha = line.LastIndexOfAny(charArrayLast);
                    Console.WriteLine(charArray);
                    Console.WriteLine(charArrayLast);
                    //Console.WriteLine($"Extracted string: {extractedString}");
                }
            }
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