using StatePattern.States;

namespace StatePattern;

public class Order
{
    private IOrderState _currentState;

    public Order()
    {
        _currentState = new New();
    }

    public void SetState(IOrderState state)
    {
        _currentState = state;
    }

    public void NextState()
    {
        _currentState.Next(this);
    }

    public void PreviousState()
    {
        _currentState.Previous(this);
    }

    public void PrintStatus()
    {
        _currentState.PrintStatus();
    }
}
