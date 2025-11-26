namespace StatePattern.States;

public class Canceled : IOrderState
{
    public void Next(Order order)
    {
        Console.WriteLine("Order is canceled and cannot proceed.");
    }

    public void Previous(Order order)
    {
        Console.WriteLine("Order is canceled and cannot go back.");
    }

    public void PrintStatus()
    {
        Console.WriteLine("Order is Canceled");
    }
}
