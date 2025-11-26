using AbstractFactoryPattern.Enemies;
using AbstractFactoryPattern.Maps;

namespace AbstractFactoryPattern.Factories;

public class Level2Factory : ILevelFactory
{
    public Enemy CreateEnemy()
    {
        return new NinjaEnemy();
    }

    public Map CreateMap()
    {
        return new ForestMap();
    }
}
