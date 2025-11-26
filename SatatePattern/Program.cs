// See https://aka.ms/new-console-template for more information
using StatePattern;
using StatePattern.States;

Console.WriteLine("----- State Pattern ------\n");

Order order = new Order();
order.PrintStatus(); 
order.NextState();
order.PrintStatus();  
order.NextState();
order.PrintStatus();  
order.PreviousState();
order.PrintStatus();  
order.SetState(new Canceled());
order.PrintStatus();  
