namespace FacadePattern;

public class CustomerRegistration
{
    public bool RegisterCustomer(Customer customer)
    {
        Validator validator = new Validator();
        bool isValid = validator.ValidatorCustomer(customer);

        CustomerDataAccessLayer layer = new CustomerDataAccessLayer();
        bool isSave = layer.SaveCustomer(customer);

        Email email = new Email();
        email.SendRegistrationEmail(customer);

        return true;
    }
}
