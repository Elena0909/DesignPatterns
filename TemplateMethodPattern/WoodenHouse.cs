namespace TemplateMethodPattern;

public class WoodenHouse : HouseTemplate
{
    protected override void BuildFoundation()
    {
        Console.WriteLine("Building foundation with cement, iron rods, WOOD and sand");
    }

    protected override void BuildPillars()
    {
        Console.WriteLine("Building WOOD Pillars with WOOD coating");
    }

    protected override void BuildWalls()
    {
        Console.WriteLine("Building WOOD Walls");
    }

    protected override void BuildWindows()
    {
        Console.WriteLine("Building WOOD Windows");
    }
}
