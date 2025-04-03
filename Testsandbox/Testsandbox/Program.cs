// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
public class Program
{
    public static string line = "hcpjssql4kjhbcqzkvr2fivebpllzqbkhg";
    public static void Main()
    {
        var removeString = "five";
        var addString = "5";
        // should be var for non test programm
        int startIndex = line.IndexOf(removeString);
        Console.WriteLine($"this is before: \"{line}\" ");
        line = line.Remove( startIndex, 1 );
        Console.WriteLine(line);
        line = line.Insert( startIndex, addString );
        Console.WriteLine(line);
    } 
}