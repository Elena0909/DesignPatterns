namespace StatePattern.States;

public class Processed : IOrderState
{
    public void Next(Order order)
    {
        order.SetState(new Shipped());
    }

    public void Previous(Order order) 
    {
        order.SetState(new New());
    }

    public void PrintStatus()
    {
        Console.WriteLine("Order is Processed");
    }
}
