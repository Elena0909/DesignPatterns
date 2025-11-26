namespace CompositePattern;

public abstract class FileSystemComponent
{
    public string Name { get; }

    public FileSystemComponent(string name)
    {
        Name = name;
    }

    public abstract void Display(int level = 0);
}
