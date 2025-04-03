// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
public class Program
{
    public static string line = "hcpjssql4kjhbcqzkvr2fivebpllzqbkhg";
    public static void Main()
    {
        var removeString = "five";
        // should be var for non test programm
        int startIndex = line.IndexOf(removeString);
        int count = removeString.Length;
        Console.WriteLine($"this is before: \"{line}\" ");
        line = line.Remove( startIndex, count );
        Console.WriteLine(line);
    } 
}