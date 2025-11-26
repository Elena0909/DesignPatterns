namespace StatePattern.States;

public class Shipped : IOrderState
{
    public void Next(Order order)
    {
        order.SetState(new Delivered());
    }

    public void Previous(Order order)
    {
        order.SetState(new Processed());
    }

    public void PrintStatus()
    {
        Console.WriteLine("Order is Shipped.");
    }
}
