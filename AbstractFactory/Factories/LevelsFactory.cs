using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern.Factories;

public class LevelsFactory
{
    private readonly Dictionary<int, ILevelFactory> levels = new Dictionary<int, ILevelFactory>();
    private int maxLevel = 2;
    public int Level { get;}

    public LevelsFactory()
    {
        levels[1] = new Level1Factory();
        levels[2] = new Level2Factory();
        Level = 1;
    }

    public ILevelFactory CreateLevel(int level)
    {
        return levels[level];
    }

}
