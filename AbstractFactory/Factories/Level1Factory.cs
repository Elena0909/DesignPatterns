using AbstractFactoryPattern.Enemies;
using AbstractFactoryPattern.Maps;

namespace AbstractFactoryPattern.Factories;

public class Level1Factory : ILevelFactory
{
    public Enemy CreateEnemy()
    {
        return new VampireEnemy();
    }

    public Map CreateMap()
    {
        return new CastleMap();
    }
}
