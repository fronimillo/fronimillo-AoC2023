using System;
public class Program
{
    public static char[] numDigits = { '1', '2', '3', '4', '5', '6', '7', '8', '9' };
    public static string[] alphaDigits = { "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
    public static string[] fileInput = File.ReadAllLines(@"C:\Users\hess.camillo\Documents\puzzleinput.txt");
    //public static string[] fileInput = { "two1nine","eightwothree", "abcone2threexyz", "xtwone3four", "4nineeightseven2", "zoneight234", "7pqrstsixteen" };
    public static void Main()
    {
        var convertedLines = new List<string>();
        // Part 2 of Day 1
        foreach (string line in fileInput)
        {
            var lineDuringConversion = line;
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
                while (lineDuringConversion.Contains(searchString))
                {
                    //Console.Write($"search \"{searchString}\" in {line} -> ");
                    // index of number that is in alphaDigits (which equals) searchString
                    var alphaIndex = Array.IndexOf(alphaDigits, searchString);
                    var numValue = alphaIndex + 1;
                    int startIndex = lineDuringConversion.IndexOf(searchString) + 1 ;
                    string numString = numValue.ToString();
                    string newLine = lineDuringConversion.Remove(startIndex, 1);
                    lineDuringConversion = newLine.Insert(startIndex, numString);
                    // add method to id first and last number conversion  (dif ***)
                    // add remove method to go from 5five => 5ive (dif **)
                    // find way to execute line as long as alphabetic number are in line => no multiple lines
                    // => ignore middle conversion => just filter "char" (dif *)
                    // Console.WriteLine(convertedLines);
                }
            }
                    Console.WriteLine(lineDuringConversion);
                    convertedLines.Add(lineDuringConversion);
        }
        // Part 1 of Day 1
        int sumNumber = 0;
        var resultList = new List<int>();
        foreach (var line in convertedLines)
        {
            var digitFirst = line.IndexOfAny(numDigits);
            var digitLast = line.LastIndexOfAny(numDigits);
            var lineResult = $"{line[digitFirst]}{line[digitLast]}";
            var numberResult = int.Parse(lineResult);
            resultList.Add(numberResult);
            sumNumber = sumNumber + numberResult;
        }
        Console.WriteLine(sumNumber);
    }
}