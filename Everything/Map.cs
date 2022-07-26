namespace Everything;

public static class Map
{
    public static IEnumerable<string> Mapping()
    {
        var directory = Directory.GetParent(Directory.GetCurrentDirectory());
        var content = Path.Combine(directory!.FullName, "Content");
        return Mapping(content);
    }

    public static IEnumerable<string> Mapping(string root)
    {
        yield return root;

        var directories = Directory.EnumerateDirectories(root);
        var files = Directory.EnumerateFiles(root);

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