namespace StatePattern.States
{
    internal class Delivered : IOrderState
    {
        public void Next(Order order)
        {
            Console.WriteLine("Order is already delivered.");
        }

        public void Previous(Order order)
        {
            order.SetState(new Shipped());
        }

        public void PrintStatus()
        {
            Console.WriteLine("Order is delivered");
        }
    }
}
