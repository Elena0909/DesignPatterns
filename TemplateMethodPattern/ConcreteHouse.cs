namespace TemplateMethodPattern;

public class ConcreteHouse : HouseTemplate
{
    protected override void BuildFoundation()
    {
        Console.WriteLine("Building Foundation with Cement, Iron Rods and Sand");
    }

    protected override void BuildPillars()
    {
        Console.WriteLine("Building Concrete Pillars with Cement and Sand");
    }

    protected override void BuildWalls()
    {
        Console.WriteLine("Building Concrete Walls");
    }

    protected override void BuildWindows()
    {
        Console.WriteLine("Building Concrete Windows");
    }
}
