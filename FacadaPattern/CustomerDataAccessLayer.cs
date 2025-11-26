namespace FacadePattern;

public class CustomerDataAccessLayer
{
    public bool SaveCustomer(Customer customer)
    {
        Console.WriteLine("\nCustomer Saved into the Database...");
        return true;
    }
}
