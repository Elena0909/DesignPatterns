// See https://aka.ms/new-console-template for more information
using FacadePattern;

Console.WriteLine("Hello, World!");

Customer customer = new Customer()
{
    Name = "Anna",
    Email = "anna@endava.com",
    MobileNumber = "0774963063",
    Address = "Romania, Brasov"
};

CustomerRegistration customerRegistration = new CustomerRegistration();
customerRegistration.RegisterCustomer(customer);

