namespace Everything;

public static class Map
{
    static string[] BlackList = { };

    public static IEnumerable<string> Mapping(string root)
    {
        yield return root;

        var directories = Directory.GetDirectories(root).Where(x => !BlackList.Contains(x));
        var files = Directory.GetFiles(root);


        foreach (var item in files)
        {
            yield return item;
        }
        foreach (var item in directories)
        {
            foreach (var item2 in Mapping(item))
            {
                yield return item2;
            }
        }
    }
}