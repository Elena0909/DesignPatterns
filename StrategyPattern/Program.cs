// See https://aka.ms/new-console-template for more information
using StrategyPattern;
using StrategyPattern.ConcreteStrategy;
using StrategyPattern.Context;
Console.WriteLine("---- Strategy Pattern ----\n");

Console.Write("1 for Car \n2 for Bus \n3 for Subway \n4 for Taxi\nPlease Enter Travel Type : ");
int travelType = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("You Select Travel type : " + travelType);

TravelContext ctx = new TravelContext();

if (travelType == (int)TravelType.Bus)
{
    ctx.SetTravelStrategy(new BusTravelStrategy());
}
else if (travelType == (int)TravelType.Subway)
{
    ctx.SetTravelStrategy(new SubwayTravelStrategy());
}
else if (travelType == (int)TravelType.Taxi)
{
    ctx.SetTravelStrategy(new TaxiTravelStrategy());
}
else if (travelType == (int)TravelType.Car)
{
    ctx.SetTravelStrategy(new CarTravelStrategy());
}
else
{
    Console.WriteLine("You Select an Invalid Option");
}

ctx.GoToAirport();
