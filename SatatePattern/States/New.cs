namespace StatePattern.States;

public class New : IOrderState
{
    public void Next(Order order)
    {
        order.SetState(new Processed());
    }

    public void Previous(Order order) 
    {
        Console.WriteLine("The order is in its new state");
    }

    public void PrintStatus()
    {
        Console.WriteLine("Order is in New state");
    }
}
