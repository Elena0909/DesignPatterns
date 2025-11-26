

namespace AbstractFactoryPattern.Maps;

internal class CastleMap:Map
{

    public CastleMap()
    {
        Name = "Castle";
    }
    public override void Draw()
    {
        Console.WriteLine($"Drawing {Name} map");
    }
}
