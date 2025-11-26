
namespace AbstractFactoryPattern.Maps;

public class ForestMap :Map
{
    public ForestMap()
    {
        Name = "Forest";
    }
    public override void Draw()
    {
        Console.WriteLine($"Drawing {Name} map");
    }
}
