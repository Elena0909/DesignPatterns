namespace AbstractFactoryPattern.Enemies;

public class NinjaEnemy : Enemy
{
    public NinjaEnemy()
    {
        HealthPointes = 75;
    }

    public override void Spawn()
    {
        Console.WriteLine($"Ninja  spawning with {HealthPointes} HP");
    }
}
