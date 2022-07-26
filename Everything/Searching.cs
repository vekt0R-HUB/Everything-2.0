namespace Everything;

public static class Searching
{
    private static IEnumerable<string> Maps = Map.Mapping();

    public static IEnumerable<string> Search(string query) => Maps.Where(x=>x.Contains(query));
}