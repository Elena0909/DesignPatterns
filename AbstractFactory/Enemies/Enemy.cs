
namespace AbstractFactoryPattern.Enemies;

public abstract class Enemy
{
    public int HealthPointes { get; set; }

    public abstract void Spawn();
}
