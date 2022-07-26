namespace Everything;

public static class Searching
{
    public static IEnumerable<string> Search(string path, string query) => 
        Map.Mapping(path).
        Select(x=>(x,x.ToLower())).
        Where(x=>x.Item2.Contains(query.ToLower())).
        Select(x=>x.Item1);    
}