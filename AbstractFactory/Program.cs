// See https://aka.ms/new-console-template for more information
using AbstractFactoryPattern.Enemies;
using AbstractFactoryPattern.Factories;
using AbstractFactoryPattern.Maps;
Console.WriteLine("----- Abstract Factory -----\n");

LevelsFactory levelsFactory = new LevelsFactory();

for (int level =1; level <=2; level++)
{
    Console.WriteLine($"Level {level}:");
    ILevelFactory factory = levelsFactory.CreateLevel(level);

    Enemy enemy = factory.CreateEnemy();
    Map map = factory.CreateMap();

    map.Draw();
    enemy.Spawn();
    Console.WriteLine();
}



