namespace CompositePattern;

public class FileComponent : FileSystemComponent
{
    public FileComponent(string name) : base(name) { }

    public override void Display(int level = 0)
    {
        //└
        string spaces = new string(' ', 2*level);
        Console.WriteLine(spaces + "└" + Name);
    }
}
