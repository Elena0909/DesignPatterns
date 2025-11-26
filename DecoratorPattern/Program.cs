// See https://aka.ms/new-console-template for more information
using DecoratorPattern.Component;
using DecoratorPattern.Decorators;

Console.WriteLine("----- Decorator Pattern -----\n");

IBeverage coffee = new Coffee();

var late = new MilkDecorator(coffee);
var caramelLate = new CaramelDecorator(late);

Console.WriteLine($"Cost for {caramelLate.Description()} is {caramelLate.GetCost()}");