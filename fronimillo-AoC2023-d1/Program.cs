using System;
using System.Collections.Generic;
using static System.Net.Mime.MediaTypeNames;
using static System.Runtime.InteropServices.JavaScript.JSType;

public class Program
{
    public static char[] digits = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
    public static string alphabeticDigits = "one\ntwo\nthree\nfour\nfive\nsix\nseven\neight\nnine";
    public static string[] fileInput = File.ReadAllLines(@"C:\Users\hess.camillo\Documents\puzzleinput.txt");
    public static void Main()
    {
        int sumNumber = 0;
        var splitinput = alphabeticDigits.Split('\n');
        var resultList = new List<int>();
        
        foreach (var line in fileInput)
        {
            int digitFirst = line.IndexOfAny(digits);
            int digitLast = line.LastIndexOfAny(digits);
            var lineResult = $"{line[digitFirst]}{line[digitLast]}";
            var numberResult = int.Parse(lineResult);
            resultList.Add(numberResult);
            sumNumber = sumNumber + numberResult;
        }
        Console.WriteLine(sumNumber);
    }
}