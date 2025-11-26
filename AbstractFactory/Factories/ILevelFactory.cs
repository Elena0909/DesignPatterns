using AbstractFactoryPattern.Enemies;
using AbstractFactoryPattern.Maps;

namespace AbstractFactoryPattern.Factories;

public interface ILevelFactory
{
    Map CreateMap();

    Enemy CreateEnemy();
}
