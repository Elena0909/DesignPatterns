
namespace AbstractFactoryPattern.Enemies;

public class VampireEnemy : Enemy
{
    public VampireEnemy()
    {
        HealthPointes = 100;
    }
    public override void Spawn()
    {
        Console.WriteLine($"Vampire  spawning with {HealthPointes} HP");
    }
}
