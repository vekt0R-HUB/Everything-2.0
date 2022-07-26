using Everything;

internal class Program
{
    private static void Main(string[] args)
    {
        var x = Searching.Search("MiddleNames");
        foreach (var item in x)
        {
            System.Console.WriteLine(item);
        }
    }
}