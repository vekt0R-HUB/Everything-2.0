using Everything;

internal class Program
{
    private static void Main(string[] args)
    {
        var x = Searching.Search(@"C:\Users\vekt0R\Documents\Personal chest","Arcane");
        foreach (var item in x)
        {
            System.Console.WriteLine(item);
        }
    }
}