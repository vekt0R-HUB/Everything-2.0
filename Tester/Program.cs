using Everything;

internal class Program
{
    private static void Main(string[] args)
    {
        var x = Searching.Search(@"C:\Users\vekt0R\Documents\Personal chest", "barbaren");
        x.ForAll(System.Console.WriteLine);
    }
}
internal static class Utils
{
    public static void ForAll<T>(this IEnumerable<T> e, Action<T> s)
    {
        foreach (var item in e) s(item);
    }
}