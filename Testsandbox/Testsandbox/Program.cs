// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
public class Program
{
    public static string line = "hcpjssql4kjhbcqzkvr2fivebpllzqbkhg";
    public static void Main()
    {
        var removeString = "five";
        var fin ="";
        int startIndex = 20;
        int endIndex = 25;
        int i = 0;
        if (i == 0) 
        {
            Console.WriteLine($"this is before: \"{line}\" ");
            removeString.Remove( startIndex, endIndex );
            Console.WriteLine(fin);
        }
    }
}