using System;
public class Program
{
    public static char[] numDigits = { '1', '2', '3', '4', '5', '6', '7', '8', '9' };
    public static string[] alphaDigits = { "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
    public static string[] fileInput = File.ReadAllLines(@"C:\Users\hess.camillo\Documents\puzzleinput.txt");
    public static void Main()
    {
        var convertedLines = new List<string>();
        // Part 2 of Day
        foreach (string line in fileInput)
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
                // test above
                if (line.Contains(searchString))
                {
                    Console.Write($"search \"{searchString}\" in {line} -> ");
                    // get index of number that is in alphaDigits (which equals) searchString
                    var foundAtIndex = line.IndexOf(searchString);
                    Console.Write($"found @ idx: {foundAtIndex} ");

                    var alphaIndex = Array.IndexOf(alphaDigits, searchString);
                    Console.Write($"num {alphaIndex} + 1 = ");

                    var numValue = alphaIndex + 1;
                    // this won't work as int can't be compared like bool and
                    // LastIndex of searchString doesn't make any sense --> in this puzzle
                    // 
                    //if (line.IndexOf(searchString) || line.LastIndexOf(searchString))
                    {
                        var removeString = searchString;
                        // do numValue to string 
                        var addString = numValue;
                        int startIndex = line.IndexOf(removeString);
                        //line = line.Insert(startIndex, addString);
                        //Console.WriteLine(line);
                        //Console.WriteLine(numValue);
                        //numValue.ToString($"numValue");
                        // if the foundAtIndex is the first or last do the 
                        string numString = numValue.ToString();
                        Console.WriteLine($"value {numString}");

                        // add remove method here...
                        string newLine = InsertStringAtIndex(line, numString, foundAtIndex);
                        convertedLines.Add(newLine);
                        // line below doesn't work
                        // Intigrate TestSandbox script here 
                        newLine = newLine.Remove(startIndex, 1);
                        Console.WriteLine(newLine);
                        newLine = newLine.Insert(startIndex, numValue);
                        Console.WriteLine(line);
                        // add method to id first and last number conversion
                        // add remove method to go from 5five --> 5ive
                        // find way to execute line as long as alphabetic number are in line --> no multiple lines
                        // ignore middle conversion --> just filter "char" 
                    }
                    Console.WriteLine(convertedLines);
                }
            }
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
    static string InsertStringAtIndex(string searchString, string newLine, int index)
    {
        if (index < 0 || index > searchString.Length)
        {
            throw new ArgumentOutOfRangeException(nameof(index), "Index is out of range.");
        }
        return searchString.Substring(0, index) + newLine + searchString.Substring(index);
    }
}