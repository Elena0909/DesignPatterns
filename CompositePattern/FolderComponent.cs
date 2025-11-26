namespace CompositePattern;

public class FolderComponent : FileSystemComponent
{
    private List<FileSystemComponent> _components = new List<FileSystemComponent>();
    public FolderComponent(string name) : base(name)
    {
    }

    public override void Display(int level = 0)
    {
        string spaces = new string(' ', 2*level);
        Console.WriteLine(spaces+"└" + Name);
        foreach (var component in _components)
        {
            component.Display(level + 1);
        }
    }

    public void AddComponent(FileSystemComponent component)
    {
        _components.Add(component);
    }

    public void RemoveComponent(FileSystemComponent component)
    {
        _components.Remove(component);
    }

}
