namespace Everything;

public static class Searching
{
    static string[] BlackList = {  };
    public static IEnumerable<string> Search(string path, string query) => 
        Mapping(path).
        Select(x=>(x,x.ToLower())).
        Where(x=>x.Item2.Contains(query.ToLower())).
        Select(x=>x.Item1);

    public static IEnumerable<string> Mapping(string root)
    {
        yield return root;

        var directories = Directory.GetDirectories(root).Where(x => !BlackList.Contains(x));
        var files = Directory.GetFiles(root);


        foreach (var item in files)
        {
            yield return item;
        }

        foreach (var item in directories.AsParallel())
        {
            foreach (var item2 in Mapping(item))
            {
                yield return item2;
            }
        }
    }
}