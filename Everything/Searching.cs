namespace Everything;

public static class Searching
{
    public static IEnumerable<string> Search(string path, string query) => Map.Mapping(path).Where(x=>x.Contains(query));    
}